module App

open Browser.Dom
open Fable.Core.JsInterop
open Fable.Import

let canvas = Browser.document.getElementsByTagName_canvas()[0]
let ctx = canvas.getContext_2d ()

type State = {
    hue:float;
    time:float;
    deltaTime:float;
}

let hsl h s l = $"hsl({h},{s}%%,{l}%%)"
let hue h = hsl h 100 50

let fillRect (color: string) rect =
    ctx.fillStyle <- !^ color
    ctx.fillRect rect

let clearRect rect =
    ctx.clearRect rect

let setupWindow () =
    canvas.width  <- window.innerWidth
    canvas.height <- window.innerHeight

let onWindowResize event =
    setupWindow ()

let start' () =
    window.addEventListener ("resize", onWindowResize)
    setupWindow ()
    {
        hue=90.;
        time=0.;
        deltaTime=0.;
    }

let update' state:State =
    { state with hue = (state.hue + state.deltaTime * 10.) % 360. }

let padding = 10.

let draw' state =
    (
        padding, padding,
        canvas.width - padding * 2., canvas.height - padding * 2.
    ) |> fillRect (hue state.hue)

let rec loop time state =
    let dt = (time - state.time) / 1000.

    let state = { state with
                    time = time;
                    deltaTime = dt;
                } |> update'

    (0., 0., canvas.width, canvas.height)
    |> clearRect

    state
    |> draw'

    window.requestAnimationFrame (fun time -> state |> loop time)
    |> ignore

window.requestAnimationFrame (fun time -> start'() |> loop time)
|> ignore
