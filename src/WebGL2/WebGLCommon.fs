// ts2fable 0.7.1
module rec WebGLCommon
open System
open Fable.Core
open Fable.Core.JS
open Browser.Types

let [<Import("CanvasCaptureMediaStreamTrackType","webgl-common")>] CanvasCaptureMediaStreamTrackType: CanvasCaptureMediaStreamTrackType = jsNative
let [<Import("CanvasGradientType","webgl-common")>] CanvasGradientType: CanvasGradientType = jsNative
let [<Import("CanvasPatternType","webgl-common")>] CanvasPatternType: CanvasPatternType = jsNative
let [<Import("CanvasRenderingContext2DType","webgl-common")>] CanvasRenderingContext2DType: CanvasRenderingContext2DType = jsNative
let [<Import("OffscreenCanvasType","webgl-common")>] OffscreenCanvasType: OffscreenCanvasType = jsNative
let [<Import("OffscreenCanvasRenderingContext2DType","webgl-common")>] OffscreenCanvasRenderingContext2DType: OffscreenCanvasRenderingContext2DType = jsNative
let [<Import("ImageBitmapType","webgl-common")>] ImageBitmapType: ImageBitmapType = jsNative
let [<Import("ImageBitmapRenderingContextType","webgl-common")>] ImageBitmapRenderingContextType: ImageBitmapRenderingContextType = jsNative
let [<Import("WebGL2RenderingContextType","webgl-common")>] WebGL2RenderingContextType: WebGL2RenderingContextType = jsNative
let [<Import("WebGLActiveInfoType","webgl-common")>] WebGLActiveInfoType: WebGLActiveInfoType = jsNative
let [<Import("WebGLBufferType","webgl-common")>] WebGLBufferType: WebGLBufferType = jsNative
let [<Import("WebGLContextEventType","webgl-common")>] WebGLContextEventType: WebGLContextEventType = jsNative
let [<Import("WebGLFramebufferType","webgl-common")>] WebGLFramebufferType: WebGLFramebufferType = jsNative
let [<Import("WebGLProgramType","webgl-common")>] WebGLProgramType: WebGLProgramType = jsNative
let [<Import("WebGLQueryType","webgl-common")>] WebGLQueryType: WebGLQueryType = jsNative
let [<Import("WebGLRenderbufferType","webgl-common")>] WebGLRenderbufferType: WebGLRenderbufferType = jsNative
let [<Import("WebGLRenderingContextType","webgl-common")>] WebGLRenderingContextType: WebGLRenderingContextType = jsNative
let [<Import("WebGLSamplerType","webgl-common")>] WebGLSamplerType: WebGLSamplerType = jsNative
let [<Import("WebGLShaderType","webgl-common")>] WebGLShaderType: WebGLShaderType = jsNative
let [<Import("WebGLShaderPrecisionFormatType","webgl-common")>] WebGLShaderPrecisionFormatType: WebGLShaderPrecisionFormatType = jsNative
let [<Import("WebGLSyncType","webgl-common")>] WebGLSyncType: WebGLSyncType = jsNative
let [<Import("WebGLTextureType","webgl-common")>] WebGLTextureType: WebGLTextureType = jsNative
let [<Import("WebGLTransformFeedbackType","webgl-common")>] WebGLTransformFeedbackType: WebGLTransformFeedbackType = jsNative
let [<Import("WebGLUniformLocationType","webgl-common")>] WebGLUniformLocationType: WebGLUniformLocationType = jsNative
let [<Import("WebGLVertexArrayObjectType","webgl-common")>] WebGLVertexArrayObjectType: WebGLVertexArrayObjectType = jsNative

type BufferSource =
    U2<ArrayBufferView, ArrayBuffer>

type TexImageSource =
    U6<ImageBitmap, ImageData, HTMLImageElement, HTMLCanvasElement, HTMLVideoElement, OffscreenCanvas>

type OffscreenRenderingContext =
    U4<OffscreenCanvasRenderingContext2D, ImageBitmapRenderingContext, WebGLRenderingContext, WebGL2RenderingContext>

type [<StringEnum>] [<RequireQualifiedAccess>] OffscreenRenderingContextId =
    | [<CompiledName "2d">] N2d
    | Bitmaprenderer
    | Webgl
    | Webgl2
    | Webgpu

type [<AllowNullLiteral>] CanvasCaptureMediaStreamTrack =
    inherit MediaStreamTrack
    abstract canvas: HTMLCanvasElement
    abstract requestFrame: unit -> unit
    abstract addEventListener: ``type``: 'K * listener: (CanvasCaptureMediaStreamTrack -> MediaStreamTrackEventMap -> obj option) * ?options: U2<bool, AddEventListenerOptions> -> unit
    abstract addEventListener: ``type``: string * listener: EventListenerOrEventListenerObject * ?options: U2<bool, AddEventListenerOptions> -> unit
    abstract removeEventListener: ``type``: 'K * listener: (CanvasCaptureMediaStreamTrack -> MediaStreamTrackEventMap -> obj option) * ?options: U2<bool, EventListenerOptions> -> unit
    abstract removeEventListener: ``type``: string * listener: EventListenerOrEventListenerObject * ?options: U2<bool, EventListenerOptions> -> unit

type [<AllowNullLiteral>] CanvasCompositing =
    abstract globalAlpha: float with get, set
    abstract globalCompositeOperation: GlobalCompositeOperation with get, set

type [<AllowNullLiteral>] CanvasDrawImage =
    abstract drawImage: image: CanvasImageSource * dx: float * dy: float -> unit
    abstract drawImage: image: CanvasImageSource * dx: float * dy: float * dw: float * dh: float -> unit
    abstract drawImage: image: CanvasImageSource * sx: float * sy: float * sw: float * sh: float * dx: float * dy: float * dw: float * dh: float -> unit

type [<AllowNullLiteral>] CanvasDrawPath =
    abstract beginPath: unit -> unit
    abstract clip: ?fillRule: CanvasFillRule -> unit
    abstract clip: path: Path2D * ?fillRule: CanvasFillRule -> unit
    abstract fill: ?fillRule: CanvasFillRule -> unit
    abstract fill: path: Path2D * ?fillRule: CanvasFillRule -> unit
    abstract isPointInPath: x: float * y: float * ?fillRule: CanvasFillRule -> bool
    abstract isPointInPath: path: Path2D * x: float * y: float * ?fillRule: CanvasFillRule -> bool
    abstract isPointInStroke: x: float * y: float -> bool
    abstract isPointInStroke: path: Path2D * x: float * y: float -> bool
    abstract stroke: unit -> unit
    abstract stroke: path: Path2D -> unit

type [<AllowNullLiteral>] CanvasFillStrokeStyles =
    abstract fillStyle: U3<string, CanvasGradient, CanvasPattern> with get, set
    abstract strokeStyle: U3<string, CanvasGradient, CanvasPattern> with get, set
    abstract createConicGradient: startAngle: float * x: float * y: float -> CanvasGradient
    abstract createLinearGradient: x0: float * y0: float * x1: float * y1: float -> CanvasGradient
    abstract createPattern: image: CanvasImageSource * repetition: string option -> CanvasPattern option
    abstract createRadialGradient: x0: float * y0: float * r0: float * x1: float * y1: float * r1: float -> CanvasGradient

type [<AllowNullLiteral>] CanvasFilters =
    abstract filter: string with get, set

/// An opaque object describing a gradient. It is returned by the methods CanvasRenderingContext2D.createLinearGradient() or CanvasRenderingContext2D.createRadialGradient().
type [<AllowNullLiteral>] CanvasGradient =
    /// Adds a color stop with the given color to the gradient at the given offset. 0.0 is the offset at one end of the gradient, 1.0 is the offset at the other end.
    /// 
    /// Throws an "IndexSizeError" DOMException if the offset is out of range. Throws a "SyntaxError" DOMException if the color cannot be parsed.
    abstract addColorStop: offset: float * color: string -> unit

type [<AllowNullLiteral>] CanvasImageData =
    abstract createImageData: sw: float * sh: float * ?settings: ImageDataSettings -> ImageData
    abstract createImageData: imagedata: ImageData -> ImageData
    abstract getImageData: sx: float * sy: float * sw: float * sh: float * ?settings: ImageDataSettings -> ImageData
    abstract putImageData: imagedata: ImageData * dx: float * dy: float -> unit
    abstract putImageData: imagedata: ImageData * dx: float * dy: float * dirtyX: float * dirtyY: float * dirtyWidth: float * dirtyHeight: float -> unit

type [<AllowNullLiteral>] CanvasImageSmoothing =
    abstract imageSmoothingEnabled: bool with get, set
    abstract imageSmoothingQuality: ImageSmoothingQuality with get, set

type [<AllowNullLiteral>] CanvasPath =
    abstract arc: x: float * y: float * radius: float * startAngle: float * endAngle: float * ?counterclockwise: bool -> unit
    abstract arcTo: x1: float * y1: float * x2: float * y2: float * radius: float -> unit
    abstract bezierCurveTo: cp1x: float * cp1y: float * cp2x: float * cp2y: float * x: float * y: float -> unit
    abstract closePath: unit -> unit
    abstract ellipse: x: float * y: float * radiusX: float * radiusY: float * rotation: float * startAngle: float * endAngle: float * ?counterclockwise: bool -> unit
    abstract lineTo: x: float * y: float -> unit
    abstract moveTo: x: float * y: float -> unit
    abstract quadraticCurveTo: cpx: float * cpy: float * x: float * y: float -> unit
    abstract rect: x: float * y: float * w: float * h: float -> unit
    abstract roundRect: x: float * y: float * w: float * h: float * ?radii: U3<float, DOMPointInit, ResizeArray<U2<float, DOMPointInit>>> -> unit

type [<AllowNullLiteral>] CanvasPathDrawingStyles =
    abstract lineCap: CanvasLineCap with get, set
    abstract lineDashOffset: float with get, set
    abstract lineJoin: CanvasLineJoin with get, set
    abstract lineWidth: float with get, set
    abstract miterLimit: float with get, set
    abstract getLineDash: unit -> ResizeArray<float>
    abstract setLineDash: segments: ResizeArray<float> -> unit

/// An opaque object describing a pattern, based on an image, a canvas, or a video, created by the CanvasRenderingContext2D.createPattern() method.
type [<AllowNullLiteral>] CanvasPattern =
    /// Sets the transformation matrix that will be used when rendering the pattern during a fill or stroke painting operation.
    abstract setTransform: ?transform: DOMMatrix2DInit -> unit

type [<AllowNullLiteral>] CanvasRect =
    abstract clearRect: x: float * y: float * w: float * h: float -> unit
    abstract fillRect: x: float * y: float * w: float * h: float -> unit
    abstract strokeRect: x: float * y: float * w: float * h: float -> unit

/// The CanvasRenderingContext2D interface, part of the Canvas API, provides the 2D rendering context for the drawing surface of a <canvas> element. It is used for drawing shapes, text, images, and other objects.
type [<AllowNullLiteral>] CanvasRenderingContext2D =
    inherit CanvasCompositing
    inherit CanvasDrawImage
    inherit CanvasDrawPath
    inherit CanvasFillStrokeStyles
    inherit CanvasFilters
    inherit CanvasImageData
    inherit CanvasImageSmoothing
    inherit CanvasPath
    inherit CanvasPathDrawingStyles
    inherit CanvasRect
    inherit CanvasShadowStyles
    inherit CanvasState
    inherit CanvasText
    inherit CanvasTextDrawingStyles
    inherit CanvasTransform
    inherit CanvasUserInterface
    abstract canvas: HTMLCanvasElement
    abstract getContextAttributes: unit -> CanvasRenderingContext2DSettings

type [<AllowNullLiteral>] CanvasShadowStyles =
    abstract shadowBlur: float with get, set
    abstract shadowColor: string with get, set
    abstract shadowOffsetX: float with get, set
    abstract shadowOffsetY: float with get, set

type [<AllowNullLiteral>] CanvasState =
    abstract restore: unit -> unit
    abstract save: unit -> unit

type [<AllowNullLiteral>] CanvasText =
    abstract fillText: text: string * x: float * y: float * ?maxWidth: float -> unit
    abstract measureText: text: string -> TextMetrics
    abstract strokeText: text: string * x: float * y: float * ?maxWidth: float -> unit

type [<AllowNullLiteral>] CanvasTextDrawingStyles =
    abstract direction: CanvasDirection with get, set
    abstract font: string with get, set
    abstract fontKerning: CanvasFontKerning with get, set
    abstract textAlign: CanvasTextAlign with get, set
    abstract textBaseline: CanvasTextBaseline with get, set

type [<AllowNullLiteral>] CanvasTransform =
    abstract getTransform: unit -> DOMMatrix
    abstract resetTransform: unit -> unit
    abstract rotate: angle: float -> unit
    abstract scale: x: float * y: float -> unit
    abstract setTransform: a: float * b: float * c: float * d: float * e: float * f: float -> unit
    abstract setTransform: ?transform: DOMMatrix2DInit -> unit
    abstract transform: a: float * b: float * c: float * d: float * e: float * f: float -> unit
    abstract translate: x: float * y: float -> unit

type [<AllowNullLiteral>] CanvasUserInterface =
    abstract drawFocusIfNeeded: element: Element -> unit
    abstract drawFocusIfNeeded: path: Path2D * element: Element -> unit

type [<AllowNullLiteral>] OffscreenCanvas =
    inherit EventTarget
    /// These attributes return the dimensions of the OffscreenCanvas object's bitmap.
    /// 
    /// They can be set, to replace the bitmap with a new, transparent black bitmap of the specified dimensions (effectively resizing it).
    abstract height: float with get, set
    abstract oncontextlost: (OffscreenCanvas -> Event -> obj option) option with get, set
    abstract oncontextrestored: (OffscreenCanvas -> Event -> obj option) option with get, set
    /// These attributes return the dimensions of the OffscreenCanvas object's bitmap.
    /// 
    /// They can be set, to replace the bitmap with a new, transparent black bitmap of the specified dimensions (effectively resizing it).
    abstract width: float with get, set
    /// Returns an object that exposes an API for drawing on the OffscreenCanvas object. contextId specifies the desired API: "2d", "bitmaprenderer", "webgl", or "webgl2". options is handled by that API.
    /// 
    /// This specification defines the "2d" context below, which is similar but distinct from the "2d" context that is created from a canvas element. The WebGL specifications define the "webgl" and "webgl2" contexts. [WEBGL]
    /// 
    /// Returns null if the canvas has already been initialized with another context type (e.g., trying to get a "2d" context after getting a "webgl" context).
    abstract getContext: contextId: OffscreenRenderingContextId * ?options: obj -> OffscreenRenderingContext option
    /// Returns a newly created ImageBitmap object with the image in the OffscreenCanvas object. The image in the OffscreenCanvas object is replaced with a new blank image.
    abstract transferToImageBitmap: unit -> ImageBitmap
    abstract addEventListener: ``type``: 'K * listener: (OffscreenCanvas -> OffscreenCanvasEventMap -> obj option) * ?options: U2<bool, AddEventListenerOptions> -> unit
    abstract addEventListener: ``type``: string * listener: EventListenerOrEventListenerObject * ?options: U2<bool, AddEventListenerOptions> -> unit
    abstract removeEventListener: ``type``: 'K * listener: (OffscreenCanvas -> OffscreenCanvasEventMap -> obj option) * ?options: U2<bool, EventListenerOptions> -> unit
    abstract removeEventListener: ``type``: string * listener: EventListenerOrEventListenerObject * ?options: U2<bool, EventListenerOptions> -> unit

type [<AllowNullLiteral>] OffscreenCanvasRenderingContext2D =
    inherit CanvasCompositing
    inherit CanvasDrawImage
    inherit CanvasDrawPath
    inherit CanvasFillStrokeStyles
    inherit CanvasFilters
    inherit CanvasImageData
    inherit CanvasImageSmoothing
    inherit CanvasPath
    inherit CanvasPathDrawingStyles
    inherit CanvasRect
    inherit CanvasShadowStyles
    inherit CanvasState
    inherit CanvasText
    inherit CanvasTextDrawingStyles
    inherit CanvasTransform
    abstract canvas: OffscreenCanvas
    abstract commit: unit -> unit

type [<AllowNullLiteral>] ImageBitmap =
    /// Returns the intrinsic height of the image, in CSS pixels.
    abstract height: float
    /// Returns the intrinsic width of the image, in CSS pixels.
    abstract width: float
    /// Releases imageBitmap's underlying bitmap data.
    abstract close: unit -> unit

type [<AllowNullLiteral>] ImageBitmapRenderingContext =
    /// Returns the canvas element that the context is bound to.
    abstract canvas: U2<HTMLCanvasElement, OffscreenCanvas>
    /// Transfers the underlying bitmap data from imageBitmap to context, and the bitmap becomes the contents of the canvas element to which context is bound.
    abstract transferFromImageBitmap: bitmap: ImageBitmap option -> unit

type GLbitfield =
    float

type GLboolean =
    bool

type GLclampf =
    float

type GLenum =
    float

type GLfloat =
    float

type GLint =
    float

type GLint64 =
    float

type GLintptr =
    float

type GLsizei =
    float

type GLsizeiptr =
    float

type GLuint =
    float

type GLuint64 =
    float

type Float32List =
    U2<Float32Array, ResizeArray<GLfloat>>

type Int32List =
    U2<Int32Array, ResizeArray<GLint>>

type Uint32List =
    U2<Uint32Array, ResizeArray<GLuint>>

type [<AllowNullLiteral>] WEBGL_color_buffer_float =
    abstract FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT: GLenum
    abstract RGBA32F_EXT: GLenum
    abstract UNSIGNED_NORMALIZED_EXT: GLenum

type [<AllowNullLiteral>] WEBGL_compressed_texture_astc =
    abstract getSupportedProfiles: unit -> ResizeArray<string>
    abstract COMPRESSED_RGBA_ASTC_10x10_KHR: GLenum
    abstract COMPRESSED_RGBA_ASTC_10x5_KHR: GLenum
    abstract COMPRESSED_RGBA_ASTC_10x6_KHR: GLenum
    abstract COMPRESSED_RGBA_ASTC_10x8_KHR: GLenum
    abstract COMPRESSED_RGBA_ASTC_12x10_KHR: GLenum
    abstract COMPRESSED_RGBA_ASTC_12x12_KHR: GLenum
    abstract COMPRESSED_RGBA_ASTC_4x4_KHR: GLenum
    abstract COMPRESSED_RGBA_ASTC_5x4_KHR: GLenum
    abstract COMPRESSED_RGBA_ASTC_5x5_KHR: GLenum
    abstract COMPRESSED_RGBA_ASTC_6x5_KHR: GLenum
    abstract COMPRESSED_RGBA_ASTC_6x6_KHR: GLenum
    abstract COMPRESSED_RGBA_ASTC_8x5_KHR: GLenum
    abstract COMPRESSED_RGBA_ASTC_8x6_KHR: GLenum
    abstract COMPRESSED_RGBA_ASTC_8x8_KHR: GLenum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR: GLenum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR: GLenum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR: GLenum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR: GLenum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR: GLenum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR: GLenum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR: GLenum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR: GLenum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR: GLenum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR: GLenum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR: GLenum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR: GLenum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR: GLenum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR: GLenum

