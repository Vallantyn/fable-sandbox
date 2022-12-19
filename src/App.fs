module App

open Browser.Dom
open Fable.Core.JsInterop
open Fable.Import

let canvas = Browser.document.getElementsByTagName_canvas()[0]
let ctx = canvas.getContext_2d ()

type State = {
    time:float;
    deltaTime:float;
    color:HSL;
}

let fillStyle (color:string) =
    ctx.fillStyle <- !^ color

let fillRect color rect =
    color
    |> fillStyle

    rect
    |> rect2tuple
    |> ctx.fillRect

let clearRect rect =
    rect
    |> rect2tuple
    |> ctx.clearRect

let setupWindow () =
    canvas.width  <- window.innerWidth
    canvas.height <- window.innerHeight

let onWindowResize event =
    setupWindow ()

let start' () =
    window.addEventListener ("resize", onWindowResize)
    setupWindow ()
    {
        time=0.;
        deltaTime=0.;
        color=(hue 180.);
    }

let update' state:State =
    let hue = (state.color.h + state.deltaTime * 10.) % 360.
    let color = { state.color with h = hue }
    { state with color = color }

let padding = 10.

let draw' state =
    let p = (point' padding)
    let s = size (canvas.width - padding * 2.) (canvas.height - padding * 2.)

    (rect p s)
    |> fillRect (hsl2str state.color)

let rec loop time state =
    let dt = (time - state.time) / 1000.

    let state = 
        { state with
            time = time;
            deltaTime = dt;
        } |> update'

    let p = point' 0.
    let s = size canvas.width canvas.height

    (rect p s)
    |> clearRect

    state
    |> draw'

    window.requestAnimationFrame (fun time -> state |> loop time)
    |> ignore

start' ()
|> loop 0.
