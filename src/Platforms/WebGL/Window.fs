namespace Platforms.WebGL

open Systems.Renderer

open HTML.Types

type Window () =
    let canvas = Browser.Dom.document.getElementsByTagName("canvas")[0] :?> HTMLCanvasElement

    interface IWindow with
        member this.Get() = canvas

        member _.Height
            with get () = int canvas.height
            and set value = canvas.height <- value

        member _.Width
            with get () = int canvas.width
            and set value = canvas.width <- value