type [<AllowNullLiteral>] WEBGL_compressed_texture_etc =
    abstract COMPRESSED_R11_EAC: GLenum
    abstract COMPRESSED_RG11_EAC: GLenum
    abstract COMPRESSED_RGB8_ETC2: GLenum
    abstract COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2: GLenum
    abstract COMPRESSED_RGBA8_ETC2_EAC: GLenum
    abstract COMPRESSED_SIGNED_R11_EAC: GLenum
    abstract COMPRESSED_SIGNED_RG11_EAC: GLenum
    abstract COMPRESSED_SRGB8_ALPHA8_ETC2_EAC: GLenum
    abstract COMPRESSED_SRGB8_ETC2: GLenum
    abstract COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2: GLenum

type [<AllowNullLiteral>] WEBGL_compressed_texture_etc1 =
    abstract COMPRESSED_RGB_ETC1_WEBGL: GLenum

/// The WEBGL_compressed_texture_s3tc extension is part of the WebGL API and exposes four S3TC compressed texture formats.
type [<AllowNullLiteral>] WEBGL_compressed_texture_s3tc =
    abstract COMPRESSED_RGBA_S3TC_DXT1_EXT: GLenum
    abstract COMPRESSED_RGBA_S3TC_DXT3_EXT: GLenum
    abstract COMPRESSED_RGBA_S3TC_DXT5_EXT: GLenum
    abstract COMPRESSED_RGB_S3TC_DXT1_EXT: GLenum

type [<AllowNullLiteral>] WEBGL_compressed_texture_s3tc_srgb =
    abstract COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT: GLenum
    abstract COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT: GLenum
    abstract COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT: GLenum
    abstract COMPRESSED_SRGB_S3TC_DXT1_EXT: GLenum

/// The WEBGL_debug_renderer_info extension is part of the WebGL API and exposes two constants with information about the graphics driver for debugging purposes.
type [<AllowNullLiteral>] WEBGL_debug_renderer_info =
    abstract UNMASKED_RENDERER_WEBGL: GLenum
    abstract UNMASKED_VENDOR_WEBGL: GLenum

type [<AllowNullLiteral>] WEBGL_debug_shaders =
    abstract getTranslatedShaderSource: shader: WebGLShader -> string

/// The WEBGL_depth_texture extension is part of the WebGL API and defines 2D depth and depth-stencil textures.
type [<AllowNullLiteral>] WEBGL_depth_texture =
    abstract UNSIGNED_INT_24_8_WEBGL: GLenum

type [<AllowNullLiteral>] WEBGL_draw_buffers =
    abstract drawBuffersWEBGL: buffers: ResizeArray<GLenum> -> unit
    abstract COLOR_ATTACHMENT0_WEBGL: GLenum
    abstract COLOR_ATTACHMENT10_WEBGL: GLenum
    abstract COLOR_ATTACHMENT11_WEBGL: GLenum
    abstract COLOR_ATTACHMENT12_WEBGL: GLenum
    abstract COLOR_ATTACHMENT13_WEBGL: GLenum
    abstract COLOR_ATTACHMENT14_WEBGL: GLenum
    abstract COLOR_ATTACHMENT15_WEBGL: GLenum
    abstract COLOR_ATTACHMENT1_WEBGL: GLenum
    abstract COLOR_ATTACHMENT2_WEBGL: GLenum
    abstract COLOR_ATTACHMENT3_WEBGL: GLenum
    abstract COLOR_ATTACHMENT4_WEBGL: GLenum
    abstract COLOR_ATTACHMENT5_WEBGL: GLenum
    abstract COLOR_ATTACHMENT6_WEBGL: GLenum
    abstract COLOR_ATTACHMENT7_WEBGL: GLenum
    abstract COLOR_ATTACHMENT8_WEBGL: GLenum
    abstract COLOR_ATTACHMENT9_WEBGL: GLenum
    abstract DRAW_BUFFER0_WEBGL: GLenum
    abstract DRAW_BUFFER10_WEBGL: GLenum
    abstract DRAW_BUFFER11_WEBGL: GLenum
    abstract DRAW_BUFFER12_WEBGL: GLenum
    abstract DRAW_BUFFER13_WEBGL: GLenum
    abstract DRAW_BUFFER14_WEBGL: GLenum
    abstract DRAW_BUFFER15_WEBGL: GLenum
    abstract DRAW_BUFFER1_WEBGL: GLenum
    abstract DRAW_BUFFER2_WEBGL: GLenum
    abstract DRAW_BUFFER3_WEBGL: GLenum
    abstract DRAW_BUFFER4_WEBGL: GLenum
    abstract DRAW_BUFFER5_WEBGL: GLenum
    abstract DRAW_BUFFER6_WEBGL: GLenum
    abstract DRAW_BUFFER7_WEBGL: GLenum
    abstract DRAW_BUFFER8_WEBGL: GLenum
    abstract DRAW_BUFFER9_WEBGL: GLenum
    abstract MAX_COLOR_ATTACHMENTS_WEBGL: GLenum
    abstract MAX_DRAW_BUFFERS_WEBGL: GLenum

type [<AllowNullLiteral>] WEBGL_lose_context =
    abstract loseContext: unit -> unit
    abstract restoreContext: unit -> unit

type [<AllowNullLiteral>] WEBGL_multi_draw =
    abstract multiDrawArraysInstancedWEBGL: mode: GLenum * firstsList: U2<Int32Array, ResizeArray<GLint>> * firstsOffset: GLuint * countsList: U2<Int32Array, ResizeArray<GLsizei>> * countsOffset: GLuint * instanceCountsList: U2<Int32Array, ResizeArray<GLsizei>> * instanceCountsOffset: GLuint * drawcount: GLsizei -> unit
    abstract multiDrawArraysWEBGL: mode: GLenum * firstsList: U2<Int32Array, ResizeArray<GLint>> * firstsOffset: GLuint * countsList: U2<Int32Array, ResizeArray<GLsizei>> * countsOffset: GLuint * drawcount: GLsizei -> unit
    abstract multiDrawElementsInstancedWEBGL: mode: GLenum * countsList: U2<Int32Array, ResizeArray<GLsizei>> * countsOffset: GLuint * ``type``: GLenum * offsetsList: U2<Int32Array, ResizeArray<GLsizei>> * offsetsOffset: GLuint * instanceCountsList: U2<Int32Array, ResizeArray<GLsizei>> * instanceCountsOffset: GLuint * drawcount: GLsizei -> unit
    abstract multiDrawElementsWEBGL: mode: GLenum * countsList: U2<Int32Array, ResizeArray<GLsizei>> * countsOffset: GLuint * ``type``: GLenum * offsetsList: U2<Int32Array, ResizeArray<GLsizei>> * offsetsOffset: GLuint * drawcount: GLsizei -> unit

type [<AllowNullLiteral>] WebGL2RenderingContext =
    inherit WebGL2RenderingContextBase
    inherit WebGL2RenderingContextOverloads
    inherit WebGLRenderingContextBase

