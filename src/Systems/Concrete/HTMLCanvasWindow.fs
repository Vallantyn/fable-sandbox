namespace Systems.Implementations

open Fable.Core
open Browser.Dom
open HTML.Types

type HTMLCanvasWindow () =
    let _canvas = document.getElementsByTagName("canvas")[0] :?> HTMLCanvasElement
    
    interface Systems.IWindow with
        member __.Get () = _canvas
        member __.Width = int _canvas.width
        member __.Height = int _canvas.height
