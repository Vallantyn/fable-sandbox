namespace Browser.Types

open System
open Fable.Core
open Fable.Core.JS

type [<AllowNullLiteral>] WebGLContextAttributes =
    abstract alpha: bool option with get, set
    abstract depth: bool option with get, set
    abstract stencil: bool option with get, set
    abstract antialias: bool option with get, set
    abstract premultipliedAlpha: bool option with get, set
    abstract preserveDrawingBuffer: bool option with get, set

type [<AllowNullLiteral>] WebGLContextEventInit =
    inherit EventInit
    abstract statusMessage: string option with get, set

type [<AllowNullLiteral; Global>] WebGLObject =
    interface end

type [<AllowNullLiteral>] WebGLObjectType =
    abstract prototype: WebGLObject with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLObject

type [<AllowNullLiteral; Global>] WEBGL_compressed_texture_s3tc =
    abstract COMPRESSED_RGBA_S3TC_DXT1_EXT: float with get, set
    abstract COMPRESSED_RGBA_S3TC_DXT3_EXT: float with get, set
    abstract COMPRESSED_RGBA_S3TC_DXT5_EXT: float with get, set
    abstract COMPRESSED_RGB_S3TC_DXT1_EXT: float with get, set

type [<AllowNullLiteral>] WEBGL_compressed_texture_s3tcType =
    abstract prototype: WEBGL_compressed_texture_s3tc with get, set
    abstract COMPRESSED_RGBA_S3TC_DXT1_EXT: float with get, set
    abstract COMPRESSED_RGBA_S3TC_DXT3_EXT: float with get, set
    abstract COMPRESSED_RGBA_S3TC_DXT5_EXT: float with get, set
    abstract COMPRESSED_RGB_S3TC_DXT1_EXT: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WEBGL_compressed_texture_s3tc

type [<AllowNullLiteral; Global>] WEBGL_debug_renderer_info =
    abstract UNMASKED_RENDERER_WEBGL: float with get, set
    abstract UNMASKED_VENDOR_WEBGL: float with get, set

type [<AllowNullLiteral>] WEBGL_debug_renderer_infoType =
    abstract prototype: WEBGL_debug_renderer_info with get, set
    abstract UNMASKED_RENDERER_WEBGL: float with get, set
    abstract UNMASKED_VENDOR_WEBGL: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WEBGL_debug_renderer_info

type [<AllowNullLiteral; Global>] WEBGL_depth_texture =
    abstract UNSIGNED_INT_24_8_WEBGL: float with get, set

type [<AllowNullLiteral>] WEBGL_depth_textureType =
    abstract prototype: WEBGL_depth_texture with get, set
    abstract UNSIGNED_INT_24_8_WEBGL: float with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WEBGL_depth_texture

type [<AllowNullLiteral; Global>] WebGLActiveInfo =
    abstract name: string with get, set
    abstract size: float with get, set
    abstract ``type``: float with get, set

type [<AllowNullLiteral>] WebGLActiveInfoType =
    abstract prototype: WebGLActiveInfo with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLActiveInfo

type [<AllowNullLiteral; Global>] WebGLBuffer =
    inherit WebGLObject

type [<AllowNullLiteral>] WebGLBufferType =
    abstract prototype: WebGLBuffer with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLBuffer

type [<AllowNullLiteral; Global>] WebGLContextEvent =
    inherit Event
    abstract statusMessage: string with get, set

type [<AllowNullLiteral>] WebGLContextEventType =
    abstract prototype: WebGLContextEvent with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLContextEvent

type [<AllowNullLiteral; Global>] WebGLFramebuffer =
    inherit WebGLObject


type [<AllowNullLiteral>] WebGLFramebufferType =
    abstract prototype: WebGLFramebuffer with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLFramebuffer

type [<AllowNullLiteral; Global>] WebGLProgram =
    inherit WebGLObject

type [<AllowNullLiteral>] WebGLProgramType =
    abstract prototype: WebGLProgram with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLProgram

type [<AllowNullLiteral; Global>] WebGLRenderbuffer =
    inherit WebGLObject

type [<AllowNullLiteral>] WebGLRenderbufferType =
    abstract prototype: WebGLRenderbuffer with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLRenderbuffer

type [<AllowNullLiteral; Global>] WebGLShader =
    inherit WebGLObject

type [<AllowNullLiteral>] WebGLShaderType =
    abstract prototype: WebGLShader with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLShader

type [<AllowNullLiteral; Global>] WebGLShaderPrecisionFormat =
    abstract precision: float with get, set
    abstract rangeMax: float with get, set
    abstract rangeMin: float with get, set

type [<AllowNullLiteral>] WebGLShaderPrecisionFormatType =
    abstract prototype: WebGLShaderPrecisionFormat with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLShaderPrecisionFormat

type [<AllowNullLiteral; Global>] WebGLTexture =
    inherit WebGLObject

type [<AllowNullLiteral>] WebGLTextureType =
    abstract prototype: WebGLTexture with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLTexture

type [<AllowNullLiteral; Global>] WebGLVertexArray =
    inherit WebGLObject
    
type [<AllowNullLiteral; Global>] WebGLVertexArrayType =
    abstract prototype: WebGLVertexArray with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLVertexArray

type [<AllowNullLiteral; Global>] WebGLUniformLocation =
    interface end

type [<AllowNullLiteral>] WebGLUniformLocationType =
    abstract prototype: WebGLUniformLocation with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGLUniformLocation

type [<AllowNullLiteral; Global>] WebGL2RenderingContext =
    inherit WebGLRenderingContext
    abstract createVertexArray: unit -> WebGLVertexArray
    abstract bindVertexArray: WebGLVertexArray -> unit

type [<AllowNullLiteral>] WebGL2RenderingContextType =
    inherit WebGLRenderingContextType
    abstract prototype: WebGL2RenderingContext with get, set
    [<Emit("new $0($1...)")>] abstract Create: unit -> WebGL2RenderingContext

namespace Browser

open Browser.Types
open Fable.Core

[<AutoOpen>]
module WebGL =

    type HTMLCanvasElement with
        [<Emit("$0.getContext('webgl2')")>]
        member __.getContext_webgl2(): WebGL2RenderingContext = jsNative

    let [<Global>] WebGL2RenderingContext: WebGL2RenderingContextType = jsNative