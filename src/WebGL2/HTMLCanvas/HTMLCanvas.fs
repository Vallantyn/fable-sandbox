// ts2fable 0.7.1
namespace HTML.Types
// module rec HTMLCanvas

open System
open Fable.Core
open Fable.Core.JS

open Browser.Types
// open HTML.Types

// let [<Import("HTMLCanvasElementType","html-canvas")>] HTMLCanvasElementType: HTMLCanvasElementType = jsNative

// type [<AllowNullLiteral>] HTMLElementEventMap =
//     inherit ElementEventMap
//     inherit DocumentAndElementEventHandlersEventMap
//     inherit GlobalEventHandlersEventMap

/// Provides properties and methods for manipulating the layout and presentation of `<canvas>` elements.  
/// The HTMLCanvasElement interface also inherits the properties and methods of the HTMLElement interface.
type [<AllowNullLiteral>] HTMLCanvasElement =
    inherit HTMLElement
    /// Gets or sets the height of a canvas element on a document.
    abstract height: float with get, set
    /// Gets or sets the width of a canvas element on a document.
    abstract width: float with get, set
    
    // abstract captureStream: ?frameRequestRate: float -> MediaStream TODO: MediaStream
    /// <summary>Returns an object that provides methods and properties for drawing and manipulating images and graphics on a canvas element in a document.  
    /// A context object includes information about colors, line widths, fonts, and other graphic parameters that can be drawn on a canvas.</summary>
    /// <param name="options">Options</param>
    // [<Emit "$0.getContext('2d',$1)">] abstract getContext_2d: ?options: CanvasRenderingContext2DSettings -> CanvasRenderingContext2D option
    
    /// <summary>Returns an object that provides methods and properties for drawing and manipulating images and graphics on a canvas element in a document.  
    /// A context object includes information about colors, line widths, fonts, and other graphic parameters that can be drawn on a canvas.</summary>
    /// <param name="options">Options</param>
    // [<Emit "$0.getContext('bitmaprenderer',$1)">] abstract getContext_bitmaprenderer: ?options: ImageBitmapRenderingContextSettings -> ImageBitmapRenderingContext option
    
    /// <summary>Returns an object that provides methods and properties for drawing and manipulating images and graphics on a canvas element in a document.  
    /// A context object includes information about colors, line widths, fonts, and other graphic parameters that can be drawn on a canvas.</summary>
    /// <param name="options">Options</param>
    // [<Emit "$0.getContext('webgl',$1)">] abstract getContext_webgl: ?options: WebGLContextAttributes -> WebGLRenderingContext option
    
    /// <summary>Returns an object that provides methods and properties for drawing and manipulating images and graphics on a canvas element in a document.  
    /// A context object includes information about colors, line widths, fonts, and other graphic parameters that can be drawn on a canvas.</summary>
    /// <param name="options">Options</param>
    // [<Emit "$0.getContext('webgl2',$1)">] abstract getContext_webgl2: ?options: WebGLContextAttributes -> WebGL2RenderingContext option
    
    /// <summary>Returns an object that provides methods and properties for drawing and manipulating images and graphics on a canvas element in a document.  
    /// A context object includes information about colors, line widths, fonts, and other graphic parameters that can be drawn on a canvas.</summary>
    /// <param name="contextId">The identifier (ID) of the type of canvas to create.  
    /// Internet Explorer 9 and Internet Explorer 10 support only a 2-D context using `canvas.getContext("2d");`  
    /// IE11 Preview also supports 3-D or WebGL context using `canvas.getContext("experimental-webgl");`</param>
    /// <param name="options">Options</param>
    // abstract getContext: contextId: string * ?options: obj -> RenderingContext option
    
    abstract toBlob: callback: BlobCallback * ?``type``: string * ?quality: obj -> unit
    /// <summary>Returns the content of the current canvas as an image that you can use as a source for another canvas or an HTML element.</summary>
    /// <param name="type">The standard MIME type for the image format to return. If you do not specify this parameter, the default value is a PNG format image.</param>
    abstract toDataURL: ?``type``: string * ?quality: obj -> string
    // abstract transferControlToOffscreen: unit -> OffscreenCanvas
    // abstract addEventListener: ``type``: 'K * listener: (HTMLCanvasElement -> HTMLElementEventMap -> obj option) * ?options: U2<bool, AddEventListenerOptions> -> unit
    // abstract addEventListener: ``type``: string * listener: EventListenerOrEventListenerObject * ?options: U2<bool, AddEventListenerOptions> -> unit
    // abstract removeEventListener: ``type``: 'K * listener: (HTMLCanvasElement -> HTMLElementEventMap -> obj option) * ?options: U2<bool, EventListenerOptions> -> unit
    // abstract removeEventListener: ``type``: string * listener: EventListenerOrEventListenerObject * ?options: U2<bool, EventListenerOptions> -> unit

type [<AllowNullLiteral>] HTMLCanvasElementType =
    abstract prototype: HTMLCanvasElement with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

namespace HTML

open Fable.Core
open HTML.Types

[<AutoOpen>]
module HTMLCanvasElement =
    let [<Global>] HTMLCanvasElement: HTMLCanvasElementType = jsNative