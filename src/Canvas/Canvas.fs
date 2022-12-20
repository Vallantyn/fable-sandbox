module Canvas

open System

open Browser.Dom
open Fable.Core.JsInterop

open Types

let internal canvas = document.getElementsByTagName("canvas")[0] :?> Browser.Types.HTMLCanvasElement
let internal context = canvas.getContext_2d ()

let setupWindow () =
    canvas.width  <- window.innerWidth
    canvas.height <- window.innerHeight

let onWindowResize event =
    setupWindow ()

type Colors =
    | Transparent
    override color.ToString() =
        match color with
        | Transparent -> "transparent"
    
type Color =
    | RGB of red:float * green:float * blue:float
    | HSL of hue:float * saturation:float * luminance:float
    | Hue of value:float
    | Name of name:Colors
    | Literal of value:string
    override color.ToString() =
        match color with
        | RGB (r, g, b) -> $"rgb({r},{g},{b})"
        | HSL (h, s, l) -> $"hsl({h},{s}%%,{l}%%)"
        | Hue v -> $"hsl({v},100%%,50%%)"
        | Name n -> $"{n}"
        | Literal s -> s

type Shape =
    | Square of size:float
    | Rectangle of size:Size
    | Circle of radius:float
    | Ellipse of radius:Size * rotation:float
    | Path
    member shape.Draw location =
        match shape with
        | Square size -> context.rect (location.x, location.y, size, size)
        | Rectangle size -> context.rect (location.x, location.y, size.w, size.h)
        | Circle radius -> context.arc (location.x, location.y, radius, 0., 2.*Math.PI)
        | Ellipse (radius, rotation) -> context.ellipse (location.x, location.y, radius.w, radius.h, rotation, 0., 2.*System.Math.PI)
        | _ -> () // TODO: implement paths

type Style = {stroke:Color;fill:Color}
let defaultStyle = {stroke=(Name Transparent); fill=(Name Transparent);}

let SetStrokeStyle (strokeStyle) =
    context.strokeStyle <- !^strokeStyle.ToString()

let SetFillStyle (fillStyle) =
    context.fillStyle <- !^fillStyle.ToString()

let SetStyle style =
    SetStrokeStyle style.stroke
    SetFillStyle style.fill

let Begin () = 
    context.beginPath ()

let Stroke () = 
    context.stroke ()

let Fill () = 
    context.fill ()
    
let End =
    Fill 
    >> Stroke

type DrawContext (?inStyle) =

    let previousStyle = {
        defaultStyle with
            fill   = Literal <| string context.fillStyle;
            stroke = Literal <| string context.strokeStyle;
    }

    let tempStyle = defaultArg inStyle previousStyle

    do (
        SetStyle tempStyle
        Begin ()
    )

    interface IDisposable with
        member _.Dispose () =
            End ()
            SetStyle previousStyle

let Clear rect =
    rect
    |> rect2tuple
    |> context.clearRect
