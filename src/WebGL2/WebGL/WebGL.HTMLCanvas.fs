namespace WebGL

[<AutoOpen>]
module HTMLCanvas =
    open Fable.Core

    open HTML.Types

    type HTMLCanvasElement with
        [<Emit "$0.getContext('webgl',$1)">]
        member __.getContext_webgl(?options: WebGLContextAttributes): WebGLRenderingContext option = jsNative