type [<AllowNullLiteral>] WebGL2RenderingContextBase =
    abstract beginQuery: target: GLenum * query: WebGLQuery -> unit
    abstract beginTransformFeedback: primitiveMode: GLenum -> unit
    abstract bindBufferBase: target: GLenum * index: GLuint * buffer: WebGLBuffer option -> unit
    abstract bindBufferRange: target: GLenum * index: GLuint * buffer: WebGLBuffer option * offset: GLintptr * size: GLsizeiptr -> unit
    abstract bindSampler: unit: GLuint * sampler: WebGLSampler option -> unit
    abstract bindTransformFeedback: target: GLenum * tf: WebGLTransformFeedback option -> unit
    abstract bindVertexArray: array: WebGLVertexArrayObject option -> unit
    abstract blitFramebuffer: srcX0: GLint * srcY0: GLint * srcX1: GLint * srcY1: GLint * dstX0: GLint * dstY0: GLint * dstX1: GLint * dstY1: GLint * mask: GLbitfield * filter: GLenum -> unit
    abstract clearBufferfi: buffer: GLenum * drawbuffer: GLint * depth: GLfloat * stencil: GLint -> unit
    abstract clearBufferfv: buffer: GLenum * drawbuffer: GLint * values: Float32List * ?srcOffset: GLuint -> unit
    abstract clearBufferiv: buffer: GLenum * drawbuffer: GLint * values: Int32List * ?srcOffset: GLuint -> unit
    abstract clearBufferuiv: buffer: GLenum * drawbuffer: GLint * values: Uint32List * ?srcOffset: GLuint -> unit
    abstract clientWaitSync: sync: WebGLSync * flags: GLbitfield * timeout: GLuint64 -> GLenum
    abstract compressedTexImage3D: target: GLenum * level: GLint * internalformat: GLenum * width: GLsizei * height: GLsizei * depth: GLsizei * border: GLint * imageSize: GLsizei * offset: GLintptr -> unit
    abstract compressedTexImage3D: target: GLenum * level: GLint * internalformat: GLenum * width: GLsizei * height: GLsizei * depth: GLsizei * border: GLint * srcData: ArrayBufferView * ?srcOffset: GLuint * ?srcLengthOverride: GLuint -> unit
    abstract compressedTexSubImage3D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * zoffset: GLint * width: GLsizei * height: GLsizei * depth: GLsizei * format: GLenum * imageSize: GLsizei * offset: GLintptr -> unit
    abstract compressedTexSubImage3D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * zoffset: GLint * width: GLsizei * height: GLsizei * depth: GLsizei * format: GLenum * srcData: ArrayBufferView * ?srcOffset: GLuint * ?srcLengthOverride: GLuint -> unit
    abstract copyBufferSubData: readTarget: GLenum * writeTarget: GLenum * readOffset: GLintptr * writeOffset: GLintptr * size: GLsizeiptr -> unit
    abstract copyTexSubImage3D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * zoffset: GLint * x: GLint * y: GLint * width: GLsizei * height: GLsizei -> unit
    abstract createQuery: unit -> WebGLQuery option
    abstract createSampler: unit -> WebGLSampler option
    abstract createTransformFeedback: unit -> WebGLTransformFeedback option
    abstract createVertexArray: unit -> WebGLVertexArrayObject option
    abstract deleteQuery: query: WebGLQuery option -> unit
    abstract deleteSampler: sampler: WebGLSampler option -> unit
    abstract deleteSync: sync: WebGLSync option -> unit
    abstract deleteTransformFeedback: tf: WebGLTransformFeedback option -> unit
    abstract deleteVertexArray: vertexArray: WebGLVertexArrayObject option -> unit
    abstract drawArraysInstanced: mode: GLenum * first: GLint * count: GLsizei * instanceCount: GLsizei -> unit
    abstract drawBuffers: buffers: ResizeArray<GLenum> -> unit
    abstract drawElementsInstanced: mode: GLenum * count: GLsizei * ``type``: GLenum * offset: GLintptr * instanceCount: GLsizei -> unit
    abstract drawRangeElements: mode: GLenum * start: GLuint * ``end``: GLuint * count: GLsizei * ``type``: GLenum * offset: GLintptr -> unit
    abstract endQuery: target: GLenum -> unit
    abstract endTransformFeedback: unit -> unit
    abstract fenceSync: condition: GLenum * flags: GLbitfield -> WebGLSync option
    abstract framebufferTextureLayer: target: GLenum * attachment: GLenum * texture: WebGLTexture option * level: GLint * layer: GLint -> unit
    abstract getActiveUniformBlockName: program: WebGLProgram * uniformBlockIndex: GLuint -> string option
    abstract getActiveUniformBlockParameter: program: WebGLProgram * uniformBlockIndex: GLuint * pname: GLenum -> obj option
    abstract getActiveUniforms: program: WebGLProgram * uniformIndices: ResizeArray<GLuint> * pname: GLenum -> obj option
    abstract getBufferSubData: target: GLenum * srcByteOffset: GLintptr * dstBuffer: ArrayBufferView * ?dstOffset: GLuint * ?length: GLuint -> unit
    abstract getFragDataLocation: program: WebGLProgram * name: string -> GLint
    abstract getIndexedParameter: target: GLenum * index: GLuint -> obj option
    abstract getInternalformatParameter: target: GLenum * internalformat: GLenum * pname: GLenum -> obj option
    abstract getQuery: target: GLenum * pname: GLenum -> WebGLQuery option
    abstract getQueryParameter: query: WebGLQuery * pname: GLenum -> obj option
    abstract getSamplerParameter: sampler: WebGLSampler * pname: GLenum -> obj option
    abstract getSyncParameter: sync: WebGLSync * pname: GLenum -> obj option
    abstract getTransformFeedbackVarying: program: WebGLProgram * index: GLuint -> WebGLActiveInfo option
    abstract getUniformBlockIndex: program: WebGLProgram * uniformBlockName: string -> GLuint
    abstract getUniformIndices: program: WebGLProgram * uniformNames: ResizeArray<string> -> ResizeArray<GLuint> option
    abstract invalidateFramebuffer: target: GLenum * attachments: ResizeArray<GLenum> -> unit
    abstract invalidateSubFramebuffer: target: GLenum * attachments: ResizeArray<GLenum> * x: GLint * y: GLint * width: GLsizei * height: GLsizei -> unit
    abstract isQuery: query: WebGLQuery option -> GLboolean
    abstract isSampler: sampler: WebGLSampler option -> GLboolean
    abstract isSync: sync: WebGLSync option -> GLboolean
    abstract isTransformFeedback: tf: WebGLTransformFeedback option -> GLboolean
    abstract isVertexArray: vertexArray: WebGLVertexArrayObject option -> GLboolean
    abstract pauseTransformFeedback: unit -> unit
    abstract readBuffer: src: GLenum -> unit
    abstract renderbufferStorageMultisample: target: GLenum * samples: GLsizei * internalformat: GLenum * width: GLsizei * height: GLsizei -> unit
    abstract resumeTransformFeedback: unit -> unit
    abstract samplerParameterf: sampler: WebGLSampler * pname: GLenum * param: GLfloat -> unit
    abstract samplerParameteri: sampler: WebGLSampler * pname: GLenum * param: GLint -> unit
    abstract texImage3D: target: GLenum * level: GLint * internalformat: GLint * width: GLsizei * height: GLsizei * depth: GLsizei * border: GLint * format: GLenum * ``type``: GLenum * pboOffset: GLintptr -> unit
    abstract texImage3D: target: GLenum * level: GLint * internalformat: GLint * width: GLsizei * height: GLsizei * depth: GLsizei * border: GLint * format: GLenum * ``type``: GLenum * source: TexImageSource -> unit
    abstract texImage3D: target: GLenum * level: GLint * internalformat: GLint * width: GLsizei * height: GLsizei * depth: GLsizei * border: GLint * format: GLenum * ``type``: GLenum * srcData: ArrayBufferView option -> unit
    abstract texImage3D: target: GLenum * level: GLint * internalformat: GLint * width: GLsizei * height: GLsizei * depth: GLsizei * border: GLint * format: GLenum * ``type``: GLenum * srcData: ArrayBufferView * srcOffset: GLuint -> unit
    abstract texStorage2D: target: GLenum * levels: GLsizei * internalformat: GLenum * width: GLsizei * height: GLsizei -> unit
    abstract texStorage3D: target: GLenum * levels: GLsizei * internalformat: GLenum * width: GLsizei * height: GLsizei * depth: GLsizei -> unit
    abstract texSubImage3D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * zoffset: GLint * width: GLsizei * height: GLsizei * depth: GLsizei * format: GLenum * ``type``: GLenum * pboOffset: GLintptr -> unit
    abstract texSubImage3D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * zoffset: GLint * width: GLsizei * height: GLsizei * depth: GLsizei * format: GLenum * ``type``: GLenum * source: TexImageSource -> unit
    abstract texSubImage3D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * zoffset: GLint * width: GLsizei * height: GLsizei * depth: GLsizei * format: GLenum * ``type``: GLenum * srcData: ArrayBufferView option * ?srcOffset: GLuint -> unit
    abstract transformFeedbackVaryings: program: WebGLProgram * varyings: ResizeArray<string> * bufferMode: GLenum -> unit
    abstract uniform1ui: location: WebGLUniformLocation option * v0: GLuint -> unit
    abstract uniform1uiv: location: WebGLUniformLocation option * data: Uint32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniform2ui: location: WebGLUniformLocation option * v0: GLuint * v1: GLuint -> unit
    abstract uniform2uiv: location: WebGLUniformLocation option * data: Uint32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniform3ui: location: WebGLUniformLocation option * v0: GLuint * v1: GLuint * v2: GLuint -> unit
    abstract uniform3uiv: location: WebGLUniformLocation option * data: Uint32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniform4ui: location: WebGLUniformLocation option * v0: GLuint * v1: GLuint * v2: GLuint * v3: GLuint -> unit
    abstract uniform4uiv: location: WebGLUniformLocation option * data: Uint32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniformBlockBinding: program: WebGLProgram * uniformBlockIndex: GLuint * uniformBlockBinding: GLuint -> unit
    abstract uniformMatrix2x3fv: location: WebGLUniformLocation option * transpose: GLboolean * data: Float32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniformMatrix2x4fv: location: WebGLUniformLocation option * transpose: GLboolean * data: Float32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniformMatrix3x2fv: location: WebGLUniformLocation option * transpose: GLboolean * data: Float32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniformMatrix3x4fv: location: WebGLUniformLocation option * transpose: GLboolean * data: Float32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniformMatrix4x2fv: location: WebGLUniformLocation option * transpose: GLboolean * data: Float32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniformMatrix4x3fv: location: WebGLUniformLocation option * transpose: GLboolean * data: Float32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract vertexAttribDivisor: index: GLuint * divisor: GLuint -> unit
    abstract vertexAttribI4i: index: GLuint * x: GLint * y: GLint * z: GLint * w: GLint -> unit
    abstract vertexAttribI4iv: index: GLuint * values: Int32List -> unit
    abstract vertexAttribI4ui: index: GLuint * x: GLuint * y: GLuint * z: GLuint * w: GLuint -> unit
    abstract vertexAttribI4uiv: index: GLuint * values: Uint32List -> unit
    abstract vertexAttribIPointer: index: GLuint * size: GLint * ``type``: GLenum * stride: GLsizei * offset: GLintptr -> unit
    abstract waitSync: sync: WebGLSync * flags: GLbitfield * timeout: GLint64 -> unit
    abstract ACTIVE_UNIFORM_BLOCKS: GLenum
    abstract ALREADY_SIGNALED: GLenum
    abstract ANY_SAMPLES_PASSED: GLenum
    abstract ANY_SAMPLES_PASSED_CONSERVATIVE: GLenum
    abstract COLOR: GLenum
    abstract COLOR_ATTACHMENT1: GLenum
    abstract COLOR_ATTACHMENT10: GLenum
    abstract COLOR_ATTACHMENT11: GLenum
    abstract COLOR_ATTACHMENT12: GLenum
    abstract COLOR_ATTACHMENT13: GLenum
    abstract COLOR_ATTACHMENT14: GLenum
    abstract COLOR_ATTACHMENT15: GLenum
    abstract COLOR_ATTACHMENT2: GLenum
    abstract COLOR_ATTACHMENT3: GLenum
    abstract COLOR_ATTACHMENT4: GLenum
    abstract COLOR_ATTACHMENT5: GLenum
    abstract COLOR_ATTACHMENT6: GLenum
    abstract COLOR_ATTACHMENT7: GLenum
    abstract COLOR_ATTACHMENT8: GLenum
    abstract COLOR_ATTACHMENT9: GLenum
    abstract COMPARE_REF_TO_TEXTURE: GLenum
    abstract CONDITION_SATISFIED: GLenum
    abstract COPY_READ_BUFFER: GLenum
    abstract COPY_READ_BUFFER_BINDING: GLenum
    abstract COPY_WRITE_BUFFER: GLenum
    abstract COPY_WRITE_BUFFER_BINDING: GLenum
    abstract CURRENT_QUERY: GLenum
    abstract DEPTH: GLenum
    abstract DEPTH24_STENCIL8: GLenum
    abstract DEPTH32F_STENCIL8: GLenum
    abstract DEPTH_COMPONENT24: GLenum
    abstract DEPTH_COMPONENT32F: GLenum
    abstract DRAW_BUFFER0: GLenum
    abstract DRAW_BUFFER1: GLenum
    abstract DRAW_BUFFER10: GLenum
    abstract DRAW_BUFFER11: GLenum
    abstract DRAW_BUFFER12: GLenum
    abstract DRAW_BUFFER13: GLenum
    abstract DRAW_BUFFER14: GLenum
    abstract DRAW_BUFFER15: GLenum
    abstract DRAW_BUFFER2: GLenum
    abstract DRAW_BUFFER3: GLenum
    abstract DRAW_BUFFER4: GLenum
    abstract DRAW_BUFFER5: GLenum
    abstract DRAW_BUFFER6: GLenum
    abstract DRAW_BUFFER7: GLenum
    abstract DRAW_BUFFER8: GLenum
    abstract DRAW_BUFFER9: GLenum
    abstract DRAW_FRAMEBUFFER: GLenum
    abstract DRAW_FRAMEBUFFER_BINDING: GLenum
    abstract DYNAMIC_COPY: GLenum
    abstract DYNAMIC_READ: GLenum
    abstract FLOAT_32_UNSIGNED_INT_24_8_REV: GLenum
    abstract FLOAT_MAT2x3: GLenum
    abstract FLOAT_MAT2x4: GLenum
    abstract FLOAT_MAT3x2: GLenum
    abstract FLOAT_MAT3x4: GLenum
    abstract FLOAT_MAT4x2: GLenum
    abstract FLOAT_MAT4x3: GLenum
    abstract FRAGMENT_SHADER_DERIVATIVE_HINT: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_BLUE_SIZE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_GREEN_SIZE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_RED_SIZE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER: GLenum
    abstract FRAMEBUFFER_DEFAULT: GLenum
    abstract FRAMEBUFFER_INCOMPLETE_MULTISAMPLE: GLenum
    abstract HALF_FLOAT: GLenum
    abstract INTERLEAVED_ATTRIBS: GLenum
    abstract INT_2_10_10_10_REV: GLenum
    abstract INT_SAMPLER_2D: GLenum
    abstract INT_SAMPLER_2D_ARRAY: GLenum
    abstract INT_SAMPLER_3D: GLenum
    abstract INT_SAMPLER_CUBE: GLenum
    abstract INVALID_INDEX: GLenum
    abstract MAX: GLenum
    abstract MAX_3D_TEXTURE_SIZE: GLenum
    abstract MAX_ARRAY_TEXTURE_LAYERS: GLenum
    abstract MAX_CLIENT_WAIT_TIMEOUT_WEBGL: GLenum
    abstract MAX_COLOR_ATTACHMENTS: GLenum
    abstract MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS: GLenum
    abstract MAX_COMBINED_UNIFORM_BLOCKS: GLenum
    abstract MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS: GLenum
    abstract MAX_DRAW_BUFFERS: GLenum
    abstract MAX_ELEMENTS_INDICES: GLenum
    abstract MAX_ELEMENTS_VERTICES: GLenum
    abstract MAX_ELEMENT_INDEX: GLenum
    abstract MAX_FRAGMENT_INPUT_COMPONENTS: GLenum
    abstract MAX_FRAGMENT_UNIFORM_BLOCKS: GLenum
    abstract MAX_FRAGMENT_UNIFORM_COMPONENTS: GLenum
    abstract MAX_PROGRAM_TEXEL_OFFSET: GLenum
    abstract MAX_SAMPLES: GLenum
    abstract MAX_SERVER_WAIT_TIMEOUT: GLenum
    abstract MAX_TEXTURE_LOD_BIAS: GLenum
    abstract MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS: GLenum
    abstract MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS: GLenum
    abstract MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS: GLenum
    abstract MAX_UNIFORM_BLOCK_SIZE: GLenum
    abstract MAX_UNIFORM_BUFFER_BINDINGS: GLenum
    abstract MAX_VARYING_COMPONENTS: GLenum
    abstract MAX_VERTEX_OUTPUT_COMPONENTS: GLenum
    abstract MAX_VERTEX_UNIFORM_BLOCKS: GLenum
    abstract MAX_VERTEX_UNIFORM_COMPONENTS: GLenum
    abstract MIN: GLenum
    abstract MIN_PROGRAM_TEXEL_OFFSET: GLenum
    abstract OBJECT_TYPE: GLenum
    abstract PACK_ROW_LENGTH: GLenum
    abstract PACK_SKIP_PIXELS: GLenum
    abstract PACK_SKIP_ROWS: GLenum
    abstract PIXEL_PACK_BUFFER: GLenum
    abstract PIXEL_PACK_BUFFER_BINDING: GLenum
    abstract PIXEL_UNPACK_BUFFER: GLenum
    abstract PIXEL_UNPACK_BUFFER_BINDING: GLenum
    abstract QUERY_RESULT: GLenum
    abstract QUERY_RESULT_AVAILABLE: GLenum
    abstract R11F_G11F_B10F: GLenum
    abstract R16F: GLenum
    abstract R16I: GLenum
    abstract R16UI: GLenum
    abstract R32F: GLenum
    abstract R32I: GLenum
    abstract R32UI: GLenum
    abstract R8: GLenum
    abstract R8I: GLenum
    abstract R8UI: GLenum
    abstract R8_SNORM: GLenum
    abstract RASTERIZER_DISCARD: GLenum
    abstract READ_BUFFER: GLenum
    abstract READ_FRAMEBUFFER: GLenum
    abstract READ_FRAMEBUFFER_BINDING: GLenum
    abstract RED: GLenum
    abstract RED_INTEGER: GLenum
    abstract RENDERBUFFER_SAMPLES: GLenum
    abstract RG: GLenum
    abstract RG16F: GLenum
    abstract RG16I: GLenum
    abstract RG16UI: GLenum
    abstract RG32F: GLenum
    abstract RG32I: GLenum
    abstract RG32UI: GLenum
    abstract RG8: GLenum
    abstract RG8I: GLenum
    abstract RG8UI: GLenum
    abstract RG8_SNORM: GLenum
    abstract RGB10_A2: GLenum
    abstract RGB10_A2UI: GLenum
    abstract RGB16F: GLenum
    abstract RGB16I: GLenum
    abstract RGB16UI: GLenum
    abstract RGB32F: GLenum
    abstract RGB32I: GLenum
    abstract RGB32UI: GLenum
    abstract RGB8: GLenum
    abstract RGB8I: GLenum
    abstract RGB8UI: GLenum
    abstract RGB8_SNORM: GLenum
    abstract RGB9_E5: GLenum
    abstract RGBA16F: GLenum
    abstract RGBA16I: GLenum
    abstract RGBA16UI: GLenum
    abstract RGBA32F: GLenum
    abstract RGBA32I: GLenum
    abstract RGBA32UI: GLenum
    abstract RGBA8: GLenum
    abstract RGBA8I: GLenum
    abstract RGBA8UI: GLenum
    abstract RGBA8_SNORM: GLenum
    abstract RGBA_INTEGER: GLenum
    abstract RGB_INTEGER: GLenum
    abstract RG_INTEGER: GLenum
    abstract SAMPLER_2D_ARRAY: GLenum
    abstract SAMPLER_2D_ARRAY_SHADOW: GLenum
    abstract SAMPLER_2D_SHADOW: GLenum
    abstract SAMPLER_3D: GLenum
    abstract SAMPLER_BINDING: GLenum
    abstract SAMPLER_CUBE_SHADOW: GLenum
    abstract SEPARATE_ATTRIBS: GLenum
    abstract SIGNALED: GLenum
    abstract SIGNED_NORMALIZED: GLenum
    abstract SRGB: GLenum
    abstract SRGB8: GLenum
    abstract SRGB8_ALPHA8: GLenum
    abstract STATIC_COPY: GLenum
    abstract STATIC_READ: GLenum
    abstract STENCIL: GLenum
    abstract STREAM_COPY: GLenum
    abstract STREAM_READ: GLenum
    abstract SYNC_CONDITION: GLenum
    abstract SYNC_FENCE: GLenum
    abstract SYNC_FLAGS: GLenum
    abstract SYNC_FLUSH_COMMANDS_BIT: GLenum
    abstract SYNC_GPU_COMMANDS_COMPLETE: GLenum
    abstract SYNC_STATUS: GLenum
    abstract TEXTURE_2D_ARRAY: GLenum
    abstract TEXTURE_3D: GLenum
    abstract TEXTURE_BASE_LEVEL: GLenum
    abstract TEXTURE_BINDING_2D_ARRAY: GLenum
    abstract TEXTURE_BINDING_3D: GLenum
    abstract TEXTURE_COMPARE_FUNC: GLenum
    abstract TEXTURE_COMPARE_MODE: GLenum
    abstract TEXTURE_IMMUTABLE_FORMAT: GLenum
    abstract TEXTURE_IMMUTABLE_LEVELS: GLenum
    abstract TEXTURE_MAX_LEVEL: GLenum
    abstract TEXTURE_MAX_LOD: GLenum
    abstract TEXTURE_MIN_LOD: GLenum
    abstract TEXTURE_WRAP_R: GLenum
    abstract TIMEOUT_EXPIRED: GLenum
    abstract TIMEOUT_IGNORED: GLint64
    abstract TRANSFORM_FEEDBACK: GLenum
    abstract TRANSFORM_FEEDBACK_ACTIVE: GLenum
    abstract TRANSFORM_FEEDBACK_BINDING: GLenum
    abstract TRANSFORM_FEEDBACK_BUFFER: GLenum
    abstract TRANSFORM_FEEDBACK_BUFFER_BINDING: GLenum
    abstract TRANSFORM_FEEDBACK_BUFFER_MODE: GLenum
    abstract TRANSFORM_FEEDBACK_BUFFER_SIZE: GLenum
    abstract TRANSFORM_FEEDBACK_BUFFER_START: GLenum
    abstract TRANSFORM_FEEDBACK_PAUSED: GLenum
    abstract TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN: GLenum
    abstract TRANSFORM_FEEDBACK_VARYINGS: GLenum
    abstract UNIFORM_ARRAY_STRIDE: GLenum
    abstract UNIFORM_BLOCK_ACTIVE_UNIFORMS: GLenum
    abstract UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES: GLenum
    abstract UNIFORM_BLOCK_BINDING: GLenum
    abstract UNIFORM_BLOCK_DATA_SIZE: GLenum
    abstract UNIFORM_BLOCK_INDEX: GLenum
    abstract UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER: GLenum
    abstract UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER: GLenum
    abstract UNIFORM_BUFFER: GLenum
    abstract UNIFORM_BUFFER_BINDING: GLenum
    abstract UNIFORM_BUFFER_OFFSET_ALIGNMENT: GLenum
    abstract UNIFORM_BUFFER_SIZE: GLenum
    abstract UNIFORM_BUFFER_START: GLenum
    abstract UNIFORM_IS_ROW_MAJOR: GLenum
    abstract UNIFORM_MATRIX_STRIDE: GLenum
    abstract UNIFORM_OFFSET: GLenum
    abstract UNIFORM_SIZE: GLenum
    abstract UNIFORM_TYPE: GLenum
    abstract UNPACK_IMAGE_HEIGHT: GLenum
    abstract UNPACK_ROW_LENGTH: GLenum
    abstract UNPACK_SKIP_IMAGES: GLenum
    abstract UNPACK_SKIP_PIXELS: GLenum
    abstract UNPACK_SKIP_ROWS: GLenum
    abstract UNSIGNALED: GLenum
    abstract UNSIGNED_INT_10F_11F_11F_REV: GLenum
    abstract UNSIGNED_INT_24_8: GLenum
    abstract UNSIGNED_INT_2_10_10_10_REV: GLenum
    abstract UNSIGNED_INT_5_9_9_9_REV: GLenum
    abstract UNSIGNED_INT_SAMPLER_2D: GLenum
    abstract UNSIGNED_INT_SAMPLER_2D_ARRAY: GLenum
    abstract UNSIGNED_INT_SAMPLER_3D: GLenum
    abstract UNSIGNED_INT_SAMPLER_CUBE: GLenum
    abstract UNSIGNED_INT_VEC2: GLenum
    abstract UNSIGNED_INT_VEC3: GLenum
    abstract UNSIGNED_INT_VEC4: GLenum
    abstract UNSIGNED_NORMALIZED: GLenum
    abstract VERTEX_ARRAY_BINDING: GLenum
    abstract VERTEX_ATTRIB_ARRAY_DIVISOR: GLenum
    abstract VERTEX_ATTRIB_ARRAY_INTEGER: GLenum
    abstract WAIT_FAILED: GLenum

type [<AllowNullLiteral>] WebGL2RenderingContextOverloads =
    abstract bufferData: target: GLenum * size: GLsizeiptr * usage: GLenum -> unit
    abstract bufferData: target: GLenum * srcData: BufferSource option * usage: GLenum -> unit
    abstract bufferData: target: GLenum * srcData: ArrayBufferView * usage: GLenum * srcOffset: GLuint * ?length: GLuint -> unit
    abstract bufferSubData: target: GLenum * dstByteOffset: GLintptr * srcData: BufferSource -> unit
    abstract bufferSubData: target: GLenum * dstByteOffset: GLintptr * srcData: ArrayBufferView * srcOffset: GLuint * ?length: GLuint -> unit
    abstract compressedTexImage2D: target: GLenum * level: GLint * internalformat: GLenum * width: GLsizei * height: GLsizei * border: GLint * imageSize: GLsizei * offset: GLintptr -> unit
    abstract compressedTexImage2D: target: GLenum * level: GLint * internalformat: GLenum * width: GLsizei * height: GLsizei * border: GLint * srcData: ArrayBufferView * ?srcOffset: GLuint * ?srcLengthOverride: GLuint -> unit
    abstract compressedTexSubImage2D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * width: GLsizei * height: GLsizei * format: GLenum * imageSize: GLsizei * offset: GLintptr -> unit
    abstract compressedTexSubImage2D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * width: GLsizei * height: GLsizei * format: GLenum * srcData: ArrayBufferView * ?srcOffset: GLuint * ?srcLengthOverride: GLuint -> unit
    abstract readPixels: x: GLint * y: GLint * width: GLsizei * height: GLsizei * format: GLenum * ``type``: GLenum * dstData: ArrayBufferView option -> unit
    abstract readPixels: x: GLint * y: GLint * width: GLsizei * height: GLsizei * format: GLenum * ``type``: GLenum * offset: GLintptr -> unit
    abstract readPixels: x: GLint * y: GLint * width: GLsizei * height: GLsizei * format: GLenum * ``type``: GLenum * dstData: ArrayBufferView * dstOffset: GLuint -> unit
    abstract texImage2D: target: GLenum * level: GLint * internalformat: GLint * width: GLsizei * height: GLsizei * border: GLint * format: GLenum * ``type``: GLenum * pixels: ArrayBufferView option -> unit
    abstract texImage2D: target: GLenum * level: GLint * internalformat: GLint * format: GLenum * ``type``: GLenum * source: TexImageSource -> unit
    abstract texImage2D: target: GLenum * level: GLint * internalformat: GLint * width: GLsizei * height: GLsizei * border: GLint * format: GLenum * ``type``: GLenum * pboOffset: GLintptr -> unit
    abstract texImage2D: target: GLenum * level: GLint * internalformat: GLint * width: GLsizei * height: GLsizei * border: GLint * format: GLenum * ``type``: GLenum * source: TexImageSource -> unit
    abstract texImage2D: target: GLenum * level: GLint * internalformat: GLint * width: GLsizei * height: GLsizei * border: GLint * format: GLenum * ``type``: GLenum * srcData: ArrayBufferView * srcOffset: GLuint -> unit
    abstract texSubImage2D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * width: GLsizei * height: GLsizei * format: GLenum * ``type``: GLenum * pixels: ArrayBufferView option -> unit
    abstract texSubImage2D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * format: GLenum * ``type``: GLenum * source: TexImageSource -> unit
    abstract texSubImage2D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * width: GLsizei * height: GLsizei * format: GLenum * ``type``: GLenum * pboOffset: GLintptr -> unit
    abstract texSubImage2D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * width: GLsizei * height: GLsizei * format: GLenum * ``type``: GLenum * source: TexImageSource -> unit
    abstract texSubImage2D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * width: GLsizei * height: GLsizei * format: GLenum * ``type``: GLenum * srcData: ArrayBufferView * srcOffset: GLuint -> unit
    abstract uniform1fv: location: WebGLUniformLocation option * data: Float32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniform1iv: location: WebGLUniformLocation option * data: Int32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniform2fv: location: WebGLUniformLocation option * data: Float32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniform2iv: location: WebGLUniformLocation option * data: Int32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniform3fv: location: WebGLUniformLocation option * data: Float32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniform3iv: location: WebGLUniformLocation option * data: Int32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniform4fv: location: WebGLUniformLocation option * data: Float32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniform4iv: location: WebGLUniformLocation option * data: Int32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniformMatrix2fv: location: WebGLUniformLocation option * transpose: GLboolean * data: Float32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniformMatrix3fv: location: WebGLUniformLocation option * transpose: GLboolean * data: Float32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit
    abstract uniformMatrix4fv: location: WebGLUniformLocation option * transpose: GLboolean * data: Float32List * ?srcOffset: GLuint * ?srcLength: GLuint -> unit

