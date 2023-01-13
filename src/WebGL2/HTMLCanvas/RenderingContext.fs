// ts2fable 0.7.1
namespace HTML.Canvas.Types

open Fable.Core

open Canvas2D
open ImageBitmap
open WebGL.RenderingContext
open WebGL2.RenderingContext

type RenderingContext =
    U4<CanvasRenderingContext2D, ImageBitmapRenderingContext, WebGLRenderingContext, WebGL2RenderingContext>

type [<StringEnum; RequireQualifiedAccess>] RenderingContextType =
| [<CompiledName("2d")>] Canvas2D
| [<CompiledName("bitmaprenderer")>] BitmapRenderer
| [<CompiledName("webgl")>] WebGL
| [<CompiledName("webgl2")>] WebGL2

namespace HTML.Canvas

[<AutoOpen>]
module RenderingContext =

    open Fable.Core
    open HTML.Types
    open HTML.Canvas.Types

    type HTMLCanvasElement with
        /// <summary>
        /// Returns an object that provides methods and properties for drawing and manipulating images and graphics on a canvas element in a document.  
        /// A context object includes information about colors, line widths, fonts, and other graphic parameters that can be drawn on a canvas.
        /// </summary>
        /// <param name="contextId">The identifier (ID) of the type of canvas to create.<br/>Internet Explorer 9 and Internet Explorer 10 support only a 2-D context using `canvas.getContext("2d");`<br/>IE11 Preview also supports 3-D or WebGL context using `canvas.getContext("experimental-webgl");`</param>
        /// <param name="options">Options to pass to the context.</param>
        /// <returns>`Some RenderingContext` if successful, `None` otherwise.</returns>
        member __.getContext(contextId: RenderingContextType, ?options: obj): RenderingContext option = jsNative
