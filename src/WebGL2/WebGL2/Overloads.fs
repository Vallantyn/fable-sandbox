// ts2fable 0.7.1
namespace WebGL2.RenderingContext

open Fable.Core.JS

open HTML.Types
open WebGL.Types

type TypedArray =
| Int32Array of int array
| UInt32Array of uint array
| Float32Array of single array
| Float64Array of float array

[<AllowNullLiteral; CompiledName("WebGL2RenderingContextOverloads")>]
type Overloads =
    abstract bufferData: target: GL.Enum * size: GL.SizeiPtr * usage: GL.Enum -> unit
    abstract bufferData: target: GL.Enum * data:'T array * usage: GL.Enum -> unit
    abstract bufferData: target: GL.Enum * srcData:'T array * usage: GL.Enum * srcOffset: GL.UInt * ?length: GL.UInt -> unit
    abstract bufferSubData: target: GL.Enum * dstByteOffset: GL.IntPtr * srcData: BufferSource -> unit
    abstract bufferSubData: target: GL.Enum * dstByteOffset: GL.IntPtr * srcData: ArrayBufferView * srcOffset: GL.UInt * ?length: GL.UInt -> unit
    abstract compressedTexImage2D: target: GL.Enum * level: GL.Int * internalformat: GL.Enum * width: GL.Sizei * height: GL.Sizei * border: GL.Int * imageSize: GL.Sizei * offset: GL.IntPtr -> unit
    abstract compressedTexImage2D: target: GL.Enum * level: GL.Int * internalformat: GL.Enum * width: GL.Sizei * height: GL.Sizei * border: GL.Int * srcData: ArrayBufferView * ?srcOffset: GL.UInt * ?srcLengthOverride: GL.UInt -> unit
    abstract compressedTexSubImage2D: target: GL.Enum * level: GL.Int * xoffset: GL.Int * yoffset: GL.Int * width: GL.Sizei * height: GL.Sizei * format: GL.Enum * imageSize: GL.Sizei * offset: GL.IntPtr -> unit
    abstract compressedTexSubImage2D: target: GL.Enum * level: GL.Int * xoffset: GL.Int * yoffset: GL.Int * width: GL.Sizei * height: GL.Sizei * format: GL.Enum * srcData: ArrayBufferView * ?srcOffset: GL.UInt * ?srcLengthOverride: GL.UInt -> unit
    abstract readPixels: x: GL.Int * y: GL.Int * width: GL.Sizei * height: GL.Sizei * format: GL.Enum * ``type``: GL.Enum * dstData: ArrayBufferView option -> unit
    abstract readPixels: x: GL.Int * y: GL.Int * width: GL.Sizei * height: GL.Sizei * format: GL.Enum * ``type``: GL.Enum * offset: GL.IntPtr -> unit
    abstract readPixels: x: GL.Int * y: GL.Int * width: GL.Sizei * height: GL.Sizei * format: GL.Enum * ``type``: GL.Enum * dstData: ArrayBufferView * dstOffset: GL.UInt -> unit
    abstract texImage2D: target: GL.Enum * level: GL.Int * internalformat: GL.Int * width: GL.Sizei * height: GL.Sizei * border: GL.Int * format: GL.Enum * ``type``: GL.Enum * pixels: ArrayBufferView option -> unit
    // abstract texImage2D: target: GL.Enum * level: GL.Int * internalformat: GL.Int * format: GL.Enum * ``type``: GL.Enum * source: TexImageSource -> unit
    abstract texImage2D: target: GL.Enum * level: GL.Int * internalformat: GL.Int * width: GL.Sizei * height: GL.Sizei * border: GL.Int * format: GL.Enum * ``type``: GL.Enum * pboOffset: GL.IntPtr -> unit
    // abstract texImage2D: target: GL.Enum * level: GL.Int * internalformat: GL.Int * width: GL.Sizei * height: GL.Sizei * border: GL.Int * format: GL.Enum * ``type``: GL.Enum * source: TexImageSource -> unit
    abstract texImage2D: target: GL.Enum * level: GL.Int * internalformat: GL.Int * width: GL.Sizei * height: GL.Sizei * border: GL.Int * format: GL.Enum * ``type``: GL.Enum * srcData: ArrayBufferView * srcOffset: GL.UInt -> unit
    abstract texSubImage2D: target: GL.Enum * level: GL.Int * xoffset: GL.Int * yoffset: GL.Int * width: GL.Sizei * height: GL.Sizei * format: GL.Enum * ``type``: GL.Enum * pixels: ArrayBufferView option -> unit
    // abstract texSubImage2D: target: GL.Enum * level: GL.Int * xoffset: GL.Int * yoffset: GL.Int * format: GL.Enum * ``type``: GL.Enum * source: TexImageSource -> unit
    abstract texSubImage2D: target: GL.Enum * level: GL.Int * xoffset: GL.Int * yoffset: GL.Int * width: GL.Sizei * height: GL.Sizei * format: GL.Enum * ``type``: GL.Enum * pboOffset: GL.IntPtr -> unit
    // abstract texSubImage2D: target: GL.Enum * level: GL.Int * xoffset: GL.Int * yoffset: GL.Int * width: GL.Sizei * height: GL.Sizei * format: GL.Enum * ``type``: GL.Enum * source: TexImageSource -> unit
    abstract texSubImage2D: target: GL.Enum * level: GL.Int * xoffset: GL.Int * yoffset: GL.Int * width: GL.Sizei * height: GL.Sizei * format: GL.Enum * ``type``: GL.Enum * srcData: ArrayBufferView * srcOffset: GL.UInt -> unit
    abstract uniform1fv: location: WebGLUniformLocation option * data: Float32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniform1iv: location: WebGLUniformLocation option * data: Int32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniform2fv: location: WebGLUniformLocation option * data: Float32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniform2iv: location: WebGLUniformLocation option * data: Int32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniform3fv: location: WebGLUniformLocation option * data: Float32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniform3iv: location: WebGLUniformLocation option * data: Int32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniform4fv: location: WebGLUniformLocation option * data: Float32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniform4iv: location: WebGLUniformLocation option * data: Int32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniformMatrix2fv: location: WebGLUniformLocation option * transpose: GL.Boolean * data: Float32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniformMatrix3fv: location: WebGLUniformLocation option * transpose: GL.Boolean * data: Float32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniformMatrix4fv: location: WebGLUniformLocation option * transpose: GL.Boolean * data: Float32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