/// Part of the WebGL API and represents the information returned by calling the WebGLRenderingContext.getActiveAttrib() and WebGLRenderingContext.getActiveUniform() methods.
type [<AllowNullLiteral>] WebGLActiveInfo =
    abstract name: string
    abstract size: GLint
    abstract ``type``: GLenum

/// Part of the WebGL API and represents an opaque buffer object storing data such as vertices or colors.
type [<AllowNullLiteral>] WebGLBuffer =
    interface end

/// The WebContextEvent interface is part of the WebGL API and is an interface for an event that is generated in response to a status change to the WebGL rendering context.
type [<AllowNullLiteral>] WebGLContextEvent =
    inherit Event
    abstract statusMessage: string

/// Part of the WebGL API and represents a collection of buffers that serve as a rendering destination.
type [<AllowNullLiteral>] WebGLFramebuffer =
    interface end

/// The WebGLProgram is part of the WebGL API and is a combination of two compiled WebGLShaders consisting of a vertex shader and a fragment shader (both written in GLSL).
type [<AllowNullLiteral>] WebGLProgram =
    interface end

type [<AllowNullLiteral>] WebGLQuery =
    interface end

/// Part of the WebGL API and represents a buffer that can contain an image, or can be source or target of an rendering operation.
type [<AllowNullLiteral>] WebGLRenderbuffer =
    interface end

/// Provides an interface to the OpenGL ES 2.0 graphics rendering context for the drawing surface of an HTML <canvas> element.
type [<AllowNullLiteral>] WebGLRenderingContext =
    inherit WebGLRenderingContextBase
    inherit WebGLRenderingContextOverloads

type [<AllowNullLiteral>] WebGLRenderingContextBase =
    abstract canvas: U2<HTMLCanvasElement, OffscreenCanvas>
    abstract drawingBufferHeight: GLsizei
    abstract drawingBufferWidth: GLsizei
    abstract activeTexture: texture: GLenum -> unit
    abstract attachShader: program: WebGLProgram * shader: WebGLShader -> unit
    abstract bindAttribLocation: program: WebGLProgram * index: GLuint * name: string -> unit
    abstract bindBuffer: target: GLenum * buffer: WebGLBuffer option -> unit
    abstract bindFramebuffer: target: GLenum * framebuffer: WebGLFramebuffer option -> unit
    abstract bindRenderbuffer: target: GLenum * renderbuffer: WebGLRenderbuffer option -> unit
    abstract bindTexture: target: GLenum * texture: WebGLTexture option -> unit
    abstract blendColor: red: GLclampf * green: GLclampf * blue: GLclampf * alpha: GLclampf -> unit
    abstract blendEquation: mode: GLenum -> unit
    abstract blendEquationSeparate: modeRGB: GLenum * modeAlpha: GLenum -> unit
    abstract blendFunc: sfactor: GLenum * dfactor: GLenum -> unit
    abstract blendFuncSeparate: srcRGB: GLenum * dstRGB: GLenum * srcAlpha: GLenum * dstAlpha: GLenum -> unit
    abstract checkFramebufferStatus: target: GLenum -> GLenum
    abstract clear: mask: GLbitfield -> unit
    abstract clearColor: red: GLclampf * green: GLclampf * blue: GLclampf * alpha: GLclampf -> unit
    abstract clearDepth: depth: GLclampf -> unit
    abstract clearStencil: s: GLint -> unit
    abstract colorMask: red: GLboolean * green: GLboolean * blue: GLboolean * alpha: GLboolean -> unit
    abstract compileShader: shader: WebGLShader -> unit
    abstract copyTexImage2D: target: GLenum * level: GLint * internalformat: GLenum * x: GLint * y: GLint * width: GLsizei * height: GLsizei * border: GLint -> unit
    abstract copyTexSubImage2D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * x: GLint * y: GLint * width: GLsizei * height: GLsizei -> unit
    abstract createBuffer: unit -> WebGLBuffer option
    abstract createFramebuffer: unit -> WebGLFramebuffer option
    abstract createProgram: unit -> WebGLProgram option
    abstract createRenderbuffer: unit -> WebGLRenderbuffer option
    abstract createShader: ``type``: GLenum -> WebGLShader option
    abstract createTexture: unit -> WebGLTexture option
    abstract cullFace: mode: GLenum -> unit
    abstract deleteBuffer: buffer: WebGLBuffer option -> unit
    abstract deleteFramebuffer: framebuffer: WebGLFramebuffer option -> unit
    abstract deleteProgram: program: WebGLProgram option -> unit
    abstract deleteRenderbuffer: renderbuffer: WebGLRenderbuffer option -> unit
    abstract deleteShader: shader: WebGLShader option -> unit
    abstract deleteTexture: texture: WebGLTexture option -> unit
    abstract depthFunc: func: GLenum -> unit
    abstract depthMask: flag: GLboolean -> unit
    abstract depthRange: zNear: GLclampf * zFar: GLclampf -> unit
    abstract detachShader: program: WebGLProgram * shader: WebGLShader -> unit
    abstract disable: cap: GLenum -> unit
    abstract disableVertexAttribArray: index: GLuint -> unit
    abstract drawArrays: mode: GLenum * first: GLint * count: GLsizei -> unit
    abstract drawElements: mode: GLenum * count: GLsizei * ``type``: GLenum * offset: GLintptr -> unit
    abstract enable: cap: GLenum -> unit
    abstract enableVertexAttribArray: index: GLuint -> unit
    abstract finish: unit -> unit
    abstract flush: unit -> unit
    abstract framebufferRenderbuffer: target: GLenum * attachment: GLenum * renderbuffertarget: GLenum * renderbuffer: WebGLRenderbuffer option -> unit
    abstract framebufferTexture2D: target: GLenum * attachment: GLenum * textarget: GLenum * texture: WebGLTexture option * level: GLint -> unit
    abstract frontFace: mode: GLenum -> unit
    abstract generateMipmap: target: GLenum -> unit
    abstract getActiveAttrib: program: WebGLProgram * index: GLuint -> WebGLActiveInfo option
    abstract getActiveUniform: program: WebGLProgram * index: GLuint -> WebGLActiveInfo option
    abstract getAttachedShaders: program: WebGLProgram -> ResizeArray<WebGLShader> option
    abstract getAttribLocation: program: WebGLProgram * name: string -> GLint
    abstract getBufferParameter: target: GLenum * pname: GLenum -> obj option
    abstract getContextAttributes: unit -> WebGLContextAttributes option
    abstract getError: unit -> GLenum
    [<Emit "$0.getExtension('ANGLE_instanced_arrays')">] abstract getExtension_ANGLE_instanced_arrays: unit -> ANGLE_instanced_arrays option
    [<Emit "$0.getExtension('EXT_blend_minmax')">] abstract getExtension_EXT_blend_minmax: unit -> EXT_blend_minmax option
    [<Emit "$0.getExtension('EXT_color_buffer_float')">] abstract getExtension_EXT_color_buffer_float: unit -> EXT_color_buffer_float option
    [<Emit "$0.getExtension('EXT_color_buffer_half_float')">] abstract getExtension_EXT_color_buffer_half_float: unit -> EXT_color_buffer_half_float option
    [<Emit "$0.getExtension('EXT_float_blend')">] abstract getExtension_EXT_float_blend: unit -> EXT_float_blend option
    [<Emit "$0.getExtension('EXT_frag_depth')">] abstract getExtension_EXT_frag_depth: unit -> EXT_frag_depth option
    [<Emit "$0.getExtension('EXT_sRGB')">] abstract getExtension_EXT_sRGB: unit -> EXT_sRGB option
    [<Emit "$0.getExtension('EXT_shader_texture_lod')">] abstract getExtension_EXT_shader_texture_lod: unit -> EXT_shader_texture_lod option
    [<Emit "$0.getExtension('EXT_texture_compression_bptc')">] abstract getExtension_EXT_texture_compression_bptc: unit -> EXT_texture_compression_bptc option
    [<Emit "$0.getExtension('EXT_texture_compression_rgtc')">] abstract getExtension_EXT_texture_compression_rgtc: unit -> EXT_texture_compression_rgtc option
    [<Emit "$0.getExtension('EXT_texture_filter_anisotropic')">] abstract getExtension_EXT_texture_filter_anisotropic: unit -> EXT_texture_filter_anisotropic option
    [<Emit "$0.getExtension('KHR_parallel_shader_compile')">] abstract getExtension_KHR_parallel_shader_compile: unit -> KHR_parallel_shader_compile option
    [<Emit "$0.getExtension('OES_element_index_uint')">] abstract getExtension_OES_element_index_uint: unit -> OES_element_index_uint option
    [<Emit "$0.getExtension('OES_fbo_render_mipmap')">] abstract getExtension_OES_fbo_render_mipmap: unit -> OES_fbo_render_mipmap option
    [<Emit "$0.getExtension('OES_standard_derivatives')">] abstract getExtension_OES_standard_derivatives: unit -> OES_standard_derivatives option
    [<Emit "$0.getExtension('OES_texture_float')">] abstract getExtension_OES_texture_float: unit -> OES_texture_float option
    [<Emit "$0.getExtension('OES_texture_float_linear')">] abstract getExtension_OES_texture_float_linear: unit -> OES_texture_float_linear option
    [<Emit "$0.getExtension('OES_texture_half_float')">] abstract getExtension_OES_texture_half_float: unit -> OES_texture_half_float option
    [<Emit "$0.getExtension('OES_texture_half_float_linear')">] abstract getExtension_OES_texture_half_float_linear: unit -> OES_texture_half_float_linear option
    [<Emit "$0.getExtension('OES_vertex_array_object')">] abstract getExtension_OES_vertex_array_object: unit -> OES_vertex_array_object option
    [<Emit "$0.getExtension('OVR_multiview2')">] abstract getExtension_OVR_multiview2: unit -> OVR_multiview2 option
    [<Emit "$0.getExtension('WEBGL_color_buffer_float')">] abstract getExtension_WEBGL_color_buffer_float: unit -> WEBGL_color_buffer_float option
    [<Emit "$0.getExtension('WEBGL_compressed_texture_astc')">] abstract getExtension_WEBGL_compressed_texture_astc: unit -> WEBGL_compressed_texture_astc option
    [<Emit "$0.getExtension('WEBGL_compressed_texture_etc')">] abstract getExtension_WEBGL_compressed_texture_etc: unit -> WEBGL_compressed_texture_etc option
    [<Emit "$0.getExtension('WEBGL_compressed_texture_etc1')">] abstract getExtension_WEBGL_compressed_texture_etc1: unit -> WEBGL_compressed_texture_etc1 option
    [<Emit "$0.getExtension('WEBGL_compressed_texture_s3tc')">] abstract getExtension_WEBGL_compressed_texture_s3tc: unit -> WEBGL_compressed_texture_s3tc option
    [<Emit "$0.getExtension('WEBGL_compressed_texture_s3tc_srgb')">] abstract getExtension_WEBGL_compressed_texture_s3tc_srgb: unit -> WEBGL_compressed_texture_s3tc_srgb option
    [<Emit "$0.getExtension('WEBGL_debug_renderer_info')">] abstract getExtension_WEBGL_debug_renderer_info: unit -> WEBGL_debug_renderer_info option
    [<Emit "$0.getExtension('WEBGL_debug_shaders')">] abstract getExtension_WEBGL_debug_shaders: unit -> WEBGL_debug_shaders option
    [<Emit "$0.getExtension('WEBGL_depth_texture')">] abstract getExtension_WEBGL_depth_texture: unit -> WEBGL_depth_texture option
    [<Emit "$0.getExtension('WEBGL_draw_buffers')">] abstract getExtension_WEBGL_draw_buffers: unit -> WEBGL_draw_buffers option
    [<Emit "$0.getExtension('WEBGL_lose_context')">] abstract getExtension_WEBGL_lose_context: unit -> WEBGL_lose_context option
    [<Emit "$0.getExtension('WEBGL_multi_draw')">] abstract getExtension_WEBGL_multi_draw: unit -> WEBGL_multi_draw option
    abstract getExtension: name: string -> obj option
    abstract getFramebufferAttachmentParameter: target: GLenum * attachment: GLenum * pname: GLenum -> obj option
    abstract getParameter: pname: GLenum -> obj option
    abstract getProgramInfoLog: program: WebGLProgram -> string option
    abstract getProgramParameter: program: WebGLProgram * pname: GLenum -> obj option
    abstract getRenderbufferParameter: target: GLenum * pname: GLenum -> obj option
    abstract getShaderInfoLog: shader: WebGLShader -> string option
    abstract getShaderParameter: shader: WebGLShader * pname: GLenum -> obj option
    abstract getShaderPrecisionFormat: shadertype: GLenum * precisiontype: GLenum -> WebGLShaderPrecisionFormat option
    abstract getShaderSource: shader: WebGLShader -> string option
    abstract getSupportedExtensions: unit -> ResizeArray<string> option
    abstract getTexParameter: target: GLenum * pname: GLenum -> obj option
    abstract getUniform: program: WebGLProgram * location: WebGLUniformLocation -> obj option
    abstract getUniformLocation: program: WebGLProgram * name: string -> WebGLUniformLocation option
    abstract getVertexAttrib: index: GLuint * pname: GLenum -> obj option
    abstract getVertexAttribOffset: index: GLuint * pname: GLenum -> GLintptr
    abstract hint: target: GLenum * mode: GLenum -> unit
    abstract isBuffer: buffer: WebGLBuffer option -> GLboolean
    abstract isContextLost: unit -> bool
    abstract isEnabled: cap: GLenum -> GLboolean
    abstract isFramebuffer: framebuffer: WebGLFramebuffer option -> GLboolean
    abstract isProgram: program: WebGLProgram option -> GLboolean
    abstract isRenderbuffer: renderbuffer: WebGLRenderbuffer option -> GLboolean
    abstract isShader: shader: WebGLShader option -> GLboolean
    abstract isTexture: texture: WebGLTexture option -> GLboolean
    abstract lineWidth: width: GLfloat -> unit
    abstract linkProgram: program: WebGLProgram -> unit
    abstract pixelStorei: pname: GLenum * param: U2<GLint, GLboolean> -> unit
    abstract polygonOffset: factor: GLfloat * units: GLfloat -> unit
    abstract renderbufferStorage: target: GLenum * internalformat: GLenum * width: GLsizei * height: GLsizei -> unit
    abstract sampleCoverage: value: GLclampf * invert: GLboolean -> unit
    abstract scissor: x: GLint * y: GLint * width: GLsizei * height: GLsizei -> unit
    abstract shaderSource: shader: WebGLShader * source: string -> unit
    abstract stencilFunc: func: GLenum * ref: GLint * mask: GLuint -> unit
    abstract stencilFuncSeparate: face: GLenum * func: GLenum * ref: GLint * mask: GLuint -> unit
    abstract stencilMask: mask: GLuint -> unit
    abstract stencilMaskSeparate: face: GLenum * mask: GLuint -> unit
    abstract stencilOp: fail: GLenum * zfail: GLenum * zpass: GLenum -> unit
    abstract stencilOpSeparate: face: GLenum * fail: GLenum * zfail: GLenum * zpass: GLenum -> unit
    abstract texParameterf: target: GLenum * pname: GLenum * param: GLfloat -> unit
    abstract texParameteri: target: GLenum * pname: GLenum * param: GLint -> unit
    abstract uniform1f: location: WebGLUniformLocation option * x: GLfloat -> unit
    abstract uniform1i: location: WebGLUniformLocation option * x: GLint -> unit
    abstract uniform2f: location: WebGLUniformLocation option * x: GLfloat * y: GLfloat -> unit
    abstract uniform2i: location: WebGLUniformLocation option * x: GLint * y: GLint -> unit
    abstract uniform3f: location: WebGLUniformLocation option * x: GLfloat * y: GLfloat * z: GLfloat -> unit
    abstract uniform3i: location: WebGLUniformLocation option * x: GLint * y: GLint * z: GLint -> unit
    abstract uniform4f: location: WebGLUniformLocation option * x: GLfloat * y: GLfloat * z: GLfloat * w: GLfloat -> unit
    abstract uniform4i: location: WebGLUniformLocation option * x: GLint * y: GLint * z: GLint * w: GLint -> unit
    abstract useProgram: program: WebGLProgram option -> unit
    abstract validateProgram: program: WebGLProgram -> unit
    abstract vertexAttrib1f: index: GLuint * x: GLfloat -> unit
    abstract vertexAttrib1fv: index: GLuint * values: Float32List -> unit
    abstract vertexAttrib2f: index: GLuint * x: GLfloat * y: GLfloat -> unit
    abstract vertexAttrib2fv: index: GLuint * values: Float32List -> unit
    abstract vertexAttrib3f: index: GLuint * x: GLfloat * y: GLfloat * z: GLfloat -> unit
    abstract vertexAttrib3fv: index: GLuint * values: Float32List -> unit
    abstract vertexAttrib4f: index: GLuint * x: GLfloat * y: GLfloat * z: GLfloat * w: GLfloat -> unit
    abstract vertexAttrib4fv: index: GLuint * values: Float32List -> unit
    abstract vertexAttribPointer: index: GLuint * size: GLint * ``type``: GLenum * normalized: GLboolean * stride: GLsizei * offset: GLintptr -> unit
    abstract viewport: x: GLint * y: GLint * width: GLsizei * height: GLsizei -> unit
    abstract ACTIVE_ATTRIBUTES: GLenum
    abstract ACTIVE_TEXTURE: GLenum
    abstract ACTIVE_UNIFORMS: GLenum
    abstract ALIASED_LINE_WIDTH_RANGE: GLenum
    abstract ALIASED_POINT_SIZE_RANGE: GLenum
    abstract ALPHA: GLenum
    abstract ALPHA_BITS: GLenum
    abstract ALWAYS: GLenum
    abstract ARRAY_BUFFER: GLenum
    abstract ARRAY_BUFFER_BINDING: GLenum
    abstract ATTACHED_SHADERS: GLenum
    abstract BACK: GLenum
    abstract BLEND: GLenum
    abstract BLEND_COLOR: GLenum
    abstract BLEND_DST_ALPHA: GLenum
    abstract BLEND_DST_RGB: GLenum
    abstract BLEND_EQUATION: GLenum
    abstract BLEND_EQUATION_ALPHA: GLenum
    abstract BLEND_EQUATION_RGB: GLenum
    abstract BLEND_SRC_ALPHA: GLenum
    abstract BLEND_SRC_RGB: GLenum
    abstract BLUE_BITS: GLenum
    abstract BOOL: GLenum
    abstract BOOL_VEC2: GLenum
    abstract BOOL_VEC3: GLenum
    abstract BOOL_VEC4: GLenum
    abstract BROWSER_DEFAULT_WEBGL: GLenum
    abstract BUFFER_SIZE: GLenum
    abstract BUFFER_USAGE: GLenum
    abstract BYTE: GLenum
    abstract CCW: GLenum
    abstract CLAMP_TO_EDGE: GLenum
    abstract COLOR_ATTACHMENT0: GLenum
    abstract COLOR_BUFFER_BIT: GLenum
    abstract COLOR_CLEAR_VALUE: GLenum
    abstract COLOR_WRITEMASK: GLenum
    abstract COMPILE_STATUS: GLenum
    abstract COMPRESSED_TEXTURE_FORMATS: GLenum
    abstract CONSTANT_ALPHA: GLenum
    abstract CONSTANT_COLOR: GLenum
    abstract CONTEXT_LOST_WEBGL: GLenum
    abstract CULL_FACE: GLenum
    abstract CULL_FACE_MODE: GLenum
    abstract CURRENT_PROGRAM: GLenum
    abstract CURRENT_VERTEX_ATTRIB: GLenum
    abstract CW: GLenum
    abstract DECR: GLenum
    abstract DECR_WRAP: GLenum
    abstract DELETE_STATUS: GLenum
    abstract DEPTH_ATTACHMENT: GLenum
    abstract DEPTH_BITS: GLenum
    abstract DEPTH_BUFFER_BIT: GLenum
    abstract DEPTH_CLEAR_VALUE: GLenum
    abstract DEPTH_COMPONENT: GLenum
    abstract DEPTH_COMPONENT16: GLenum
    abstract DEPTH_FUNC: GLenum
    abstract DEPTH_RANGE: GLenum
    abstract DEPTH_STENCIL: GLenum
    abstract DEPTH_STENCIL_ATTACHMENT: GLenum
    abstract DEPTH_TEST: GLenum
    abstract DEPTH_WRITEMASK: GLenum
    abstract DITHER: GLenum
    abstract DONT_CARE: GLenum
    abstract DST_ALPHA: GLenum
    abstract DST_COLOR: GLenum
    abstract DYNAMIC_DRAW: GLenum
    abstract ELEMENT_ARRAY_BUFFER: GLenum
    abstract ELEMENT_ARRAY_BUFFER_BINDING: GLenum
    abstract EQUAL: GLenum
    abstract FASTEST: GLenum
    abstract FLOAT: GLenum
    abstract FLOAT_MAT2: GLenum
    abstract FLOAT_MAT3: GLenum
    abstract FLOAT_MAT4: GLenum
    abstract FLOAT_VEC2: GLenum
    abstract FLOAT_VEC3: GLenum
    abstract FLOAT_VEC4: GLenum
    abstract FRAGMENT_SHADER: GLenum
    abstract FRAMEBUFFER: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_OBJECT_NAME: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL: GLenum
    abstract FRAMEBUFFER_BINDING: GLenum
    abstract FRAMEBUFFER_COMPLETE: GLenum
    abstract FRAMEBUFFER_INCOMPLETE_ATTACHMENT: GLenum
    abstract FRAMEBUFFER_INCOMPLETE_DIMENSIONS: GLenum
    abstract FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT: GLenum
    abstract FRAMEBUFFER_UNSUPPORTED: GLenum
    abstract FRONT: GLenum
    abstract FRONT_AND_BACK: GLenum
    abstract FRONT_FACE: GLenum
    abstract FUNC_ADD: GLenum
    abstract FUNC_REVERSE_SUBTRACT: GLenum
    abstract FUNC_SUBTRACT: GLenum
    abstract GENERATE_MIPMAP_HINT: GLenum
    abstract GEQUAL: GLenum
    abstract GREATER: GLenum
    abstract GREEN_BITS: GLenum
    abstract HIGH_FLOAT: GLenum
    abstract HIGH_INT: GLenum
    abstract IMPLEMENTATION_COLOR_READ_FORMAT: GLenum
    abstract IMPLEMENTATION_COLOR_READ_TYPE: GLenum
    abstract INCR: GLenum
    abstract INCR_WRAP: GLenum
    abstract INT: GLenum
    abstract INT_VEC2: GLenum
    abstract INT_VEC3: GLenum
    abstract INT_VEC4: GLenum
    abstract INVALID_ENUM: GLenum
    abstract INVALID_FRAMEBUFFER_OPERATION: GLenum
    abstract INVALID_OPERATION: GLenum
    abstract INVALID_VALUE: GLenum
    abstract INVERT: GLenum
    abstract KEEP: GLenum
    abstract LEQUAL: GLenum
    abstract LESS: GLenum
    abstract LINEAR: GLenum
    abstract LINEAR_MIPMAP_LINEAR: GLenum
    abstract LINEAR_MIPMAP_NEAREST: GLenum
    abstract LINES: GLenum
    abstract LINE_LOOP: GLenum
    abstract LINE_STRIP: GLenum
    abstract LINE_WIDTH: GLenum
    abstract LINK_STATUS: GLenum
    abstract LOW_FLOAT: GLenum
    abstract LOW_INT: GLenum
    abstract LUMINANCE: GLenum
    abstract LUMINANCE_ALPHA: GLenum
    abstract MAX_COMBINED_TEXTURE_IMAGE_UNITS: GLenum
    abstract MAX_CUBE_MAP_TEXTURE_SIZE: GLenum
    abstract MAX_FRAGMENT_UNIFORM_VECTORS: GLenum
    abstract MAX_RENDERBUFFER_SIZE: GLenum
    abstract MAX_TEXTURE_IMAGE_UNITS: GLenum
    abstract MAX_TEXTURE_SIZE: GLenum
    abstract MAX_VARYING_VECTORS: GLenum
    abstract MAX_VERTEX_ATTRIBS: GLenum
    abstract MAX_VERTEX_TEXTURE_IMAGE_UNITS: GLenum
    abstract MAX_VERTEX_UNIFORM_VECTORS: GLenum
    abstract MAX_VIEWPORT_DIMS: GLenum
    abstract MEDIUM_FLOAT: GLenum
    abstract MEDIUM_INT: GLenum
    abstract MIRRORED_REPEAT: GLenum
    abstract NEAREST: GLenum
    abstract NEAREST_MIPMAP_LINEAR: GLenum
    abstract NEAREST_MIPMAP_NEAREST: GLenum
    abstract NEVER: GLenum
    abstract NICEST: GLenum
    abstract NONE: GLenum
    abstract NOTEQUAL: GLenum
    abstract NO_ERROR: GLenum
    abstract ONE: GLenum
    abstract ONE_MINUS_CONSTANT_ALPHA: GLenum
    abstract ONE_MINUS_CONSTANT_COLOR: GLenum
    abstract ONE_MINUS_DST_ALPHA: GLenum
    abstract ONE_MINUS_DST_COLOR: GLenum
    abstract ONE_MINUS_SRC_ALPHA: GLenum
    abstract ONE_MINUS_SRC_COLOR: GLenum
    abstract OUT_OF_MEMORY: GLenum
    abstract PACK_ALIGNMENT: GLenum
    abstract POINTS: GLenum
    abstract POLYGON_OFFSET_FACTOR: GLenum
    abstract POLYGON_OFFSET_FILL: GLenum
    abstract POLYGON_OFFSET_UNITS: GLenum
    abstract RED_BITS: GLenum
    abstract RENDERBUFFER: GLenum
    abstract RENDERBUFFER_ALPHA_SIZE: GLenum
    abstract RENDERBUFFER_BINDING: GLenum
    abstract RENDERBUFFER_BLUE_SIZE: GLenum
    abstract RENDERBUFFER_DEPTH_SIZE: GLenum
    abstract RENDERBUFFER_GREEN_SIZE: GLenum
    abstract RENDERBUFFER_HEIGHT: GLenum
    abstract RENDERBUFFER_INTERNAL_FORMAT: GLenum
    abstract RENDERBUFFER_RED_SIZE: GLenum
    abstract RENDERBUFFER_STENCIL_SIZE: GLenum
    abstract RENDERBUFFER_WIDTH: GLenum
    abstract RENDERER: GLenum
    abstract REPEAT: GLenum
    abstract REPLACE: GLenum
    abstract RGB: GLenum
    abstract RGB565: GLenum
    abstract RGB5_A1: GLenum
    abstract RGBA: GLenum
    abstract RGBA4: GLenum
    abstract SAMPLER_2D: GLenum
    abstract SAMPLER_CUBE: GLenum
    abstract SAMPLES: GLenum
    abstract SAMPLE_ALPHA_TO_COVERAGE: GLenum
    abstract SAMPLE_BUFFERS: GLenum
    abstract SAMPLE_COVERAGE: GLenum
    abstract SAMPLE_COVERAGE_INVERT: GLenum
    abstract SAMPLE_COVERAGE_VALUE: GLenum
    abstract SCISSOR_BOX: GLenum
    abstract SCISSOR_TEST: GLenum
    abstract SHADER_TYPE: GLenum
    abstract SHADING_LANGUAGE_VERSION: GLenum
    abstract SHORT: GLenum
    abstract SRC_ALPHA: GLenum
    abstract SRC_ALPHA_SATURATE: GLenum
    abstract SRC_COLOR: GLenum
    abstract STATIC_DRAW: GLenum
    abstract STENCIL_ATTACHMENT: GLenum
    abstract STENCIL_BACK_FAIL: GLenum
    abstract STENCIL_BACK_FUNC: GLenum
    abstract STENCIL_BACK_PASS_DEPTH_FAIL: GLenum
    abstract STENCIL_BACK_PASS_DEPTH_PASS: GLenum
    abstract STENCIL_BACK_REF: GLenum
    abstract STENCIL_BACK_VALUE_MASK: GLenum
    abstract STENCIL_BACK_WRITEMASK: GLenum
    abstract STENCIL_BITS: GLenum
    abstract STENCIL_BUFFER_BIT: GLenum
    abstract STENCIL_CLEAR_VALUE: GLenum
    abstract STENCIL_FAIL: GLenum
    abstract STENCIL_FUNC: GLenum
    abstract STENCIL_INDEX8: GLenum
    abstract STENCIL_PASS_DEPTH_FAIL: GLenum
    abstract STENCIL_PASS_DEPTH_PASS: GLenum
    abstract STENCIL_REF: GLenum
    abstract STENCIL_TEST: GLenum
    abstract STENCIL_VALUE_MASK: GLenum
    abstract STENCIL_WRITEMASK: GLenum
    abstract STREAM_DRAW: GLenum
    abstract SUBPIXEL_BITS: GLenum
    abstract TEXTURE: GLenum
    abstract TEXTURE0: GLenum
    abstract TEXTURE1: GLenum
    abstract TEXTURE10: GLenum
    abstract TEXTURE11: GLenum
    abstract TEXTURE12: GLenum
    abstract TEXTURE13: GLenum
    abstract TEXTURE14: GLenum
    abstract TEXTURE15: GLenum
    abstract TEXTURE16: GLenum
    abstract TEXTURE17: GLenum
    abstract TEXTURE18: GLenum
    abstract TEXTURE19: GLenum
    abstract TEXTURE2: GLenum
    abstract TEXTURE20: GLenum
    abstract TEXTURE21: GLenum
    abstract TEXTURE22: GLenum
    abstract TEXTURE23: GLenum
    abstract TEXTURE24: GLenum
    abstract TEXTURE25: GLenum
    abstract TEXTURE26: GLenum
    abstract TEXTURE27: GLenum
    abstract TEXTURE28: GLenum
    abstract TEXTURE29: GLenum
    abstract TEXTURE3: GLenum
    abstract TEXTURE30: GLenum
    abstract TEXTURE31: GLenum
    abstract TEXTURE4: GLenum
    abstract TEXTURE5: GLenum
    abstract TEXTURE6: GLenum
    abstract TEXTURE7: GLenum
    abstract TEXTURE8: GLenum
    abstract TEXTURE9: GLenum
    abstract TEXTURE_2D: GLenum
    abstract TEXTURE_BINDING_2D: GLenum
    abstract TEXTURE_BINDING_CUBE_MAP: GLenum
    abstract TEXTURE_CUBE_MAP: GLenum
    abstract TEXTURE_CUBE_MAP_NEGATIVE_X: GLenum
    abstract TEXTURE_CUBE_MAP_NEGATIVE_Y: GLenum
    abstract TEXTURE_CUBE_MAP_NEGATIVE_Z: GLenum
    abstract TEXTURE_CUBE_MAP_POSITIVE_X: GLenum
    abstract TEXTURE_CUBE_MAP_POSITIVE_Y: GLenum
    abstract TEXTURE_CUBE_MAP_POSITIVE_Z: GLenum
    abstract TEXTURE_MAG_FILTER: GLenum
    abstract TEXTURE_MIN_FILTER: GLenum
    abstract TEXTURE_WRAP_S: GLenum
    abstract TEXTURE_WRAP_T: GLenum
    abstract TRIANGLES: GLenum
    abstract TRIANGLE_FAN: GLenum
    abstract TRIANGLE_STRIP: GLenum
    abstract UNPACK_ALIGNMENT: GLenum
    abstract UNPACK_COLORSPACE_CONVERSION_WEBGL: GLenum
    abstract UNPACK_FLIP_Y_WEBGL: GLenum
    abstract UNPACK_PREMULTIPLY_ALPHA_WEBGL: GLenum
    abstract UNSIGNED_BYTE: GLenum
    abstract UNSIGNED_INT: GLenum
    abstract UNSIGNED_SHORT: GLenum
    abstract UNSIGNED_SHORT_4_4_4_4: GLenum
    abstract UNSIGNED_SHORT_5_5_5_1: GLenum
    abstract UNSIGNED_SHORT_5_6_5: GLenum
    abstract VALIDATE_STATUS: GLenum
    abstract VENDOR: GLenum
    abstract VERSION: GLenum
    abstract VERTEX_ATTRIB_ARRAY_BUFFER_BINDING: GLenum
    abstract VERTEX_ATTRIB_ARRAY_ENABLED: GLenum
    abstract VERTEX_ATTRIB_ARRAY_NORMALIZED: GLenum
    abstract VERTEX_ATTRIB_ARRAY_POINTER: GLenum
    abstract VERTEX_ATTRIB_ARRAY_SIZE: GLenum
    abstract VERTEX_ATTRIB_ARRAY_STRIDE: GLenum
    abstract VERTEX_ATTRIB_ARRAY_TYPE: GLenum
    abstract VERTEX_SHADER: GLenum
    abstract VIEWPORT: GLenum
    abstract ZERO: GLenum

