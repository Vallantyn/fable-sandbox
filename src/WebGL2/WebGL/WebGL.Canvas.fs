// ts2fable 0.7.1
module rec WebGL.Canvas
open System
open Fable.Core
open Fable.Core.JS


type [<AllowNullLiteral>] HTMLCanvasElement =
    [<Emit "$0.getContext('webgl',$1)">] abstract getContext_webgl: ?options: WebGLContextAttributes -> WebGLRenderingContext option
