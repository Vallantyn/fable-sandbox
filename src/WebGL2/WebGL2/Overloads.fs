// ts2fable 0.7.1
namespace WebGL2.Overloads

open System
open Fable.Core
open Fable.Core.JS

open HTML.Types
open WebGL.Types

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
    // abstract texImage2D: target: GLenum * level: GLint * internalformat: GLint * format: GLenum * ``type``: GLenum * source: TexImageSource -> unit
    abstract texImage2D: target: GLenum * level: GLint * internalformat: GLint * width: GLsizei * height: GLsizei * border: GLint * format: GLenum * ``type``: GLenum * pboOffset: GLintptr -> unit
    // abstract texImage2D: target: GLenum * level: GLint * internalformat: GLint * width: GLsizei * height: GLsizei * border: GLint * format: GLenum * ``type``: GLenum * source: TexImageSource -> unit
    abstract texImage2D: target: GLenum * level: GLint * internalformat: GLint * width: GLsizei * height: GLsizei * border: GLint * format: GLenum * ``type``: GLenum * srcData: ArrayBufferView * srcOffset: GLuint -> unit
    abstract texSubImage2D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * width: GLsizei * height: GLsizei * format: GLenum * ``type``: GLenum * pixels: ArrayBufferView option -> unit
    // abstract texSubImage2D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * format: GLenum * ``type``: GLenum * source: TexImageSource -> unit
    abstract texSubImage2D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * width: GLsizei * height: GLsizei * format: GLenum * ``type``: GLenum * pboOffset: GLintptr -> unit
    // abstract texSubImage2D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * width: GLsizei * height: GLsizei * format: GLenum * ``type``: GLenum * source: TexImageSource -> unit
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