type [<AllowNullLiteral>] WebGLRenderingContextOverloads =
    abstract bufferData: target: GLenum * size: GLsizeiptr * usage: GLenum -> unit
    abstract bufferData: target: GLenum * data: BufferSource option * usage: GLenum -> unit
    abstract bufferSubData: target: GLenum * offset: GLintptr * data: BufferSource -> unit
    abstract compressedTexImage2D: target: GLenum * level: GLint * internalformat: GLenum * width: GLsizei * height: GLsizei * border: GLint * data: ArrayBufferView -> unit
    abstract compressedTexSubImage2D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * width: GLsizei * height: GLsizei * format: GLenum * data: ArrayBufferView -> unit
    abstract readPixels: x: GLint * y: GLint * width: GLsizei * height: GLsizei * format: GLenum * ``type``: GLenum * pixels: ArrayBufferView option -> unit
    abstract texImage2D: target: GLenum * level: GLint * internalformat: GLint * width: GLsizei * height: GLsizei * border: GLint * format: GLenum * ``type``: GLenum * pixels: ArrayBufferView option -> unit
    abstract texImage2D: target: GLenum * level: GLint * internalformat: GLint * format: GLenum * ``type``: GLenum * source: TexImageSource -> unit
    abstract texSubImage2D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * width: GLsizei * height: GLsizei * format: GLenum * ``type``: GLenum * pixels: ArrayBufferView option -> unit
    abstract texSubImage2D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * format: GLenum * ``type``: GLenum * source: TexImageSource -> unit
    abstract uniform1fv: location: WebGLUniformLocation option * v: Float32List -> unit
    abstract uniform1iv: location: WebGLUniformLocation option * v: Int32List -> unit
    abstract uniform2fv: location: WebGLUniformLocation option * v: Float32List -> unit
    abstract uniform2iv: location: WebGLUniformLocation option * v: Int32List -> unit
    abstract uniform3fv: location: WebGLUniformLocation option * v: Float32List -> unit
    abstract uniform3iv: location: WebGLUniformLocation option * v: Int32List -> unit
    abstract uniform4fv: location: WebGLUniformLocation option * v: Float32List -> unit
    abstract uniform4iv: location: WebGLUniformLocation option * v: Int32List -> unit
    abstract uniformMatrix2fv: location: WebGLUniformLocation option * transpose: GLboolean * value: Float32List -> unit
    abstract uniformMatrix3fv: location: WebGLUniformLocation option * transpose: GLboolean * value: Float32List -> unit
    abstract uniformMatrix4fv: location: WebGLUniformLocation option * transpose: GLboolean * value: Float32List -> unit

type [<AllowNullLiteral>] WebGLSampler =
    interface end

/// The WebGLShader is part of the WebGL API and can either be a vertex or a fragment shader. A WebGLProgram requires both types of shaders.
type [<AllowNullLiteral>] WebGLShader =
    interface end

