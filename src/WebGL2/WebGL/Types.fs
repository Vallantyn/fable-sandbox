// ts2fable 0.7.1
namespace WebGL.Types

open Fable.Core
open Fable.Core.JS

// let [<Import("WebGLActiveInfoType","webgl/types")>] WebGLActiveInfoType: WebGLActiveInfoType = jsNative
// let [<Import("WebGLBufferType","webgl/types")>] WebGLBufferType: WebGLBufferType = jsNative
// // let [<Import("WebGLContextEventType","webgl/types")>] WebGLContextEventType: WebGLContextEventType = jsNative
// let [<Import("WebGLFramebufferType","webgl/types")>] WebGLFramebufferType: WebGLFramebufferType = jsNative
// let [<Import("WebGLProgramType","webgl/types")>] WebGLProgramType: WebGLProgramType = jsNative
// let [<Import("WebGLQueryType","webgl/types")>] WebGLQueryType: WebGLQueryType = jsNative
// let [<Import("WebGLRenderbufferType","webgl/types")>] WebGLRenderbufferType: WebGLRenderbufferType = jsNative
// let [<Import("WebGLSamplerType","webgl/types")>] WebGLSamplerType: WebGLSamplerType = jsNative
// let [<Import("WebGLShaderType","webgl/types")>] WebGLShaderType: WebGLShaderType = jsNative
// let [<Import("WebGLShaderPrecisionFormatType","webgl/types")>] WebGLShaderPrecisionFormatType: WebGLShaderPrecisionFormatType = jsNative
// let [<Import("WebGLSyncType","webgl/types")>] WebGLSyncType: WebGLSyncType = jsNative
// let [<Import("WebGLTextureType","webgl/types")>] WebGLTextureType: WebGLTextureType = jsNative
// let [<Import("WebGLTransformFeedbackType","webgl/types")>] WebGLTransformFeedbackType: WebGLTransformFeedbackType = jsNative
// let [<Import("WebGLUniformLocationType","webgl/types")>] WebGLUniformLocationType: WebGLUniformLocationType = jsNative
// let [<Import("WebGLVertexArrayObjectType","webgl/types")>] WebGLVertexArrayObjectType: WebGLVertexArrayObjectType = jsNative

module GL =
    /// Used for enums.
    [<CompiledName("GLenum")>]
    type Enum = uint32
    /// A boolean value.
    [<CompiledName("GLboolean")>]
    type Boolean = bool
    /// A bit field that stores multiple, logical bits.
    [<CompiledName("GLbitfield")>]
    type Bitfield = uint32
    /// 8-bit twos complement signed integer.
    [<CompiledName("GLbyte")>]
    type Byte = int8
    /// 8-bit twos complement unsigned integer.
    [<CompiledName("GLubyte")>]
    type UByte = uint8
    /// 16-bit twos complement signed integer.
    [<CompiledName("GLshort")>]
    type Short = int16
    /// 16-bit twos complement unsigned integer.
    [<CompiledName("GLushort")>]
    type UShort = uint16
    /// 32-bit twos complement signed integer.
    [<CompiledName("GLint")>]
    type Int = int32
    /// 32-bit twos complement unsigned integer.
    [<CompiledName("GLuint")>]
    type UInt = uint32
    /// 32-bit IEEE floating point number.
    [<CompiledName("GLfloat")>]
    type Float = float
    /// Clamped 32-bit IEEE floating point number.
    [<CompiledName("GLclampf")>]
    type Clampf = float
    /// Used for sizes (e.g. `width` and `height` of the drawing buffer).
    [<CompiledName("GLsizei")>]
    type Sizei = int32
    /// Special type for pointer arithmetic.
    [<CompiledName("GLintptr")>]
    type IntPtr = int64
    /// Special type for pointer arithmetic.
    [<CompiledName("GLsizeiptr")>]
    type SizeiPtr = int64

    /// Signed 64-bit integer number.
    [<CompiledName("GLint64")>]
    type Int64 = int64
    /// Unsigned 64-bit integer number.
    [<CompiledName("GLuint64")>]
    type UInt64 = uint64
    /// Unsigned 64-bit integer number.
    [<CompiledName("GLuint64EXT")>]
    type UInt64EXT = uint64

type Int32List = U2<Int32Array, ResizeArray<GL.Int>>
type Uint32List = U2<Uint32Array, ResizeArray<GL.UInt>>
type Float32List = U2<Float32Array, ResizeArray<GL.Float>>

/// Part of the WebGL API and represents the information returned by calling the WebGLRenderingContext.getActiveAttrib() and WebGLRenderingContext.getActiveUniform() methods.
type [<AllowNullLiteral>] WebGLActiveInfo =
    abstract name: string
    abstract size: GL.Int
    abstract ``type``: GL.Enum

/// Part of the WebGL API and represents an opaque buffer object storing data such as vertices or colors.
type [<AllowNullLiteral>] WebGLBuffer =
    interface end

/// The WebContextEvent interface is part of the WebGL API and is an interface for an event that is generated in response to a status change to the WebGL rendering context.
type [<AllowNullLiteral>] WebGLContextEvent =
    // inherit Event
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

type [<AllowNullLiteral>] WebGLSampler =
    interface end

/// The WebGLShader is part of the WebGL API and can either be a vertex or a fragment shader. A WebGLProgram requires both types of shaders.
type [<AllowNullLiteral>] WebGLShader =
    interface end

/// Part of the WebGL API and represents the information returned by calling the WebGLRenderingContext.getShaderPrecisionFormat() method.
type [<AllowNullLiteral>] WebGLShaderPrecisionFormat =
    abstract precision: GL.Int
    abstract rangeMax: GL.Int
    abstract rangeMin: GL.Int

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

type [<AllowNullLiteral>] WebGLActiveInfoType =
    abstract prototype: WebGLActiveInfo with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

type [<AllowNullLiteral>] WebGLBufferType =
    abstract prototype: WebGLBuffer with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj

// type [<AllowNullLiteral>] WebGLContextEventType =
//     abstract prototype: WebGLContextEvent with get, set
//     [<Emit "new $0($1...)">] abstract Create: ``type``: string * ?eventInit: WebGLContextEventInit -> obj

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

namespace WebGL

open Fable.Core
open WebGL.Types

[<AutoOpen>]
module WebGL =
    let [<Global>] WebGLActiveInfo: WebGLActiveInfoType = jsNative
    let [<Global>] WebGLBuffer: WebGLBufferType = jsNative
    // let [<Import("WebGLContextEventType","webgl/types")>] WebGLContextEventType: WebGLContextEventType = jsNative
    let [<Global>] WebGLFramebuffer: WebGLFramebufferType = jsNative
    let [<Global>] WebGLProgram: WebGLProgramType = jsNative
    let [<Global>] WebGLQuery: WebGLQueryType = jsNative
    let [<Global>] WebGLRenderbuffer: WebGLRenderbufferType = jsNative
    let [<Global>] WebGLSampler: WebGLSamplerType = jsNative
    let [<Global>] WebGLShader: WebGLShaderType = jsNative
    let [<Global>] WebGLShaderPrecisionFormat: WebGLShaderPrecisionFormatType = jsNative
    let [<Global>] WebGLSync: WebGLSyncType = jsNative
    let [<Global>] WebGLTexture: WebGLTextureType = jsNative
    let [<Global>] WebGLTransformFeedback: WebGLTransformFeedbackType = jsNative
    let [<Global>] WebGLUniformLocation: WebGLUniformLocationType = jsNative
    let [<Global>] WebGLVertexArrayObject: WebGLVertexArrayObjectType = jsNative
