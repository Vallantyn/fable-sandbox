module Core.Systems.Renderer

open Core.Systems.IRenderer

open Browser.Dom
open Fable.Core.JsInterop

open Types

type RendererSystem () =
    let canvas = document.getElementsByTagName("canvas")[0] :?> Browser.Types.HTMLCanvasElement
    let context = canvas.getContext_2d ()

    interface IRendererSystem with
        member _.Nope () = ()
        member _.Clear (rect) =
            rect
            |> rect2tuple
            |> context.clearRect