/// Part of the WebGL API and represents the information returned by calling the WebGLRenderingContext.getShaderPrecisionFormat() method.
type [<AllowNullLiteral>] WebGLShaderPrecisionFormat =
    abstract precision: GLint
    abstract rangeMax: GLint
    abstract rangeMin: GLint

type [<AllowNullLiteral>] WebGLSync =
    interface end

/// Part of the WebGL API and represents an opaque texture object providing storage and state for texturing operations.
type [<AllowNullLiteral>] WebGLTexture =
    interface end

type [<AllowNullLiteral>] WebGLTransformFeedback =
    interface end

/// Part of the WebGL API and represents the location of a uniform variable in a shader program.
type [<AllowNullLiteral>] WebGLUniformLocation =
    interface end

type [<AllowNullLiteral>] WebGLVertexArrayObject =
    interface end

type [<AllowNullLiteral>] WebGLVertexArrayObjectOES =
    interface end

/// The ANGLE_instanced_arrays extension is part of the WebGL API and allows to draw the same object, or groups of similar objects multiple times, if they share the same vertex data, primitive count and type.
type [<AllowNullLiteral>] ANGLE_instanced_arrays =
    abstract drawArraysInstancedANGLE: mode: GLenum * first: GLint * count: GLsizei * primcount: GLsizei -> unit
    abstract drawElementsInstancedANGLE: mode: GLenum * count: GLsizei * ``type``: GLenum * offset: GLintptr * primcount: GLsizei -> unit
    abstract vertexAttribDivisorANGLE: index: GLuint * divisor: GLuint -> unit
    abstract VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE: GLenum

type [<AllowNullLiteral>] EXT_blend_minmax =
    abstract MAX_EXT: GLenum
    abstract MIN_EXT: GLenum

type [<AllowNullLiteral>] EXT_color_buffer_float =
    interface end

type [<AllowNullLiteral>] EXT_color_buffer_half_float =
    abstract FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT: GLenum
    abstract RGB16F_EXT: GLenum
    abstract RGBA16F_EXT: GLenum
    abstract UNSIGNED_NORMALIZED_EXT: GLenum

type [<AllowNullLiteral>] EXT_float_blend =
    interface end

/// The EXT_frag_depth extension is part of the WebGL API and enables to set a depth value of a fragment from within the fragment shader.
type [<AllowNullLiteral>] EXT_frag_depth =
    interface end

type [<AllowNullLiteral>] EXT_sRGB =
    abstract FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT: GLenum
    abstract SRGB8_ALPHA8_EXT: GLenum
    abstract SRGB_ALPHA_EXT: GLenum
    abstract SRGB_EXT: GLenum

type [<AllowNullLiteral>] EXT_shader_texture_lod =
    interface end

type [<AllowNullLiteral>] EXT_texture_compression_bptc =
    abstract COMPRESSED_RGBA_BPTC_UNORM_EXT: GLenum
    abstract COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT: GLenum
    abstract COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT: GLenum
    abstract COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT: GLenum

type [<AllowNullLiteral>] EXT_texture_compression_rgtc =
    abstract COMPRESSED_RED_GREEN_RGTC2_EXT: GLenum
    abstract COMPRESSED_RED_RGTC1_EXT: GLenum
    abstract COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT: GLenum
    abstract COMPRESSED_SIGNED_RED_RGTC1_EXT: GLenum

/// The EXT_texture_filter_anisotropic extension is part of the WebGL API and exposes two constants for anisotropic filtering (AF).
type [<AllowNullLiteral>] EXT_texture_filter_anisotropic =
    abstract MAX_TEXTURE_MAX_ANISOTROPY_EXT: GLenum
    abstract TEXTURE_MAX_ANISOTROPY_EXT: GLenum

type [<AllowNullLiteral>] EXT_texture_norm16 =
    abstract R16_EXT: GLenum
    abstract R16_SNORM_EXT: GLenum
    abstract RG16_EXT: GLenum
    abstract RG16_SNORM_EXT: GLenum
    abstract RGB16_EXT: GLenum
    abstract RGB16_SNORM_EXT: GLenum
    abstract RGBA16_EXT: GLenum
    abstract RGBA16_SNORM_EXT: GLenum

type [<AllowNullLiteral>] KHR_parallel_shader_compile =
    abstract COMPLETION_STATUS_KHR: GLenum

type [<AllowNullLiteral>] OES_draw_buffers_indexed =
    abstract blendEquationSeparateiOES: buf: GLuint * modeRGB: GLenum * modeAlpha: GLenum -> unit
    abstract blendEquationiOES: buf: GLuint * mode: GLenum -> unit
    abstract blendFuncSeparateiOES: buf: GLuint * srcRGB: GLenum * dstRGB: GLenum * srcAlpha: GLenum * dstAlpha: GLenum -> unit
    abstract blendFunciOES: buf: GLuint * src: GLenum * dst: GLenum -> unit
    abstract colorMaskiOES: buf: GLuint * r: GLboolean * g: GLboolean * b: GLboolean * a: GLboolean -> unit
    abstract disableiOES: target: GLenum * index: GLuint -> unit
    abstract enableiOES: target: GLenum * index: GLuint -> unit

/// The OES_element_index_uint extension is part of the WebGL API and adds support for gl.UNSIGNED_INT types to WebGLRenderingContext.drawElements().
type [<AllowNullLiteral>] OES_element_index_uint =
    interface end

type [<AllowNullLiteral>] OES_fbo_render_mipmap =
    interface end

/// The OES_standard_derivatives extension is part of the WebGL API and adds the GLSL derivative functions dFdx, dFdy, and fwidth.
type [<AllowNullLiteral>] OES_standard_derivatives =
    abstract FRAGMENT_SHADER_DERIVATIVE_HINT_OES: GLenum

/// The OES_texture_float extension is part of the WebGL API and exposes floating-point pixel types for textures.
type [<AllowNullLiteral>] OES_texture_float =
    interface end

/// The OES_texture_float_linear extension is part of the WebGL API and allows linear filtering with floating-point pixel types for textures.
type [<AllowNullLiteral>] OES_texture_float_linear =
    interface end

/// The OES_texture_half_float extension is part of the WebGL API and adds texture formats with 16- (aka half float) and 32-bit floating-point components.
type [<AllowNullLiteral>] OES_texture_half_float =
    abstract HALF_FLOAT_OES: GLenum

/// The OES_texture_half_float_linear extension is part of the WebGL API and allows linear filtering with half floating-point pixel types for textures.
type [<AllowNullLiteral>] OES_texture_half_float_linear =
    interface end

type [<AllowNullLiteral>] OES_vertex_array_object =
    abstract bindVertexArrayOES: arrayObject: WebGLVertexArrayObjectOES option -> unit
    abstract createVertexArrayOES: unit -> WebGLVertexArrayObjectOES option
    abstract deleteVertexArrayOES: arrayObject: WebGLVertexArrayObjectOES option -> unit
    abstract isVertexArrayOES: arrayObject: WebGLVertexArrayObjectOES option -> GLboolean
    abstract VERTEX_ARRAY_BINDING_OES: GLenum

type [<AllowNullLiteral>] OVR_multiview2 =
    abstract framebufferTextureMultiviewOVR: target: GLenum * attachment: GLenum * texture: WebGLTexture option * level: GLint * baseViewIndex: GLint * numViews: GLsizei -> unit
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR: GLenum
    abstract FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR: GLenum
    abstract MAX_VIEWS_OVR: GLenum

type [<AllowNullLiteral>] CanvasCaptureMediaStreamTrackType =
    abstract prototype: CanvasCaptureMediaStreamTrack with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] CanvasGradientType =
    abstract prototype: CanvasGradient with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] CanvasPatternType =
    abstract prototype: CanvasPattern with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] CanvasRenderingContext2DType =
    abstract prototype: CanvasRenderingContext2D with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] OffscreenCanvasType =
    abstract prototype: OffscreenCanvas with get, set
    [<Emit "new $0($1...)">] abstract Create: width: float * height: float -> obj

