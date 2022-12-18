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

let setupWindow () =
    canvas.width  <- window.innerWidth
    canvas.height <- window.innerHeight
    
let onWindowResize event =
    setupWindow ()

let start' () =
    window.addEventListener ("resize", onWindowResize)

    setupWindow ()

    state.hue <- 0.

let update' dt =
    state.hue <- (state.hue + dt * 10.) % 360.

let padding = 10.
    
let draw' dt =
    ctx.fillStyle <- !^ $"hsl({state.hue}, 100%%, 50%%)"
    ctx.fillRect (padding, padding, canvas.width - padding * 2., canvas.height - padding * 2.)

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
