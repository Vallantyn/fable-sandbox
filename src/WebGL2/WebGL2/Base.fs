// ts2fable 0.7.1
namespace WebGL2.RenderingContext

open Fable.Core.JS

open WebGL.Types

[<AllowNullLiteral; CompiledName("WebGL2RenderingContextBase")>]
type Base =
    abstract beginQuery: target: GL.Enum * query: WebGLQuery -> unit
    abstract beginTransformFeedback: primitiveMode: GL.Enum -> unit
    abstract bindBufferBase: target: GL.Enum * index: GL.UInt * buffer: WebGLBuffer option -> unit
    abstract bindBufferRange: target: GL.Enum * index: GL.UInt * buffer: WebGLBuffer option * offset: GL.IntPtr * size: GL.SizeiPtr -> unit
    abstract bindSampler: unit: GL.UInt * sampler: WebGLSampler option -> unit
    abstract bindTransformFeedback: target: GL.Enum * tf: WebGLTransformFeedback option -> unit
    abstract bindVertexArray: array: WebGLVertexArrayObject option -> unit
    abstract blitFramebuffer: srcX0: GL.Int * srcY0: GL.Int * srcX1: GL.Int * srcY1: GL.Int * dstX0: GL.Int * dstY0: GL.Int * dstX1: GL.Int * dstY1: GL.Int * mask: GL.Bitfield * filter: GL.Enum -> unit
    abstract clearBufferfi: buffer: GL.Enum * drawbuffer: GL.Int * depth: GL.Float * stencil: GL.Int -> unit
    abstract clearBufferfv: buffer: GL.Enum * drawbuffer: GL.Int * values: Float32List * ?srcOffset: GL.UInt -> unit
    abstract clearBufferiv: buffer: GL.Enum * drawbuffer: GL.Int * values: Int32List * ?srcOffset: GL.UInt -> unit
    abstract clearBufferuiv: buffer: GL.Enum * drawbuffer: GL.Int * values: Uint32List * ?srcOffset: GL.UInt -> unit
    abstract clientWaitSync: sync: WebGLSync * flags: GL.Bitfield * timeout: GL.UInt64 -> GL.Enum
    abstract compressedTexImage3D: target: GL.Enum * level: GL.Int * internalformat: GL.Enum * width: GL.Sizei * height: GL.Sizei * depth: GL.Sizei * border: GL.Int * imageSize: GL.Sizei * offset: GL.IntPtr -> unit
    abstract compressedTexImage3D: target: GL.Enum * level: GL.Int * internalformat: GL.Enum * width: GL.Sizei * height: GL.Sizei * depth: GL.Sizei * border: GL.Int * srcData: ArrayBufferView * ?srcOffset: GL.UInt * ?srcLengthOverride: GL.UInt -> unit
    abstract compressedTexSubImage3D: target: GL.Enum * level: GL.Int * xoffset: GL.Int * yoffset: GL.Int * zoffset: GL.Int * width: GL.Sizei * height: GL.Sizei * depth: GL.Sizei * format: GL.Enum * imageSize: GL.Sizei * offset: GL.IntPtr -> unit
    abstract compressedTexSubImage3D: target: GL.Enum * level: GL.Int * xoffset: GL.Int * yoffset: GL.Int * zoffset: GL.Int * width: GL.Sizei * height: GL.Sizei * depth: GL.Sizei * format: GL.Enum * srcData: ArrayBufferView * ?srcOffset: GL.UInt * ?srcLengthOverride: GL.UInt -> unit
    abstract copyBufferSubData: readTarget: GL.Enum * writeTarget: GL.Enum * readOffset: GL.IntPtr * writeOffset: GL.IntPtr * size: GL.SizeiPtr -> unit
    abstract copyTexSubImage3D: target: GL.Enum * level: GL.Int * xoffset: GL.Int * yoffset: GL.Int * zoffset: GL.Int * x: GL.Int * y: GL.Int * width: GL.Sizei * height: GL.Sizei -> unit
    abstract createQuery: unit -> WebGLQuery option
    abstract createSampler: unit -> WebGLSampler option
    abstract createTransformFeedback: unit -> WebGLTransformFeedback option
    abstract createVertexArray: unit -> WebGLVertexArrayObject option
    abstract deleteQuery: query: WebGLQuery option -> unit
    abstract deleteSampler: sampler: WebGLSampler option -> unit
    abstract deleteSync: sync: WebGLSync option -> unit
    abstract deleteTransformFeedback: tf: WebGLTransformFeedback option -> unit
    abstract deleteVertexArray: vertexArray: WebGLVertexArrayObject option -> unit
    abstract drawArraysInstanced: mode: GL.Enum * first: GL.Int * count: GL.Sizei * instanceCount: GL.Sizei -> unit
    abstract drawBuffers: buffers: ResizeArray<GL.Enum> -> unit
    abstract drawElementsInstanced: mode: GL.Enum * count: GL.Sizei * ``type``: GL.Enum * offset: GL.IntPtr * instanceCount: GL.Sizei -> unit
    abstract drawRangeElements: mode: GL.Enum * start: GL.UInt * ``end``: GL.UInt * count: GL.Sizei * ``type``: GL.Enum * offset: GL.IntPtr -> unit
    abstract endQuery: target: GL.Enum -> unit
    abstract endTransformFeedback: unit -> unit
    abstract fenceSync: condition: GL.Enum * flags: GL.Bitfield -> WebGLSync option
    abstract framebufferTextureLayer: target: GL.Enum * attachment: GL.Enum * texture: WebGLTexture option * level: GL.Int * layer: GL.Int -> unit
    abstract getActiveUniformBlockName: program: WebGLProgram * uniformBlockIndex: GL.UInt -> string option
    abstract getActiveUniformBlockParameter: program: WebGLProgram * uniformBlockIndex: GL.UInt * pname: GL.Enum -> obj option
    abstract getActiveUniforms: program: WebGLProgram * uniformIndices: ResizeArray<GL.UInt> * pname: GL.Enum -> obj option
    abstract getBufferSubData: target: GL.Enum * srcByteOffset: GL.IntPtr * dstBuffer: ArrayBufferView * ?dstOffset: GL.UInt * ?length: GL.UInt -> unit
    abstract getFragDataLocation: program: WebGLProgram * name: string -> GL.Int
    abstract getIndexedParameter: target: GL.Enum * index: GL.UInt -> obj option
    abstract getInternalformatParameter: target: GL.Enum * internalformat: GL.Enum * pname: GL.Enum -> obj option
    abstract getQuery: target: GL.Enum * pname: GL.Enum -> WebGLQuery option
    abstract getQueryParameter: query: WebGLQuery * pname: GL.Enum -> obj option
    abstract getSamplerParameter: sampler: WebGLSampler * pname: GL.Enum -> obj option
    abstract getSyncParameter: sync: WebGLSync * pname: GL.Enum -> obj option
    abstract getTransformFeedbackVarying: program: WebGLProgram * index: GL.UInt -> WebGLActiveInfo option
    abstract getUniformBlockIndex: program: WebGLProgram * uniformBlockName: string -> GL.UInt
    abstract getUniformIndices: program: WebGLProgram * uniformNames: ResizeArray<string> -> ResizeArray<GL.UInt> option
    abstract invalidateFramebuffer: target: GL.Enum * attachments: ResizeArray<GL.Enum> -> unit
    abstract invalidateSubFramebuffer: target: GL.Enum * attachments: ResizeArray<GL.Enum> * x: GL.Int * y: GL.Int * width: GL.Sizei * height: GL.Sizei -> unit
    abstract isQuery: query: WebGLQuery option -> GL.Boolean
    abstract isSampler: sampler: WebGLSampler option -> GL.Boolean
    abstract isSync: sync: WebGLSync option -> GL.Boolean
    abstract isTransformFeedback: tf: WebGLTransformFeedback option -> GL.Boolean
    abstract isVertexArray: vertexArray: WebGLVertexArrayObject option -> GL.Boolean
    abstract pauseTransformFeedback: unit -> unit
    abstract readBuffer: src: GL.Enum -> unit
    abstract renderbufferStorageMultisample: target: GL.Enum * samples: GL.Sizei * internalformat: GL.Enum * width: GL.Sizei * height: GL.Sizei -> unit
    abstract resumeTransformFeedback: unit -> unit
    abstract samplerParameterf: sampler: WebGLSampler * pname: GL.Enum * param: GL.Float -> unit
    abstract samplerParameteri: sampler: WebGLSampler * pname: GL.Enum * param: GL.Int -> unit
    abstract texImage3D: target: GL.Enum * level: GL.Int * internalformat: GL.Int * width: GL.Sizei * height: GL.Sizei * depth: GL.Sizei * border: GL.Int * format: GL.Enum * ``type``: GL.Enum * pboOffset: GL.IntPtr -> unit
    // abstract texImage3D: target: GL.Enum * level: GL.Int * internalformat: GL.Int * width: GL.Sizei * height: GL.Sizei * depth: GL.Sizei * border: GL.Int * format: GL.Enum * ``type``: GL.Enum * source: TexImageSource -> unit
    abstract texImage3D: target: GL.Enum * level: GL.Int * internalformat: GL.Int * width: GL.Sizei * height: GL.Sizei * depth: GL.Sizei * border: GL.Int * format: GL.Enum * ``type``: GL.Enum * srcData: ArrayBufferView option -> unit
    abstract texImage3D: target: GL.Enum * level: GL.Int * internalformat: GL.Int * width: GL.Sizei * height: GL.Sizei * depth: GL.Sizei * border: GL.Int * format: GL.Enum * ``type``: GL.Enum * srcData: ArrayBufferView * srcOffset: GL.UInt -> unit
    abstract texStorage2D: target: GL.Enum * levels: GL.Sizei * internalformat: GL.Enum * width: GL.Sizei * height: GL.Sizei -> unit
    abstract texStorage3D: target: GL.Enum * levels: GL.Sizei * internalformat: GL.Enum * width: GL.Sizei * height: GL.Sizei * depth: GL.Sizei -> unit
    abstract texSubImage3D: target: GL.Enum * level: GL.Int * xoffset: GL.Int * yoffset: GL.Int * zoffset: GL.Int * width: GL.Sizei * height: GL.Sizei * depth: GL.Sizei * format: GL.Enum * ``type``: GL.Enum * pboOffset: GL.IntPtr -> unit
    // abstract texSubImage3D: target: GL.Enum * level: GL.Int * xoffset: GL.Int * yoffset: GL.Int * zoffset: GL.Int * width: GL.Sizei * height: GL.Sizei * depth: GL.Sizei * format: GL.Enum * ``type``: GL.Enum * source: TexImageSource -> unit
    abstract texSubImage3D: target: GL.Enum * level: GL.Int * xoffset: GL.Int * yoffset: GL.Int * zoffset: GL.Int * width: GL.Sizei * height: GL.Sizei * depth: GL.Sizei * format: GL.Enum * ``type``: GL.Enum * srcData: ArrayBufferView option * ?srcOffset: GL.UInt -> unit
    abstract transformFeedbackVaryings: program: WebGLProgram * varyings: ResizeArray<string> * bufferMode: GL.Enum -> unit
    abstract uniform1ui: location: WebGLUniformLocation option * v0: GL.UInt -> unit
    abstract uniform1uiv: location: WebGLUniformLocation option * data: Uint32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniform2ui: location: WebGLUniformLocation option * v0: GL.UInt * v1: GL.UInt -> unit
    abstract uniform2uiv: location: WebGLUniformLocation option * data: Uint32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniform3ui: location: WebGLUniformLocation option * v0: GL.UInt * v1: GL.UInt * v2: GL.UInt -> unit
    abstract uniform3uiv: location: WebGLUniformLocation option * data: Uint32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniform4ui: location: WebGLUniformLocation option * v0: GL.UInt * v1: GL.UInt * v2: GL.UInt * v3: GL.UInt -> unit
    abstract uniform4uiv: location: WebGLUniformLocation option * data: Uint32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniformBlockBinding: program: WebGLProgram * uniformBlockIndex: GL.UInt * uniformBlockBinding: GL.UInt -> unit
    abstract uniformMatrix2x3fv: location: WebGLUniformLocation option * transpose: GL.Boolean * data: Float32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniformMatrix2x4fv: location: WebGLUniformLocation option * transpose: GL.Boolean * data: Float32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniformMatrix3x2fv: location: WebGLUniformLocation option * transpose: GL.Boolean * data: Float32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniformMatrix3x4fv: location: WebGLUniformLocation option * transpose: GL.Boolean * data: Float32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniformMatrix4x2fv: location: WebGLUniformLocation option * transpose: GL.Boolean * data: Float32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract uniformMatrix4x3fv: location: WebGLUniformLocation option * transpose: GL.Boolean * data: Float32List * ?srcOffset: GL.UInt * ?srcLength: GL.UInt -> unit
    abstract vertexAttribDivisor: index: GL.UInt * divisor: GL.UInt -> unit
    abstract vertexAttribI4i: index: GL.UInt * x: GL.Int * y: GL.Int * z: GL.Int * w: GL.Int -> unit
    abstract vertexAttribI4iv: index: GL.UInt * values: Int32List -> unit
    abstract vertexAttribI4ui: index: GL.UInt * x: GL.UInt * y: GL.UInt * z: GL.UInt * w: GL.UInt -> unit
    abstract vertexAttribI4uiv: index: GL.UInt * values: Uint32List -> unit
    abstract vertexAttribIPointer: index: GL.UInt * size: GL.Int * ``type``: GL.Enum * stride: GL.Sizei * offset: GL.IntPtr -> unit
    abstract waitSync: sync: WebGLSync * flags: GL.Bitfield * timeout: GL.Int64 -> unit
    abstract ACTIVE_UNIFORM_BLOCKS: GL.Enum
    abstract ALREADY_SIGNALED: GL.Enum
    abstract ANY_SAMPLES_PASSED: GL.Enum
    abstract ANY_SAMPLES_PASSED_CONSERVATIVE: GL.Enum
    abstract COLOR: GL.Enum
    abstract COLOR_ATTACHMENT1: GL.Enum
    abstract COLOR_ATTACHMENT10: GL.Enum
    abstract COLOR_ATTACHMENT11: GL.Enum
    abstract COLOR_ATTACHMENT12: GL.Enum
    abstract COLOR_ATTACHMENT13: GL.Enum
    abstract COLOR_ATTACHMENT14: GL.Enum
    abstract COLOR_ATTACHMENT15: GL.Enum
    abstract COLOR_ATTACHMENT2: GL.Enum
    abstract COLOR_ATTACHMENT3: GL.Enum
    abstract COLOR_ATTACHMENT4: GL.Enum
    abstract COLOR_ATTACHMENT5: GL.Enum
    abstract COLOR_ATTACHMENT6: GL.Enum
    abstract COLOR_ATTACHMENT7: GL.Enum
    abstract COLOR_ATTACHMENT8: GL.Enum
    abstract COLOR_ATTACHMENT9: GL.Enum
    abstract COMPARE_REF_TO_TEXTURE: GL.Enum
    abstract CONDITION_SATISFIED: GL.Enum
    abstract COPY_READ_BUFFER: GL.Enum
    abstract COPY_READ_BUFFER_BINDING: GL.Enum
    abstract COPY_WRITE_BUFFER: GL.Enum
    abstract COPY_WRITE_BUFFER_BINDING: GL.Enum
    abstract CURRENT_QUERY: GL.Enum
    abstract DEPTH: GL.Enum
    abstract DEPTH24_STENCIL8: GL.Enum
    abstract DEPTH32F_STENCIL8: GL.Enum
    abstract DEPTH_COMPONENT24: GL.Enum
    abstract DEPTH_COMPONENT32F: GL.Enum
    abstract DRAW_BUFFER0: GL.Enum
    abstract DRAW_BUFFER1: GL.Enum
    abstract DRAW_BUFFER10: GL.Enum
    abstract DRAW_BUFFER11: GL.Enum
    abstract DRAW_BUFFER12: GL.Enum
    abstract DRAW_BUFFER13: GL.Enum
    abstract DRAW_BUFFER14: GL.Enum
    abstract DRAW_BUFFER15: GL.Enum
    abstract DRAW_BUFFER2: GL.Enum
    abstract DRAW_BUFFER3: GL.Enum
    abstract DRAW_BUFFER4: GL.Enum
    abstract DRAW_BUFFER5: GL.Enum
    abstract DRAW_BUFFER6: GL.Enum
    abstract DRAW_BUFFER7: GL.Enum
    abstract DRAW_BUFFER8: GL.Enum
    abstract DRAW_BUFFER9: GL.Enum
    abstract DRAW_FRAMEBUFFER: GL.Enum
    abstract DRAW_FRAMEBUFFER_BINDING: GL.Enum
    abstract DYNAMIC_COPY: GL.Enum
    abstract DYNAMIC_READ: GL.Enum
    abstract FLOAT_32_UNSIGNED_INT_24_8_REV: GL.Enum
    abstract FLOAT_MAT2x3: GL.Enum
    abstract FLOAT_MAT2x4: GL.Enum
    abstract FLOAT_MAT3x2: GL.Enum
    abstract FLOAT_MAT3x4: GL.Enum
    abstract FLOAT_MAT4x2: GL.Enum
    abstract FLOAT_MAT4x3: GL.Enum
    abstract FRAGMENT_SHADER_DERIVATIVE_HINT: GL.Enum
    abstract FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE: GL.Enum
    abstract FRAMEBUFFER_ATTACHMENT_BLUE_SIZE: GL.Enum
    abstract FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING: GL.Enum
    abstract FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE: GL.Enum
    abstract FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE: GL.Enum
    abstract FRAMEBUFFER_ATTACHMENT_GREEN_SIZE: GL.Enum
    abstract FRAMEBUFFER_ATTACHMENT_RED_SIZE: GL.Enum
    abstract FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE: GL.Enum
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER: GL.Enum
    abstract FRAMEBUFFER_DEFAULT: GL.Enum
    abstract FRAMEBUFFER_INCOMPLETE_MULTISAMPLE: GL.Enum
    abstract HALF_FLOAT: GL.Enum
    abstract INTERLEAVED_ATTRIBS: GL.Enum
    abstract INT_2_10_10_10_REV: GL.Enum
    abstract INT_SAMPLER_2D: GL.Enum
    abstract INT_SAMPLER_2D_ARRAY: GL.Enum
    abstract INT_SAMPLER_3D: GL.Enum
    abstract INT_SAMPLER_CUBE: GL.Enum
    abstract INVALID_INDEX: GL.Enum
    abstract MAX: GL.Enum
    abstract MAX_3D_TEXTURE_SIZE: GL.Enum
    abstract MAX_ARRAY_TEXTURE_LAYERS: GL.Enum
    abstract MAX_CLIENT_WAIT_TIMEOUT_WEBGL: GL.Enum
    abstract MAX_COLOR_ATTACHMENTS: GL.Enum
    abstract MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS: GL.Enum
    abstract MAX_COMBINED_UNIFORM_BLOCKS: GL.Enum
    abstract MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS: GL.Enum
    abstract MAX_DRAW_BUFFERS: GL.Enum
    abstract MAX_ELEMENTS_INDICES: GL.Enum
    abstract MAX_ELEMENTS_VERTICES: GL.Enum
    abstract MAX_ELEMENT_INDEX: GL.Enum
    abstract MAX_FRAGMENT_INPUT_COMPONENTS: GL.Enum
    abstract MAX_FRAGMENT_UNIFORM_BLOCKS: GL.Enum
    abstract MAX_FRAGMENT_UNIFORM_COMPONENTS: GL.Enum
    abstract MAX_PROGRAM_TEXEL_OFFSET: GL.Enum
    abstract MAX_SAMPLES: GL.Enum
    abstract MAX_SERVER_WAIT_TIMEOUT: GL.Enum
    abstract MAX_TEXTURE_LOD_BIAS: GL.Enum
    abstract MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS: GL.Enum
    abstract MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS: GL.Enum
    abstract MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS: GL.Enum
    abstract MAX_UNIFORM_BLOCK_SIZE: GL.Enum
    abstract MAX_UNIFORM_BUFFER_BINDINGS: GL.Enum
    abstract MAX_VARYING_COMPONENTS: GL.Enum
    abstract MAX_VERTEX_OUTPUT_COMPONENTS: GL.Enum
    abstract MAX_VERTEX_UNIFORM_BLOCKS: GL.Enum
    abstract MAX_VERTEX_UNIFORM_COMPONENTS: GL.Enum
    abstract MIN: GL.Enum
    abstract MIN_PROGRAM_TEXEL_OFFSET: GL.Enum
    abstract OBJECT_TYPE: GL.Enum
    abstract PACK_ROW_LENGTH: GL.Enum
    abstract PACK_SKIP_PIXELS: GL.Enum
    abstract PACK_SKIP_ROWS: GL.Enum
    abstract PIXEL_PACK_BUFFER: GL.Enum
    abstract PIXEL_PACK_BUFFER_BINDING: GL.Enum
    abstract PIXEL_UNPACK_BUFFER: GL.Enum
    abstract PIXEL_UNPACK_BUFFER_BINDING: GL.Enum
    abstract QUERY_RESULT: GL.Enum
    abstract QUERY_RESULT_AVAILABLE: GL.Enum
    abstract R11F_G11F_B10F: GL.Enum
    abstract R16F: GL.Enum
    abstract R16I: GL.Enum
    abstract R16UI: GL.Enum
    abstract R32F: GL.Enum
    abstract R32I: GL.Enum
    abstract R32UI: GL.Enum
    abstract R8: GL.Enum
    abstract R8I: GL.Enum
    abstract R8UI: GL.Enum
    abstract R8_SNORM: GL.Enum
    abstract RASTERIZER_DISCARD: GL.Enum
    abstract READ_BUFFER: GL.Enum
    abstract READ_FRAMEBUFFER: GL.Enum
    abstract READ_FRAMEBUFFER_BINDING: GL.Enum
    abstract RED: GL.Enum
    abstract RED_INTEGER: GL.Enum
    abstract RENDERBUFFER_SAMPLES: GL.Enum
    abstract RG: GL.Enum
    abstract RG16F: GL.Enum
    abstract RG16I: GL.Enum
    abstract RG16UI: GL.Enum
    abstract RG32F: GL.Enum
    abstract RG32I: GL.Enum
    abstract RG32UI: GL.Enum
    abstract RG8: GL.Enum
    abstract RG8I: GL.Enum
    abstract RG8UI: GL.Enum
    abstract RG8_SNORM: GL.Enum
    abstract RGB10_A2: GL.Enum
    abstract RGB10_A2UI: GL.Enum
    abstract RGB16F: GL.Enum
    abstract RGB16I: GL.Enum
    abstract RGB16UI: GL.Enum
    abstract RGB32F: GL.Enum
    abstract RGB32I: GL.Enum
    abstract RGB32UI: GL.Enum
    abstract RGB8: GL.Enum
    abstract RGB8I: GL.Enum
    abstract RGB8UI: GL.Enum
    abstract RGB8_SNORM: GL.Enum
    abstract RGB9_E5: GL.Enum
    abstract RGBA16F: GL.Enum
    abstract RGBA16I: GL.Enum
    abstract RGBA16UI: GL.Enum
    abstract RGBA32F: GL.Enum
    abstract RGBA32I: GL.Enum
    abstract RGBA32UI: GL.Enum
    abstract RGBA8: GL.Enum
    abstract RGBA8I: GL.Enum
    abstract RGBA8UI: GL.Enum
    abstract RGBA8_SNORM: GL.Enum
    abstract RGBA_INTEGER: GL.Enum
    abstract RGB_INTEGER: GL.Enum
    abstract RG_INTEGER: GL.Enum
    abstract SAMPLER_2D_ARRAY: GL.Enum
    abstract SAMPLER_2D_ARRAY_SHADOW: GL.Enum
    abstract SAMPLER_2D_SHADOW: GL.Enum
    abstract SAMPLER_3D: GL.Enum
    abstract SAMPLER_BINDING: GL.Enum
    abstract SAMPLER_CUBE_SHADOW: GL.Enum
    abstract SEPARATE_ATTRIBS: GL.Enum
    abstract SIGNALED: GL.Enum
    abstract SIGNED_NORMALIZED: GL.Enum
    abstract SRGB: GL.Enum
    abstract SRGB8: GL.Enum
    abstract SRGB8_ALPHA8: GL.Enum
    abstract STATIC_COPY: GL.Enum
    abstract STATIC_READ: GL.Enum
    abstract STENCIL: GL.Enum
    abstract STREAM_COPY: GL.Enum
    abstract STREAM_READ: GL.Enum
    abstract SYNC_CONDITION: GL.Enum
    abstract SYNC_FENCE: GL.Enum
    abstract SYNC_FLAGS: GL.Enum
    abstract SYNC_FLUSH_COMMANDS_BIT: GL.Enum
    abstract SYNC_GPU_COMMANDS_COMPLETE: GL.Enum
    abstract SYNC_STATUS: GL.Enum
    abstract TEXTURE_2D_ARRAY: GL.Enum
    abstract TEXTURE_3D: GL.Enum
    abstract TEXTURE_BASE_LEVEL: GL.Enum
    abstract TEXTURE_BINDING_2D_ARRAY: GL.Enum
    abstract TEXTURE_BINDING_3D: GL.Enum
    abstract TEXTURE_COMPARE_FUNC: GL.Enum
    abstract TEXTURE_COMPARE_MODE: GL.Enum
    abstract TEXTURE_IMMUTABLE_FORMAT: GL.Enum
    abstract TEXTURE_IMMUTABLE_LEVELS: GL.Enum
    abstract TEXTURE_MAX_LEVEL: GL.Enum
    abstract TEXTURE_MAX_LOD: GL.Enum
    abstract TEXTURE_MIN_LOD: GL.Enum
    abstract TEXTURE_WRAP_R: GL.Enum
    abstract TIMEOUT_EXPIRED: GL.Enum
    abstract TIMEOUT_IGNORED: GL.Int64
    abstract TRANSFORM_FEEDBACK: GL.Enum
    abstract TRANSFORM_FEEDBACK_ACTIVE: GL.Enum
    abstract TRANSFORM_FEEDBACK_BINDING: GL.Enum
    abstract TRANSFORM_FEEDBACK_BUFFER: GL.Enum
    abstract TRANSFORM_FEEDBACK_BUFFER_BINDING: GL.Enum
    abstract TRANSFORM_FEEDBACK_BUFFER_MODE: GL.Enum
    abstract TRANSFORM_FEEDBACK_BUFFER_SIZE: GL.Enum
    abstract TRANSFORM_FEEDBACK_BUFFER_START: GL.Enum
    abstract TRANSFORM_FEEDBACK_PAUSED: GL.Enum
    abstract TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN: GL.Enum
    abstract TRANSFORM_FEEDBACK_VARYINGS: GL.Enum
    abstract UNIFORM_ARRAY_STRIDE: GL.Enum
    abstract UNIFORM_BLOCK_ACTIVE_UNIFORMS: GL.Enum
    abstract UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES: GL.Enum
    abstract UNIFORM_BLOCK_BINDING: GL.Enum
    abstract UNIFORM_BLOCK_DATA_SIZE: GL.Enum
    abstract UNIFORM_BLOCK_INDEX: GL.Enum
    abstract UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER: GL.Enum
    abstract UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER: GL.Enum
    abstract UNIFORM_BUFFER: GL.Enum
    abstract UNIFORM_BUFFER_BINDING: GL.Enum
    abstract UNIFORM_BUFFER_OFFSET_ALIGNMENT: GL.Enum
    abstract UNIFORM_BUFFER_SIZE: GL.Enum
    abstract UNIFORM_BUFFER_START: GL.Enum
    abstract UNIFORM_IS_ROW_MAJOR: GL.Enum
    abstract UNIFORM_MATRIX_STRIDE: GL.Enum
    abstract UNIFORM_OFFSET: GL.Enum
    abstract UNIFORM_SIZE: GL.Enum
    abstract UNIFORM_TYPE: GL.Enum
    abstract UNPACK_IMAGE_HEIGHT: GL.Enum
    abstract UNPACK_ROW_LENGTH: GL.Enum
    abstract UNPACK_SKIP_IMAGES: GL.Enum
    abstract UNPACK_SKIP_PIXELS: GL.Enum
    abstract UNPACK_SKIP_ROWS: GL.Enum
    abstract UNSIGNALED: GL.Enum
    abstract UNSIGNED_INT_10F_11F_11F_REV: GL.Enum
    abstract UNSIGNED_INT_24_8: GL.Enum
    abstract UNSIGNED_INT_2_10_10_10_REV: GL.Enum
    abstract UNSIGNED_INT_5_9_9_9_REV: GL.Enum
    abstract UNSIGNED_INT_SAMPLER_2D: GL.Enum
    abstract UNSIGNED_INT_SAMPLER_2D_ARRAY: GL.Enum
    abstract UNSIGNED_INT_SAMPLER_3D: GL.Enum
    abstract UNSIGNED_INT_SAMPLER_CUBE: GL.Enum
    abstract UNSIGNED_INT_VEC2: GL.Enum
    abstract UNSIGNED_INT_VEC3: GL.Enum
    abstract UNSIGNED_INT_VEC4: GL.Enum
    abstract UNSIGNED_NORMALIZED: GL.Enum
    abstract VERTEX_ARRAY_BINDING: GL.Enum
    abstract VERTEX_ATTRIB_ARRAY_DIVISOR: GL.Enum
    abstract VERTEX_ATTRIB_ARRAY_INTEGER: GL.Enum
    abstract WAIT_FAILED: GL.Enum