type [<AllowNullLiteral>] OffscreenCanvasRenderingContext2DType =
    abstract prototype: OffscreenCanvasRenderingContext2D with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] ImageBitmapType =
    abstract prototype: ImageBitmap with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] ImageBitmapRenderingContextType =
    abstract prototype: ImageBitmapRenderingContext with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] WebGL2RenderingContextType =
    abstract prototype: WebGL2RenderingContext with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj
    abstract ACTIVE_UNIFORM_BLOCKS: GLenum
    abstract ALREADY_SIGNALED: GLenum
    abstract ANY_SAMPLES_PASSED: GLenum
    abstract ANY_SAMPLES_PASSED_CONSERVATIVE: GLenum
    abstract COLOR: GLenum
    abstract COLOR_ATTACHMENT1: GLenum
    abstract COLOR_ATTACHMENT10: GLenum
    abstract COLOR_ATTACHMENT11: GLenum
    abstract COLOR_ATTACHMENT12: GLenum
    abstract COLOR_ATTACHMENT13: GLenum
    abstract COLOR_ATTACHMENT14: GLenum
    abstract COLOR_ATTACHMENT15: GLenum
    abstract COLOR_ATTACHMENT2: GLenum
    abstract COLOR_ATTACHMENT3: GLenum
    abstract COLOR_ATTACHMENT4: GLenum
    abstract COLOR_ATTACHMENT5: GLenum
    abstract COLOR_ATTACHMENT6: GLenum
    abstract COLOR_ATTACHMENT7: GLenum
    abstract COLOR_ATTACHMENT8: GLenum
    abstract COLOR_ATTACHMENT9: GLenum
    abstract COMPARE_REF_TO_TEXTURE: GLenum
    abstract CONDITION_SATISFIED: GLenum
    abstract COPY_READ_BUFFER: GLenum
    abstract COPY_READ_BUFFER_BINDING: GLenum
    abstract COPY_WRITE_BUFFER: GLenum
    abstract COPY_WRITE_BUFFER_BINDING: GLenum
    abstract CURRENT_QUERY: GLenum
    abstract DEPTH: GLenum
    abstract DEPTH24_STENCIL8: GLenum
    abstract DEPTH32F_STENCIL8: GLenum
    abstract DEPTH_COMPONENT24: GLenum
    abstract DEPTH_COMPONENT32F: GLenum
    abstract DRAW_BUFFER0: GLenum
    abstract DRAW_BUFFER1: GLenum
    abstract DRAW_BUFFER10: GLenum
    abstract DRAW_BUFFER11: GLenum
    abstract DRAW_BUFFER12: GLenum
    abstract DRAW_BUFFER13: GLenum
    abstract DRAW_BUFFER14: GLenum
    abstract DRAW_BUFFER15: GLenum
    abstract DRAW_BUFFER2: GLenum
    abstract DRAW_BUFFER3: GLenum
    abstract DRAW_BUFFER4: GLenum
    abstract DRAW_BUFFER5: GLenum
    abstract DRAW_BUFFER6: GLenum
    abstract DRAW_BUFFER7: GLenum
    abstract DRAW_BUFFER8: GLenum
    abstract DRAW_BUFFER9: GLenum
    abstract DRAW_FRAMEBUFFER: GLenum
    abstract DRAW_FRAMEBUFFER_BINDING: GLenum
    abstract DYNAMIC_COPY: GLenum
    abstract DYNAMIC_READ: GLenum
    abstract FLOAT_32_UNSIGNED_INT_24_8_REV: GLenum
    abstract FLOAT_MAT2x3: GLenum
    abstract FLOAT_MAT2x4: GLenum
    abstract FLOAT_MAT3x2: GLenum
    abstract FLOAT_MAT3x4: GLenum
    abstract FLOAT_MAT4x2: GLenum
    abstract FLOAT_MAT4x3: GLenum
    abstract FRAGMENT_SHADER_DERIVATIVE_HINT: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_BLUE_SIZE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_GREEN_SIZE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_RED_SIZE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER: GLenum
    abstract FRAMEBUFFER_DEFAULT: GLenum
    abstract FRAMEBUFFER_INCOMPLETE_MULTISAMPLE: GLenum
    abstract HALF_FLOAT: GLenum
    abstract INTERLEAVED_ATTRIBS: GLenum
    abstract INT_2_10_10_10_REV: GLenum
    abstract INT_SAMPLER_2D: GLenum
    abstract INT_SAMPLER_2D_ARRAY: GLenum
    abstract INT_SAMPLER_3D: GLenum
    abstract INT_SAMPLER_CUBE: GLenum
    abstract INVALID_INDEX: GLenum
    abstract MAX: GLenum
    abstract MAX_3D_TEXTURE_SIZE: GLenum
    abstract MAX_ARRAY_TEXTURE_LAYERS: GLenum
    abstract MAX_CLIENT_WAIT_TIMEOUT_WEBGL: GLenum
    abstract MAX_COLOR_ATTACHMENTS: GLenum
    abstract MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS: GLenum
    abstract MAX_COMBINED_UNIFORM_BLOCKS: GLenum
    abstract MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS: GLenum
    abstract MAX_DRAW_BUFFERS: GLenum
    abstract MAX_ELEMENTS_INDICES: GLenum
    abstract MAX_ELEMENTS_VERTICES: GLenum
    abstract MAX_ELEMENT_INDEX: GLenum
    abstract MAX_FRAGMENT_INPUT_COMPONENTS: GLenum
    abstract MAX_FRAGMENT_UNIFORM_BLOCKS: GLenum
    abstract MAX_FRAGMENT_UNIFORM_COMPONENTS: GLenum
    abstract MAX_PROGRAM_TEXEL_OFFSET: GLenum
    abstract MAX_SAMPLES: GLenum
    abstract MAX_SERVER_WAIT_TIMEOUT: GLenum
    abstract MAX_TEXTURE_LOD_BIAS: GLenum
    abstract MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS: GLenum
    abstract MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS: GLenum
    abstract MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS: GLenum
    abstract MAX_UNIFORM_BLOCK_SIZE: GLenum
    abstract MAX_UNIFORM_BUFFER_BINDINGS: GLenum
    abstract MAX_VARYING_COMPONENTS: GLenum
    abstract MAX_VERTEX_OUTPUT_COMPONENTS: GLenum
    abstract MAX_VERTEX_UNIFORM_BLOCKS: GLenum
    abstract MAX_VERTEX_UNIFORM_COMPONENTS: GLenum
    abstract MIN: GLenum
    abstract MIN_PROGRAM_TEXEL_OFFSET: GLenum
    abstract OBJECT_TYPE: GLenum
    abstract PACK_ROW_LENGTH: GLenum
    abstract PACK_SKIP_PIXELS: GLenum
    abstract PACK_SKIP_ROWS: GLenum
    abstract PIXEL_PACK_BUFFER: GLenum
    abstract PIXEL_PACK_BUFFER_BINDING: GLenum
    abstract PIXEL_UNPACK_BUFFER: GLenum
    abstract PIXEL_UNPACK_BUFFER_BINDING: GLenum
    abstract QUERY_RESULT: GLenum
    abstract QUERY_RESULT_AVAILABLE: GLenum
    abstract R11F_G11F_B10F: GLenum
    abstract R16F: GLenum
    abstract R16I: GLenum
    abstract R16UI: GLenum
    abstract R32F: GLenum
    abstract R32I: GLenum
    abstract R32UI: GLenum
    abstract R8: GLenum
    abstract R8I: GLenum
    abstract R8UI: GLenum
    abstract R8_SNORM: GLenum
    abstract RASTERIZER_DISCARD: GLenum
    abstract READ_BUFFER: GLenum
    abstract READ_FRAMEBUFFER: GLenum
    abstract READ_FRAMEBUFFER_BINDING: GLenum
    abstract RED: GLenum
    abstract RED_INTEGER: GLenum
    abstract RENDERBUFFER_SAMPLES: GLenum
    abstract RG: GLenum
    abstract RG16F: GLenum
    abstract RG16I: GLenum
    abstract RG16UI: GLenum
    abstract RG32F: GLenum
    abstract RG32I: GLenum
    abstract RG32UI: GLenum
    abstract RG8: GLenum
    abstract RG8I: GLenum
    abstract RG8UI: GLenum
    abstract RG8_SNORM: GLenum
    abstract RGB10_A2: GLenum
    abstract RGB10_A2UI: GLenum
    abstract RGB16F: GLenum
    abstract RGB16I: GLenum
    abstract RGB16UI: GLenum
    abstract RGB32F: GLenum
    abstract RGB32I: GLenum
    abstract RGB32UI: GLenum
    abstract RGB8: GLenum
    abstract RGB8I: GLenum
    abstract RGB8UI: GLenum
    abstract RGB8_SNORM: GLenum
    abstract RGB9_E5: GLenum
    abstract RGBA16F: GLenum
    abstract RGBA16I: GLenum
    abstract RGBA16UI: GLenum
    abstract RGBA32F: GLenum
    abstract RGBA32I: GLenum
    abstract RGBA32UI: GLenum
    abstract RGBA8: GLenum
    abstract RGBA8I: GLenum
    abstract RGBA8UI: GLenum
    abstract RGBA8_SNORM: GLenum
    abstract RGBA_INTEGER: GLenum
    abstract RGB_INTEGER: GLenum
    abstract RG_INTEGER: GLenum
    abstract SAMPLER_2D_ARRAY: GLenum
    abstract SAMPLER_2D_ARRAY_SHADOW: GLenum
    abstract SAMPLER_2D_SHADOW: GLenum
    abstract SAMPLER_3D: GLenum
    abstract SAMPLER_BINDING: GLenum
    abstract SAMPLER_CUBE_SHADOW: GLenum
    abstract SEPARATE_ATTRIBS: GLenum
    abstract SIGNALED: GLenum
    abstract SIGNED_NORMALIZED: GLenum
    abstract SRGB: GLenum
    abstract SRGB8: GLenum
    abstract SRGB8_ALPHA8: GLenum
    abstract STATIC_COPY: GLenum
    abstract STATIC_READ: GLenum
    abstract STENCIL: GLenum
    abstract STREAM_COPY: GLenum
    abstract STREAM_READ: GLenum
    abstract SYNC_CONDITION: GLenum
    abstract SYNC_FENCE: GLenum
    abstract SYNC_FLAGS: GLenum
    abstract SYNC_FLUSH_COMMANDS_BIT: GLenum
    abstract SYNC_GPU_COMMANDS_COMPLETE: GLenum
    abstract SYNC_STATUS: GLenum
    abstract TEXTURE_2D_ARRAY: GLenum
    abstract TEXTURE_3D: GLenum
    abstract TEXTURE_BASE_LEVEL: GLenum
    abstract TEXTURE_BINDING_2D_ARRAY: GLenum
    abstract TEXTURE_BINDING_3D: GLenum
    abstract TEXTURE_COMPARE_FUNC: GLenum
    abstract TEXTURE_COMPARE_MODE: GLenum
    abstract TEXTURE_IMMUTABLE_FORMAT: GLenum
    abstract TEXTURE_IMMUTABLE_LEVELS: GLenum
    abstract TEXTURE_MAX_LEVEL: GLenum
    abstract TEXTURE_MAX_LOD: GLenum
    abstract TEXTURE_MIN_LOD: GLenum
    abstract TEXTURE_WRAP_R: GLenum
    abstract TIMEOUT_EXPIRED: GLenum
    abstract TIMEOUT_IGNORED: GLint64
    abstract TRANSFORM_FEEDBACK: GLenum
    abstract TRANSFORM_FEEDBACK_ACTIVE: GLenum
    abstract TRANSFORM_FEEDBACK_BINDING: GLenum
    abstract TRANSFORM_FEEDBACK_BUFFER: GLenum
    abstract TRANSFORM_FEEDBACK_BUFFER_BINDING: GLenum
    abstract TRANSFORM_FEEDBACK_BUFFER_MODE: GLenum
    abstract TRANSFORM_FEEDBACK_BUFFER_SIZE: GLenum
    abstract TRANSFORM_FEEDBACK_BUFFER_START: GLenum
    abstract TRANSFORM_FEEDBACK_PAUSED: GLenum
    abstract TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN: GLenum
    abstract TRANSFORM_FEEDBACK_VARYINGS: GLenum
    abstract UNIFORM_ARRAY_STRIDE: GLenum
    abstract UNIFORM_BLOCK_ACTIVE_UNIFORMS: GLenum
    abstract UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES: GLenum
    abstract UNIFORM_BLOCK_BINDING: GLenum
    abstract UNIFORM_BLOCK_DATA_SIZE: GLenum
    abstract UNIFORM_BLOCK_INDEX: GLenum
    abstract UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER: GLenum
    abstract UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER: GLenum
    abstract UNIFORM_BUFFER: GLenum
    abstract UNIFORM_BUFFER_BINDING: GLenum
    abstract UNIFORM_BUFFER_OFFSET_ALIGNMENT: GLenum
    abstract UNIFORM_BUFFER_SIZE: GLenum
    abstract UNIFORM_BUFFER_START: GLenum
    abstract UNIFORM_IS_ROW_MAJOR: GLenum
    abstract UNIFORM_MATRIX_STRIDE: GLenum
    abstract UNIFORM_OFFSET: GLenum
    abstract UNIFORM_SIZE: GLenum
    abstract UNIFORM_TYPE: GLenum
    abstract UNPACK_IMAGE_HEIGHT: GLenum
    abstract UNPACK_ROW_LENGTH: GLenum
    abstract UNPACK_SKIP_IMAGES: GLenum
    abstract UNPACK_SKIP_PIXELS: GLenum
    abstract UNPACK_SKIP_ROWS: GLenum
    abstract UNSIGNALED: GLenum
    abstract UNSIGNED_INT_10F_11F_11F_REV: GLenum
    abstract UNSIGNED_INT_24_8: GLenum
    abstract UNSIGNED_INT_2_10_10_10_REV: GLenum
    abstract UNSIGNED_INT_5_9_9_9_REV: GLenum
    abstract UNSIGNED_INT_SAMPLER_2D: GLenum
    abstract UNSIGNED_INT_SAMPLER_2D_ARRAY: GLenum
    abstract UNSIGNED_INT_SAMPLER_3D: GLenum
    abstract UNSIGNED_INT_SAMPLER_CUBE: GLenum
    abstract UNSIGNED_INT_VEC2: GLenum
    abstract UNSIGNED_INT_VEC3: GLenum
    abstract UNSIGNED_INT_VEC4: GLenum
    abstract UNSIGNED_NORMALIZED: GLenum
    abstract VERTEX_ARRAY_BINDING: GLenum
    abstract VERTEX_ATTRIB_ARRAY_DIVISOR: GLenum
    abstract VERTEX_ATTRIB_ARRAY_INTEGER: GLenum
    abstract WAIT_FAILED: GLenum
    abstract ACTIVE_ATTRIBUTES: GLenum
    abstract ACTIVE_TEXTURE: GLenum
    abstract ACTIVE_UNIFORMS: GLenum
    abstract ALIASED_LINE_WIDTH_RANGE: GLenum
    abstract ALIASED_POINT_SIZE_RANGE: GLenum
    abstract ALPHA: GLenum
    abstract ALPHA_BITS: GLenum
    abstract ALWAYS: GLenum
    abstract ARRAY_BUFFER: GLenum
    abstract ARRAY_BUFFER_BINDING: GLenum
    abstract ATTACHED_SHADERS: GLenum
    abstract BACK: GLenum
    abstract BLEND: GLenum
    abstract BLEND_COLOR: GLenum
    abstract BLEND_DST_ALPHA: GLenum
    abstract BLEND_DST_RGB: GLenum
    abstract BLEND_EQUATION: GLenum
    abstract BLEND_EQUATION_ALPHA: GLenum
    abstract BLEND_EQUATION_RGB: GLenum
    abstract BLEND_SRC_ALPHA: GLenum
    abstract BLEND_SRC_RGB: GLenum
    abstract BLUE_BITS: GLenum
    abstract BOOL: GLenum
    abstract BOOL_VEC2: GLenum
    abstract BOOL_VEC3: GLenum
    abstract BOOL_VEC4: GLenum
    abstract BROWSER_DEFAULT_WEBGL: GLenum
    abstract BUFFER_SIZE: GLenum
    abstract BUFFER_USAGE: GLenum
    abstract BYTE: GLenum
    abstract CCW: GLenum
    abstract CLAMP_TO_EDGE: GLenum
    abstract COLOR_ATTACHMENT0: GLenum
    abstract COLOR_BUFFER_BIT: GLenum
    abstract COLOR_CLEAR_VALUE: GLenum
    abstract COLOR_WRITEMASK: GLenum
    abstract COMPILE_STATUS: GLenum
    abstract COMPRESSED_TEXTURE_FORMATS: GLenum
    abstract CONSTANT_ALPHA: GLenum
    abstract CONSTANT_COLOR: GLenum
    abstract CONTEXT_LOST_WEBGL: GLenum
    abstract CULL_FACE: GLenum
    abstract CULL_FACE_MODE: GLenum
    abstract CURRENT_PROGRAM: GLenum
    abstract CURRENT_VERTEX_ATTRIB: GLenum
    abstract CW: GLenum
    abstract DECR: GLenum
    abstract DECR_WRAP: GLenum
    abstract DELETE_STATUS: GLenum
    abstract DEPTH_ATTACHMENT: GLenum
    abstract DEPTH_BITS: GLenum
    abstract DEPTH_BUFFER_BIT: GLenum
    abstract DEPTH_CLEAR_VALUE: GLenum
    abstract DEPTH_COMPONENT: GLenum
    abstract DEPTH_COMPONENT16: GLenum
    abstract DEPTH_FUNC: GLenum
    abstract DEPTH_RANGE: GLenum
    abstract DEPTH_STENCIL: GLenum
    abstract DEPTH_STENCIL_ATTACHMENT: GLenum
    abstract DEPTH_TEST: GLenum
    abstract DEPTH_WRITEMASK: GLenum
    abstract DITHER: GLenum
    abstract DONT_CARE: GLenum
    abstract DST_ALPHA: GLenum
    abstract DST_COLOR: GLenum
    abstract DYNAMIC_DRAW: GLenum
    abstract ELEMENT_ARRAY_BUFFER: GLenum
    abstract ELEMENT_ARRAY_BUFFER_BINDING: GLenum
    abstract EQUAL: GLenum
    abstract FASTEST: GLenum
    abstract FLOAT: GLenum
    abstract FLOAT_MAT2: GLenum
    abstract FLOAT_MAT3: GLenum
    abstract FLOAT_MAT4: GLenum
    abstract FLOAT_VEC2: GLenum
    abstract FLOAT_VEC3: GLenum
    abstract FLOAT_VEC4: GLenum
    abstract FRAGMENT_SHADER: GLenum
    abstract FRAMEBUFFER: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_OBJECT_NAME: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL: GLenum
    abstract FRAMEBUFFER_BINDING: GLenum
    abstract FRAMEBUFFER_COMPLETE: GLenum
    abstract FRAMEBUFFER_INCOMPLETE_ATTACHMENT: GLenum
    abstract FRAMEBUFFER_INCOMPLETE_DIMENSIONS: GLenum
    abstract FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT: GLenum
    abstract FRAMEBUFFER_UNSUPPORTED: GLenum
    abstract FRONT: GLenum
    abstract FRONT_AND_BACK: GLenum
    abstract FRONT_FACE: GLenum
    abstract FUNC_ADD: GLenum
    abstract FUNC_REVERSE_SUBTRACT: GLenum
    abstract FUNC_SUBTRACT: GLenum
    abstract GENERATE_MIPMAP_HINT: GLenum
    abstract GEQUAL: GLenum
    abstract GREATER: GLenum
    abstract GREEN_BITS: GLenum
    abstract HIGH_FLOAT: GLenum
    abstract HIGH_INT: GLenum
    abstract IMPLEMENTATION_COLOR_READ_FORMAT: GLenum
    abstract IMPLEMENTATION_COLOR_READ_TYPE: GLenum
    abstract INCR: GLenum
    abstract INCR_WRAP: GLenum
    abstract INT: GLenum
    abstract INT_VEC2: GLenum
    abstract INT_VEC3: GLenum
    abstract INT_VEC4: GLenum
    abstract INVALID_ENUM: GLenum
    abstract INVALID_FRAMEBUFFER_OPERATION: GLenum
    abstract INVALID_OPERATION: GLenum
    abstract INVALID_VALUE: GLenum
    abstract INVERT: GLenum
    abstract KEEP: GLenum
    abstract LEQUAL: GLenum
    abstract LESS: GLenum
    abstract LINEAR: GLenum
    abstract LINEAR_MIPMAP_LINEAR: GLenum
    abstract LINEAR_MIPMAP_NEAREST: GLenum
    abstract LINES: GLenum
    abstract LINE_LOOP: GLenum
    abstract LINE_STRIP: GLenum
    abstract LINE_WIDTH: GLenum
    abstract LINK_STATUS: GLenum
    abstract LOW_FLOAT: GLenum
    abstract LOW_INT: GLenum
    abstract LUMINANCE: GLenum
    abstract LUMINANCE_ALPHA: GLenum
    abstract MAX_COMBINED_TEXTURE_IMAGE_UNITS: GLenum
    abstract MAX_CUBE_MAP_TEXTURE_SIZE: GLenum
    abstract MAX_FRAGMENT_UNIFORM_VECTORS: GLenum
    abstract MAX_RENDERBUFFER_SIZE: GLenum
    abstract MAX_TEXTURE_IMAGE_UNITS: GLenum
    abstract MAX_TEXTURE_SIZE: GLenum
    abstract MAX_VARYING_VECTORS: GLenum
    abstract MAX_VERTEX_ATTRIBS: GLenum
    abstract MAX_VERTEX_TEXTURE_IMAGE_UNITS: GLenum
    abstract MAX_VERTEX_UNIFORM_VECTORS: GLenum
    abstract MAX_VIEWPORT_DIMS: GLenum
    abstract MEDIUM_FLOAT: GLenum
    abstract MEDIUM_INT: GLenum
    abstract MIRRORED_REPEAT: GLenum
    abstract NEAREST: GLenum
    abstract NEAREST_MIPMAP_LINEAR: GLenum
    abstract NEAREST_MIPMAP_NEAREST: GLenum
    abstract NEVER: GLenum
    abstract NICEST: GLenum
    abstract NONE: GLenum
    abstract NOTEQUAL: GLenum
    abstract NO_ERROR: GLenum
    abstract ONE: GLenum
    abstract ONE_MINUS_CONSTANT_ALPHA: GLenum
    abstract ONE_MINUS_CONSTANT_COLOR: GLenum
    abstract ONE_MINUS_DST_ALPHA: GLenum
    abstract ONE_MINUS_DST_COLOR: GLenum
    abstract ONE_MINUS_SRC_ALPHA: GLenum
    abstract ONE_MINUS_SRC_COLOR: GLenum
    abstract OUT_OF_MEMORY: GLenum
    abstract PACK_ALIGNMENT: GLenum
    abstract POINTS: GLenum
    abstract POLYGON_OFFSET_FACTOR: GLenum
    abstract POLYGON_OFFSET_FILL: GLenum
    abstract POLYGON_OFFSET_UNITS: GLenum
    abstract RED_BITS: GLenum
    abstract RENDERBUFFER: GLenum
    abstract RENDERBUFFER_ALPHA_SIZE: GLenum
    abstract RENDERBUFFER_BINDING: GLenum
    abstract RENDERBUFFER_BLUE_SIZE: GLenum
    abstract RENDERBUFFER_DEPTH_SIZE: GLenum
    abstract RENDERBUFFER_GREEN_SIZE: GLenum
    abstract RENDERBUFFER_HEIGHT: GLenum
    abstract RENDERBUFFER_INTERNAL_FORMAT: GLenum
    abstract RENDERBUFFER_RED_SIZE: GLenum
    abstract RENDERBUFFER_STENCIL_SIZE: GLenum
    abstract RENDERBUFFER_WIDTH: GLenum
    abstract RENDERER: GLenum
    abstract REPEAT: GLenum
    abstract REPLACE: GLenum
    abstract RGB: GLenum
    abstract RGB565: GLenum
    abstract RGB5_A1: GLenum
    abstract RGBA: GLenum
    abstract RGBA4: GLenum
    abstract SAMPLER_2D: GLenum
    abstract SAMPLER_CUBE: GLenum
    abstract SAMPLES: GLenum
    abstract SAMPLE_ALPHA_TO_COVERAGE: GLenum
    abstract SAMPLE_BUFFERS: GLenum
    abstract SAMPLE_COVERAGE: GLenum
    abstract SAMPLE_COVERAGE_INVERT: GLenum
    abstract SAMPLE_COVERAGE_VALUE: GLenum
    abstract SCISSOR_BOX: GLenum
    abstract SCISSOR_TEST: GLenum
    abstract SHADER_TYPE: GLenum
    abstract SHADING_LANGUAGE_VERSION: GLenum
    abstract SHORT: GLenum
    abstract SRC_ALPHA: GLenum
    abstract SRC_ALPHA_SATURATE: GLenum
    abstract SRC_COLOR: GLenum
    abstract STATIC_DRAW: GLenum
    abstract STENCIL_ATTACHMENT: GLenum
    abstract STENCIL_BACK_FAIL: GLenum
    abstract STENCIL_BACK_FUNC: GLenum
    abstract STENCIL_BACK_PASS_DEPTH_FAIL: GLenum
    abstract STENCIL_BACK_PASS_DEPTH_PASS: GLenum
    abstract STENCIL_BACK_REF: GLenum
    abstract STENCIL_BACK_VALUE_MASK: GLenum
    abstract STENCIL_BACK_WRITEMASK: GLenum
    abstract STENCIL_BITS: GLenum
    abstract STENCIL_BUFFER_BIT: GLenum
    abstract STENCIL_CLEAR_VALUE: GLenum
    abstract STENCIL_FAIL: GLenum
    abstract STENCIL_FUNC: GLenum
    abstract STENCIL_INDEX8: GLenum
    abstract STENCIL_PASS_DEPTH_FAIL: GLenum
    abstract STENCIL_PASS_DEPTH_PASS: GLenum
    abstract STENCIL_REF: GLenum
    abstract STENCIL_TEST: GLenum
    abstract STENCIL_VALUE_MASK: GLenum
    abstract STENCIL_WRITEMASK: GLenum
    abstract STREAM_DRAW: GLenum
    abstract SUBPIXEL_BITS: GLenum
    abstract TEXTURE: GLenum
    abstract TEXTURE0: GLenum
    abstract TEXTURE1: GLenum
    abstract TEXTURE10: GLenum
    abstract TEXTURE11: GLenum
    abstract TEXTURE12: GLenum
    abstract TEXTURE13: GLenum
    abstract TEXTURE14: GLenum
    abstract TEXTURE15: GLenum
    abstract TEXTURE16: GLenum
    abstract TEXTURE17: GLenum
    abstract TEXTURE18: GLenum
    abstract TEXTURE19: GLenum
    abstract TEXTURE2: GLenum
    abstract TEXTURE20: GLenum
    abstract TEXTURE21: GLenum
    abstract TEXTURE22: GLenum
    abstract TEXTURE23: GLenum
    abstract TEXTURE24: GLenum
    abstract TEXTURE25: GLenum
    abstract TEXTURE26: GLenum
    abstract TEXTURE27: GLenum
    abstract TEXTURE28: GLenum
    abstract TEXTURE29: GLenum
    abstract TEXTURE3: GLenum
    abstract TEXTURE30: GLenum
    abstract TEXTURE31: GLenum
    abstract TEXTURE4: GLenum
    abstract TEXTURE5: GLenum
    abstract TEXTURE6: GLenum
    abstract TEXTURE7: GLenum
    abstract TEXTURE8: GLenum
    abstract TEXTURE9: GLenum
    abstract TEXTURE_2D: GLenum
    abstract TEXTURE_BINDING_2D: GLenum
    abstract TEXTURE_BINDING_CUBE_MAP: GLenum
    abstract TEXTURE_CUBE_MAP: GLenum
    abstract TEXTURE_CUBE_MAP_NEGATIVE_X: GLenum
    abstract TEXTURE_CUBE_MAP_NEGATIVE_Y: GLenum
    abstract TEXTURE_CUBE_MAP_NEGATIVE_Z: GLenum
    abstract TEXTURE_CUBE_MAP_POSITIVE_X: GLenum
    abstract TEXTURE_CUBE_MAP_POSITIVE_Y: GLenum
    abstract TEXTURE_CUBE_MAP_POSITIVE_Z: GLenum
    abstract TEXTURE_MAG_FILTER: GLenum
    abstract TEXTURE_MIN_FILTER: GLenum
    abstract TEXTURE_WRAP_S: GLenum
    abstract TEXTURE_WRAP_T: GLenum
    abstract TRIANGLES: GLenum
    abstract TRIANGLE_FAN: GLenum
    abstract TRIANGLE_STRIP: GLenum
    abstract UNPACK_ALIGNMENT: GLenum
    abstract UNPACK_COLORSPACE_CONVERSION_WEBGL: GLenum
    abstract UNPACK_FLIP_Y_WEBGL: GLenum
    abstract UNPACK_PREMULTIPLY_ALPHA_WEBGL: GLenum
    abstract UNSIGNED_BYTE: GLenum
    abstract UNSIGNED_INT: GLenum
    abstract UNSIGNED_SHORT: GLenum
    abstract UNSIGNED_SHORT_4_4_4_4: GLenum
    abstract UNSIGNED_SHORT_5_5_5_1: GLenum
    abstract UNSIGNED_SHORT_5_6_5: GLenum
    abstract VALIDATE_STATUS: GLenum
    abstract VENDOR: GLenum
    abstract VERSION: GLenum
    abstract VERTEX_ATTRIB_ARRAY_BUFFER_BINDING: GLenum
    abstract VERTEX_ATTRIB_ARRAY_ENABLED: GLenum
    abstract VERTEX_ATTRIB_ARRAY_NORMALIZED: GLenum
    abstract VERTEX_ATTRIB_ARRAY_POINTER: GLenum
    abstract VERTEX_ATTRIB_ARRAY_SIZE: GLenum
    abstract VERTEX_ATTRIB_ARRAY_STRIDE: GLenum
    abstract VERTEX_ATTRIB_ARRAY_TYPE: GLenum
    abstract VERTEX_SHADER: GLenum
    abstract VIEWPORT: GLenum
    abstract ZERO: GLenum

