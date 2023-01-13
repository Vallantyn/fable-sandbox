// ts2fable 0.7.1
namespace WebGL2.Base

open System
open Fable.Core
open Fable.Core.JS

open WebGL.Types

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
    // abstract texImage3D: target: GLenum * level: GLint * internalformat: GLint * width: GLsizei * height: GLsizei * depth: GLsizei * border: GLint * format: GLenum * ``type``: GLenum * source: TexImageSource -> unit
    abstract texImage3D: target: GLenum * level: GLint * internalformat: GLint * width: GLsizei * height: GLsizei * depth: GLsizei * border: GLint * format: GLenum * ``type``: GLenum * srcData: ArrayBufferView option -> unit
    abstract texImage3D: target: GLenum * level: GLint * internalformat: GLint * width: GLsizei * height: GLsizei * depth: GLsizei * border: GLint * format: GLenum * ``type``: GLenum * srcData: ArrayBufferView * srcOffset: GLuint -> unit
    abstract texStorage2D: target: GLenum * levels: GLsizei * internalformat: GLenum * width: GLsizei * height: GLsizei -> unit
    abstract texStorage3D: target: GLenum * levels: GLsizei * internalformat: GLenum * width: GLsizei * height: GLsizei * depth: GLsizei -> unit
    abstract texSubImage3D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * zoffset: GLint * width: GLsizei * height: GLsizei * depth: GLsizei * format: GLenum * ``type``: GLenum * pboOffset: GLintptr -> unit
    // abstract texSubImage3D: target: GLenum * level: GLint * xoffset: GLint * yoffset: GLint * zoffset: GLint * width: GLsizei * height: GLsizei * depth: GLsizei * format: GLenum * ``type``: GLenum * source: TexImageSource -> unit
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
