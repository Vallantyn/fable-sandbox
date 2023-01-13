// ts2fable 0.7.1
namespace WebGL.Extensions

open Fable.Core
open Fable.Core.JS
open WebGL.Types

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
