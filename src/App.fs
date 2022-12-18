module App

open Browser.Dom
open Fable.Core.JsInterop
open Fable.Import

let canvas = Browser.document.getElementsByTagName_canvas()[0]
let ctx = canvas.getContext_2d ()

let mutable lastTime = 0.

type State =
    struct
        val mutable hue: float
    end
        

let mutable state = State()

let start' () =
    state.hue <- 0.

let update' dt =
    state.hue <- (state.hue + dt * 10.) % 360.

let draw' dt =
    ctx.fillStyle <- !^ $"hsl({state.hue}, 100%%, 50%%)"
    ctx.fillRect (0., 0., canvas.width, canvas.height)

let rec loop time =
    let dt = (time - lastTime) / 1000.
    lastTime <- time
    
    update' dt

    ctx.clearRect (0., 0., canvas.width, canvas.height)
    draw' dt

    window.requestAnimationFrame(loop)
    |> ignore

start'()

window.requestAnimationFrame(loop)
|> ignore
