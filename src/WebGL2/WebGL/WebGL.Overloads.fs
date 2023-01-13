// ts2fable 0.7.1
namespace WebGL.Overloads

open Fable.Core.JS

open HTML.Types
open WebGL.Types

type [<AllowNullLiteral>] WebGLRenderingContextOverloads =
    abstract bufferData: target: GLenum * size: GLsizeiptr * usage: GLenum -> unit
    abstract bufferData: target: GLenum * data: BufferSource option * usage: GLenum -> unit
    abstract bufferSubData: target: GLenum * offset: GLintptr * data: BufferSource -> unit
    abstract compressedTexImage2D: target: GLenum * level: GLint * internalformat: GLenum * width: GLsizei * height: GLsizei * border: GLint * data: ArrayBufferView -> unit
    abstract compressedTexSubImage2D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * width: GLsizei * height: GLsizei * format: GLenum * data: ArrayBufferView -> unit
    abstract readPixels: x: GLint * y: GLint * width: GLsizei * height: GLsizei * format: GLenum * ``type``: GLenum * pixels: ArrayBufferView option -> unit
    abstract texImage2D: target: GLenum * level: GLint * internalformat: GLint * width: GLsizei * height: GLsizei * border: GLint * format: GLenum * ``type``: GLenum * pixels: ArrayBufferView option -> unit
    // abstract texImage2D: target: GLenum * level: GLint * internalformat: GLint * format: GLenum * ``type``: GLenum * source: TexImageSource -> unit
    abstract texSubImage2D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * width: GLsizei * height: GLsizei * format: GLenum * ``type``: GLenum * pixels: ArrayBufferView option -> unit
    // abstract texSubImage2D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * format: GLenum * ``type``: GLenum * source: TexImageSource -> unit
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
