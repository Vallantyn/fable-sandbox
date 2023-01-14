// ts2fable 0.7.1
namespace WebGL.RenderingContext

open Fable.Core.JS

open HTML.Types
open WebGL.Types

[<AllowNullLiteral; CompiledName("WebGLRenderingContextOverloads")>]
type Overloads =
    abstract bufferData: target: GL.Enum * size: GL.SizeiPtr * usage: GL.Enum -> unit
    abstract bufferData: target: GL.Enum * data: int array * usage: GL.Enum -> unit
    abstract bufferData: target: GL.Enum * data: uint array * usage: GL.Enum -> unit
    abstract bufferData: target: GL.Enum * data: single array * usage: GL.Enum -> unit
    abstract bufferSubData: target: GL.Enum * offset: GL.IntPtr * data: BufferSource -> unit
    abstract compressedTexImage2D: target: GL.Enum * level: GL.Int * internalformat: GL.Enum * width: GL.Sizei * height: GL.Sizei * border: GL.Int * data: ArrayBufferView -> unit
    abstract compressedTexSubImage2D: target: GL.Enum * level: GL.Int * xoffset: GL.Int * yoffset: GL.Int * width: GL.Sizei * height: GL.Sizei * format: GL.Enum * data: ArrayBufferView -> unit
    abstract readPixels: x: GL.Int * y: GL.Int * width: GL.Sizei * height: GL.Sizei * format: GL.Enum * ``type``: GL.Enum * pixels: ArrayBufferView option -> unit
    abstract texImage2D: target: GL.Enum * level: GL.Int * internalformat: GL.Int * width: GL.Sizei * height: GL.Sizei * border: GL.Int * format: GL.Enum * ``type``: GL.Enum * pixels: ArrayBufferView option -> unit
    // abstract texImage2D: target: GL.Enum * level: GL.Int * internalformat: GL.Int * format: GL.Enum * ``type``: GL.Enum * source: TexImageSource -> unit
    abstract texSubImage2D: target: GL.Enum * level: GL.Int * xoffset: GL.Int * yoffset: GL.Int * width: GL.Sizei * height: GL.Sizei * format: GL.Enum * ``type``: GL.Enum * pixels: ArrayBufferView option -> unit
    // abstract texSubImage2D: target: GL.Enum * level: GL.Int * xoffset: GL.Int * yoffset: GL.Int * format: GL.Enum * ``type``: GL.Enum * source: TexImageSource -> unit
    abstract uniform1fv: location: WebGLUniformLocation option * v: Float32List -> unit
    abstract uniform1iv: location: WebGLUniformLocation option * v: Int32List -> unit
    abstract uniform2fv: location: WebGLUniformLocation option * v: Float32List -> unit
    abstract uniform2iv: location: WebGLUniformLocation option * v: Int32List -> unit
    abstract uniform3fv: location: WebGLUniformLocation option * v: Float32List -> unit
    abstract uniform3iv: location: WebGLUniformLocation option * v: Int32List -> unit
    abstract uniform4fv: location: WebGLUniformLocation option * v: Float32List -> unit
    abstract uniform4iv: location: WebGLUniformLocation option * v: Int32List -> unit
    abstract uniformMatrix2fv: location: WebGLUniformLocation option * transpose: GL.Boolean * value: Float32List -> unit
    abstract uniformMatrix3fv: location: WebGLUniformLocation option * transpose: GL.Boolean * value: Float32List -> unit
    abstract uniformMatrix4fv: location: WebGLUniformLocation option * transpose: GL.Boolean * value: Float32List -> unit