type [<AllowNullLiteral>] WebGLActiveInfoType =
    abstract prototype: WebGLActiveInfo with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] WebGLBufferType =
    abstract prototype: WebGLBuffer with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] WebGLContextEventType =
    abstract prototype: WebGLContextEvent with get, set
    [<Emit "new $0($1...)">] abstract Create: ``type``: string * ?eventInit: WebGLContextEventInit -> obj

type [<AllowNullLiteral>] WebGLFramebufferType =
    abstract prototype: WebGLFramebuffer with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] WebGLProgramType =
    abstract prototype: WebGLProgram with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] WebGLQueryType =
    abstract prototype: WebGLQuery with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] WebGLRenderbufferType =
    abstract prototype: WebGLRenderbuffer with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] WebGLRenderingContextType =
    abstract prototype: WebGLRenderingContext with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj
    abstract ACTIVE_ATTRIBUTES: GLenum
    abstract ACTIVE_TEXTURE: GLenum
    abstract ACTIVE_UNIFORMS: GLenum
    abstract ALIASED_LINE_WIDTH_RANGE: GLenum
    abstract ALIASED_POINT_SIZE_RANGE: GLenum
    abstract ALPHA: GLenum
    abstract ALPHA_BITS: GLenum
    abstract ALWAYS: GLenum
    abstract ARRAY_BUFFER: GLenum
    abstract ARRAY_BUFFER_BINDING: GLenum
    abstract ATTACHED_SHADERS: GLenum
    abstract BACK: GLenum
    abstract BLEND: GLenum
    abstract BLEND_COLOR: GLenum
    abstract BLEND_DST_ALPHA: GLenum
    abstract BLEND_DST_RGB: GLenum
    abstract BLEND_EQUATION: GLenum
    abstract BLEND_EQUATION_ALPHA: GLenum
    abstract BLEND_EQUATION_RGB: GLenum
    abstract BLEND_SRC_ALPHA: GLenum
    abstract BLEND_SRC_RGB: GLenum
    abstract BLUE_BITS: GLenum
    abstract BOOL: GLenum
    abstract BOOL_VEC2: GLenum
    abstract BOOL_VEC3: GLenum
    abstract BOOL_VEC4: GLenum
    abstract BROWSER_DEFAULT_WEBGL: GLenum
    abstract BUFFER_SIZE: GLenum
    abstract BUFFER_USAGE: GLenum
    abstract BYTE: GLenum
    abstract CCW: GLenum
    abstract CLAMP_TO_EDGE: GLenum
    abstract COLOR_ATTACHMENT0: GLenum
    abstract COLOR_BUFFER_BIT: GLenum
    abstract COLOR_CLEAR_VALUE: GLenum
    abstract COLOR_WRITEMASK: GLenum
    abstract COMPILE_STATUS: GLenum
    abstract COMPRESSED_TEXTURE_FORMATS: GLenum
    abstract CONSTANT_ALPHA: GLenum
    abstract CONSTANT_COLOR: GLenum
    abstract CONTEXT_LOST_WEBGL: GLenum
    abstract CULL_FACE: GLenum
    abstract CULL_FACE_MODE: GLenum
    abstract CURRENT_PROGRAM: GLenum
    abstract CURRENT_VERTEX_ATTRIB: GLenum
    abstract CW: GLenum
    abstract DECR: GLenum
    abstract DECR_WRAP: GLenum
    abstract DELETE_STATUS: GLenum
    abstract DEPTH_ATTACHMENT: GLenum
    abstract DEPTH_BITS: GLenum
    abstract DEPTH_BUFFER_BIT: GLenum
    abstract DEPTH_CLEAR_VALUE: GLenum
    abstract DEPTH_COMPONENT: GLenum
    abstract DEPTH_COMPONENT16: GLenum
    abstract DEPTH_FUNC: GLenum
    abstract DEPTH_RANGE: GLenum
    abstract DEPTH_STENCIL: GLenum
    abstract DEPTH_STENCIL_ATTACHMENT: GLenum
    abstract DEPTH_TEST: GLenum
    abstract DEPTH_WRITEMASK: GLenum
    abstract DITHER: GLenum
    abstract DONT_CARE: GLenum
    abstract DST_ALPHA: GLenum
    abstract DST_COLOR: GLenum
    abstract DYNAMIC_DRAW: GLenum
    abstract ELEMENT_ARRAY_BUFFER: GLenum
    abstract ELEMENT_ARRAY_BUFFER_BINDING: GLenum
    abstract EQUAL: GLenum
    abstract FASTEST: GLenum
    abstract FLOAT: GLenum
    abstract FLOAT_MAT2: GLenum
    abstract FLOAT_MAT3: GLenum
    abstract FLOAT_MAT4: GLenum
    abstract FLOAT_VEC2: GLenum
    abstract FLOAT_VEC3: GLenum
    abstract FLOAT_VEC4: GLenum
    abstract FRAGMENT_SHADER: GLenum
    abstract FRAMEBUFFER: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_OBJECT_NAME: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL: GLenum
    abstract FRAMEBUFFER_BINDING: GLenum
    abstract FRAMEBUFFER_COMPLETE: GLenum
    abstract FRAMEBUFFER_INCOMPLETE_ATTACHMENT: GLenum
    abstract FRAMEBUFFER_INCOMPLETE_DIMENSIONS: GLenum
    abstract FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT: GLenum
    abstract FRAMEBUFFER_UNSUPPORTED: GLenum
    abstract FRONT: GLenum
    abstract FRONT_AND_BACK: GLenum
    abstract FRONT_FACE: GLenum
    abstract FUNC_ADD: GLenum
    abstract FUNC_REVERSE_SUBTRACT: GLenum
    abstract FUNC_SUBTRACT: GLenum
    abstract GENERATE_MIPMAP_HINT: GLenum
    abstract GEQUAL: GLenum
    abstract GREATER: GLenum
    abstract GREEN_BITS: GLenum
    abstract HIGH_FLOAT: GLenum
    abstract HIGH_INT: GLenum
    abstract IMPLEMENTATION_COLOR_READ_FORMAT: GLenum
    abstract IMPLEMENTATION_COLOR_READ_TYPE: GLenum
    abstract INCR: GLenum
    abstract INCR_WRAP: GLenum
    abstract INT: GLenum
    abstract INT_VEC2: GLenum
    abstract INT_VEC3: GLenum
    abstract INT_VEC4: GLenum
    abstract INVALID_ENUM: GLenum
    abstract INVALID_FRAMEBUFFER_OPERATION: GLenum
    abstract INVALID_OPERATION: GLenum
    abstract INVALID_VALUE: GLenum
    abstract INVERT: GLenum
    abstract KEEP: GLenum
    abstract LEQUAL: GLenum
    abstract LESS: GLenum
    abstract LINEAR: GLenum
    abstract LINEAR_MIPMAP_LINEAR: GLenum
    abstract LINEAR_MIPMAP_NEAREST: GLenum
    abstract LINES: GLenum
    abstract LINE_LOOP: GLenum
    abstract LINE_STRIP: GLenum
    abstract LINE_WIDTH: GLenum
    abstract LINK_STATUS: GLenum
    abstract LOW_FLOAT: GLenum
    abstract LOW_INT: GLenum
    abstract LUMINANCE: GLenum
    abstract LUMINANCE_ALPHA: GLenum
    abstract MAX_COMBINED_TEXTURE_IMAGE_UNITS: GLenum
    abstract MAX_CUBE_MAP_TEXTURE_SIZE: GLenum
    abstract MAX_FRAGMENT_UNIFORM_VECTORS: GLenum
    abstract MAX_RENDERBUFFER_SIZE: GLenum
    abstract MAX_TEXTURE_IMAGE_UNITS: GLenum
    abstract MAX_TEXTURE_SIZE: GLenum
    abstract MAX_VARYING_VECTORS: GLenum
    abstract MAX_VERTEX_ATTRIBS: GLenum
    abstract MAX_VERTEX_TEXTURE_IMAGE_UNITS: GLenum
    abstract MAX_VERTEX_UNIFORM_VECTORS: GLenum
    abstract MAX_VIEWPORT_DIMS: GLenum
    abstract MEDIUM_FLOAT: GLenum
    abstract MEDIUM_INT: GLenum
    abstract MIRRORED_REPEAT: GLenum
    abstract NEAREST: GLenum
    abstract NEAREST_MIPMAP_LINEAR: GLenum
    abstract NEAREST_MIPMAP_NEAREST: GLenum
    abstract NEVER: GLenum
    abstract NICEST: GLenum
    abstract NONE: GLenum
    abstract NOTEQUAL: GLenum
    abstract NO_ERROR: GLenum
    abstract ONE: GLenum
    abstract ONE_MINUS_CONSTANT_ALPHA: GLenum
    abstract ONE_MINUS_CONSTANT_COLOR: GLenum
    abstract ONE_MINUS_DST_ALPHA: GLenum
    abstract ONE_MINUS_DST_COLOR: GLenum
    abstract ONE_MINUS_SRC_ALPHA: GLenum
    abstract ONE_MINUS_SRC_COLOR: GLenum
    abstract OUT_OF_MEMORY: GLenum
    abstract PACK_ALIGNMENT: GLenum
    abstract POINTS: GLenum
    abstract POLYGON_OFFSET_FACTOR: GLenum
    abstract POLYGON_OFFSET_FILL: GLenum
    abstract POLYGON_OFFSET_UNITS: GLenum
    abstract RED_BITS: GLenum
    abstract RENDERBUFFER: GLenum
    abstract RENDERBUFFER_ALPHA_SIZE: GLenum
    abstract RENDERBUFFER_BINDING: GLenum
    abstract RENDERBUFFER_BLUE_SIZE: GLenum
    abstract RENDERBUFFER_DEPTH_SIZE: GLenum
    abstract RENDERBUFFER_GREEN_SIZE: GLenum
    abstract RENDERBUFFER_HEIGHT: GLenum
    abstract RENDERBUFFER_INTERNAL_FORMAT: GLenum
    abstract RENDERBUFFER_RED_SIZE: GLenum
    abstract RENDERBUFFER_STENCIL_SIZE: GLenum
    abstract RENDERBUFFER_WIDTH: GLenum
    abstract RENDERER: GLenum
    abstract REPEAT: GLenum
    abstract REPLACE: GLenum
    abstract RGB: GLenum
    abstract RGB565: GLenum
    abstract RGB5_A1: GLenum
    abstract RGBA: GLenum
    abstract RGBA4: GLenum
    abstract SAMPLER_2D: GLenum
    abstract SAMPLER_CUBE: GLenum
    abstract SAMPLES: GLenum
    abstract SAMPLE_ALPHA_TO_COVERAGE: GLenum
    abstract SAMPLE_BUFFERS: GLenum
    abstract SAMPLE_COVERAGE: GLenum
    abstract SAMPLE_COVERAGE_INVERT: GLenum
    abstract SAMPLE_COVERAGE_VALUE: GLenum
    abstract SCISSOR_BOX: GLenum
    abstract SCISSOR_TEST: GLenum
    abstract SHADER_TYPE: GLenum
    abstract SHADING_LANGUAGE_VERSION: GLenum
    abstract SHORT: GLenum
    abstract SRC_ALPHA: GLenum
    abstract SRC_ALPHA_SATURATE: GLenum
    abstract SRC_COLOR: GLenum
    abstract STATIC_DRAW: GLenum
    abstract STENCIL_ATTACHMENT: GLenum
    abstract STENCIL_BACK_FAIL: GLenum
    abstract STENCIL_BACK_FUNC: GLenum
    abstract STENCIL_BACK_PASS_DEPTH_FAIL: GLenum
    abstract STENCIL_BACK_PASS_DEPTH_PASS: GLenum
    abstract STENCIL_BACK_REF: GLenum
    abstract STENCIL_BACK_VALUE_MASK: GLenum
    abstract STENCIL_BACK_WRITEMASK: GLenum
    abstract STENCIL_BITS: GLenum
    abstract STENCIL_BUFFER_BIT: GLenum
    abstract STENCIL_CLEAR_VALUE: GLenum
    abstract STENCIL_FAIL: GLenum
    abstract STENCIL_FUNC: GLenum
    abstract STENCIL_INDEX8: GLenum
    abstract STENCIL_PASS_DEPTH_FAIL: GLenum
    abstract STENCIL_PASS_DEPTH_PASS: GLenum
    abstract STENCIL_REF: GLenum
    abstract STENCIL_TEST: GLenum
    abstract STENCIL_VALUE_MASK: GLenum
    abstract STENCIL_WRITEMASK: GLenum
    abstract STREAM_DRAW: GLenum
    abstract SUBPIXEL_BITS: GLenum
    abstract TEXTURE: GLenum
    abstract TEXTURE0: GLenum
    abstract TEXTURE1: GLenum
    abstract TEXTURE10: GLenum
    abstract TEXTURE11: GLenum
    abstract TEXTURE12: GLenum
    abstract TEXTURE13: GLenum
    abstract TEXTURE14: GLenum
    abstract TEXTURE15: GLenum
    abstract TEXTURE16: GLenum
    abstract TEXTURE17: GLenum
    abstract TEXTURE18: GLenum
    abstract TEXTURE19: GLenum
    abstract TEXTURE2: GLenum
    abstract TEXTURE20: GLenum
    abstract TEXTURE21: GLenum
    abstract TEXTURE22: GLenum
    abstract TEXTURE23: GLenum
    abstract TEXTURE24: GLenum
    abstract TEXTURE25: GLenum
    abstract TEXTURE26: GLenum
    abstract TEXTURE27: GLenum
    abstract TEXTURE28: GLenum
    abstract TEXTURE29: GLenum
    abstract TEXTURE3: GLenum
    abstract TEXTURE30: GLenum
    abstract TEXTURE31: GLenum
    abstract TEXTURE4: GLenum
    abstract TEXTURE5: GLenum
    abstract TEXTURE6: GLenum
    abstract TEXTURE7: GLenum
    abstract TEXTURE8: GLenum
    abstract TEXTURE9: GLenum
    abstract TEXTURE_2D: GLenum
    abstract TEXTURE_BINDING_2D: GLenum
    abstract TEXTURE_BINDING_CUBE_MAP: GLenum
    abstract TEXTURE_CUBE_MAP: GLenum
    abstract TEXTURE_CUBE_MAP_NEGATIVE_X: GLenum
    abstract TEXTURE_CUBE_MAP_NEGATIVE_Y: GLenum
    abstract TEXTURE_CUBE_MAP_NEGATIVE_Z: GLenum
    abstract TEXTURE_CUBE_MAP_POSITIVE_X: GLenum
    abstract TEXTURE_CUBE_MAP_POSITIVE_Y: GLenum
    abstract TEXTURE_CUBE_MAP_POSITIVE_Z: GLenum
    abstract TEXTURE_MAG_FILTER: GLenum
    abstract TEXTURE_MIN_FILTER: GLenum
    abstract TEXTURE_WRAP_S: GLenum
    abstract TEXTURE_WRAP_T: GLenum
    abstract TRIANGLES: GLenum
    abstract TRIANGLE_FAN: GLenum
    abstract TRIANGLE_STRIP: GLenum
    abstract UNPACK_ALIGNMENT: GLenum
    abstract UNPACK_COLORSPACE_CONVERSION_WEBGL: GLenum
    abstract UNPACK_FLIP_Y_WEBGL: GLenum
    abstract UNPACK_PREMULTIPLY_ALPHA_WEBGL: GLenum
    abstract UNSIGNED_BYTE: GLenum
    abstract UNSIGNED_INT: GLenum
    abstract UNSIGNED_SHORT: GLenum
    abstract UNSIGNED_SHORT_4_4_4_4: GLenum
    abstract UNSIGNED_SHORT_5_5_5_1: GLenum
    abstract UNSIGNED_SHORT_5_6_5: GLenum
    abstract VALIDATE_STATUS: GLenum
    abstract VENDOR: GLenum
    abstract VERSION: GLenum
    abstract VERTEX_ATTRIB_ARRAY_BUFFER_BINDING: GLenum
    abstract VERTEX_ATTRIB_ARRAY_ENABLED: GLenum
    abstract VERTEX_ATTRIB_ARRAY_NORMALIZED: GLenum
    abstract VERTEX_ATTRIB_ARRAY_POINTER: GLenum
    abstract VERTEX_ATTRIB_ARRAY_SIZE: GLenum
    abstract VERTEX_ATTRIB_ARRAY_STRIDE: GLenum
    abstract VERTEX_ATTRIB_ARRAY_TYPE: GLenum
    abstract VERTEX_SHADER: GLenum
    abstract VIEWPORT: GLenum
    abstract ZERO: GLenum

type [<AllowNullLiteral>] WebGLSamplerType =
    abstract prototype: WebGLSampler with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] WebGLShaderType =
    abstract prototype: WebGLShader with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] WebGLShaderPrecisionFormatType =
    abstract prototype: WebGLShaderPrecisionFormat with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] WebGLSyncType =
    abstract prototype: WebGLSync with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] WebGLTextureType =
    abstract prototype: WebGLTexture with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] WebGLTransformFeedbackType =
    abstract prototype: WebGLTransformFeedback with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] WebGLUniformLocationType =
    abstract prototype: WebGLUniformLocation with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] WebGLVertexArrayObjectType =
    abstract prototype: WebGLVertexArrayObject with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj
