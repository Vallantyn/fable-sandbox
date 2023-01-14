// ts2fable 0.7.1
namespace WebGL.Extensions

open Fable.Core
open Fable.Core.JS
open WebGL.Types

type [<AllowNullLiteral>] WebGLVertexArrayObjectOES =
    interface end

/// The ANGLE_instanced_arrays extension is part of the WebGL API and allows to draw the same object, or groups of similar objects multiple times, if they share the same vertex data, primitive count and type.
type [<AllowNullLiteral>] ANGLE_instanced_arrays =
    abstract drawArraysInstancedANGLE: mode: GL.Enum * first: GL.Int * count: GL.Sizei * primcount: GL.Sizei -> unit
    abstract drawElementsInstancedANGLE: mode: GL.Enum * count: GL.Sizei * ``type``: GL.Enum * offset: GL.IntPtr * primcount: GL.Sizei -> unit
    abstract vertexAttribDivisorANGLE: index: GL.UInt * divisor: GL.UInt -> unit
    abstract VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE: GL.Enum

type [<AllowNullLiteral>] EXT_blend_minmax =
    abstract MAX_EXT: GL.Enum
    abstract MIN_EXT: GL.Enum

type [<AllowNullLiteral>] EXT_color_buffer_float =
    interface end

type [<AllowNullLiteral>] EXT_color_buffer_half_float =
    abstract FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT: GL.Enum
    abstract RGB16F_EXT: GL.Enum
    abstract RGBA16F_EXT: GL.Enum
    abstract UNSIGNED_NORMALIZED_EXT: GL.Enum

type [<AllowNullLiteral>] EXT_float_blend =
    interface end

/// The EXT_frag_depth extension is part of the WebGL API and enables to set a depth value of a fragment from within the fragment shader.
type [<AllowNullLiteral>] EXT_frag_depth =
    interface end

type [<AllowNullLiteral>] EXT_sRGB =
    abstract FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT: GL.Enum
    abstract SRGB8_ALPHA8_EXT: GL.Enum
    abstract SRGB_ALPHA_EXT: GL.Enum
    abstract SRGB_EXT: GL.Enum

type [<AllowNullLiteral>] EXT_shader_texture_lod =
    interface end

type [<AllowNullLiteral>] EXT_texture_compression_bptc =
    abstract COMPRESSED_RGBA_BPTC_UNORM_EXT: GL.Enum
    abstract COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT: GL.Enum
    abstract COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT: GL.Enum
    abstract COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT: GL.Enum

type [<AllowNullLiteral>] EXT_texture_compression_rgtc =
    abstract COMPRESSED_RED_GREEN_RGTC2_EXT: GL.Enum
    abstract COMPRESSED_RED_RGTC1_EXT: GL.Enum
    abstract COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT: GL.Enum
    abstract COMPRESSED_SIGNED_RED_RGTC1_EXT: GL.Enum

/// The EXT_texture_filter_anisotropic extension is part of the WebGL API and exposes two constants for anisotropic filtering (AF).
type [<AllowNullLiteral>] EXT_texture_filter_anisotropic =
    abstract MAX_TEXTURE_MAX_ANISOTROPY_EXT: GL.Enum
    abstract TEXTURE_MAX_ANISOTROPY_EXT: GL.Enum

type [<AllowNullLiteral>] EXT_texture_norm16 =
    abstract R16_EXT: GL.Enum
    abstract R16_SNORM_EXT: GL.Enum
    abstract RG16_EXT: GL.Enum
    abstract RG16_SNORM_EXT: GL.Enum
    abstract RGB16_EXT: GL.Enum
    abstract RGB16_SNORM_EXT: GL.Enum
    abstract RGBA16_EXT: GL.Enum
    abstract RGBA16_SNORM_EXT: GL.Enum

type [<AllowNullLiteral>] KHR_parallel_shader_compile =
    abstract COMPLETION_STATUS_KHR: GL.Enum

type [<AllowNullLiteral>] OES_draw_buffers_indexed =
    abstract blendEquationSeparateiOES: buf: GL.UInt * modeRGB: GL.Enum * modeAlpha: GL.Enum -> unit
    abstract blendEquationiOES: buf: GL.UInt * mode: GL.Enum -> unit
    abstract blendFuncSeparateiOES: buf: GL.UInt * srcRGB: GL.Enum * dstRGB: GL.Enum * srcAlpha: GL.Enum * dstAlpha: GL.Enum -> unit
    abstract blendFunciOES: buf: GL.UInt * src: GL.Enum * dst: GL.Enum -> unit
    abstract colorMaskiOES: buf: GL.UInt * r: GL.Boolean * g: GL.Boolean * b: GL.Boolean * a: GL.Boolean -> unit
    abstract disableiOES: target: GL.Enum * index: GL.UInt -> unit
    abstract enableiOES: target: GL.Enum * index: GL.UInt -> unit

/// The OES_element_index_uint extension is part of the WebGL API and adds support for gl.UNSIGNED_INT types to WebGLRenderingContext.drawElements().
type [<AllowNullLiteral>] OES_element_index_uint =
    interface end

type [<AllowNullLiteral>] OES_fbo_render_mipmap =
    interface end

/// The OES_standard_derivatives extension is part of the WebGL API and adds the GLSL derivative functions dFdx, dFdy, and fwidth.
type [<AllowNullLiteral>] OES_standard_derivatives =
    abstract FRAGMENT_SHADER_DERIVATIVE_HINT_OES: GL.Enum

/// The OES_texture_float extension is part of the WebGL API and exposes floating-point pixel types for textures.
type [<AllowNullLiteral>] OES_texture_float =
    interface end

/// The OES_texture_float_linear extension is part of the WebGL API and allows linear filtering with floating-point pixel types for textures.
type [<AllowNullLiteral>] OES_texture_float_linear =
    interface end

/// The OES_texture_half_float extension is part of the WebGL API and adds texture formats with 16- (aka half float) and 32-bit floating-point components.
type [<AllowNullLiteral>] OES_texture_half_float =
    abstract HALF_FLOAT_OES: GL.Enum

/// The OES_texture_half_float_linear extension is part of the WebGL API and allows linear filtering with half floating-point pixel types for textures.
type [<AllowNullLiteral>] OES_texture_half_float_linear =
    interface end

type [<AllowNullLiteral>] OES_vertex_array_object =
    abstract bindVertexArrayOES: arrayObject: WebGLVertexArrayObjectOES option -> unit
    abstract createVertexArrayOES: unit -> WebGLVertexArrayObjectOES option
    abstract deleteVertexArrayOES: arrayObject: WebGLVertexArrayObjectOES option -> unit
    abstract isVertexArrayOES: arrayObject: WebGLVertexArrayObjectOES option -> GL.Boolean
    abstract VERTEX_ARRAY_BINDING_OES: GL.Enum

type [<AllowNullLiteral>] OVR_multiview2 =
    abstract framebufferTextureMultiviewOVR: target: GL.Enum * attachment: GL.Enum * texture: WebGLTexture option * level: GL.Int * baseViewIndex: GL.Int * numViews: GL.Sizei -> unit
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR: GL.Enum
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR: GL.Enum
    abstract FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR: GL.Enum
    abstract MAX_VIEWS_OVR: GL.Enum

type [<AllowNullLiteral>] WEBGL_color_buffer_float =
    abstract FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE_EXT: GL.Enum
    abstract RGBA32F_EXT: GL.Enum
    abstract UNSIGNED_NORMALIZED_EXT: GL.Enum

type [<AllowNullLiteral>] WEBGL_compressed_texture_astc =
    abstract getSupportedProfiles: unit -> ResizeArray<string>
    abstract COMPRESSED_RGBA_ASTC_10x10_KHR: GL.Enum
    abstract COMPRESSED_RGBA_ASTC_10x5_KHR: GL.Enum
    abstract COMPRESSED_RGBA_ASTC_10x6_KHR: GL.Enum
    abstract COMPRESSED_RGBA_ASTC_10x8_KHR: GL.Enum
    abstract COMPRESSED_RGBA_ASTC_12x10_KHR: GL.Enum
    abstract COMPRESSED_RGBA_ASTC_12x12_KHR: GL.Enum
    abstract COMPRESSED_RGBA_ASTC_4x4_KHR: GL.Enum
    abstract COMPRESSED_RGBA_ASTC_5x4_KHR: GL.Enum
    abstract COMPRESSED_RGBA_ASTC_5x5_KHR: GL.Enum
    abstract COMPRESSED_RGBA_ASTC_6x5_KHR: GL.Enum
    abstract COMPRESSED_RGBA_ASTC_6x6_KHR: GL.Enum
    abstract COMPRESSED_RGBA_ASTC_8x5_KHR: GL.Enum
    abstract COMPRESSED_RGBA_ASTC_8x6_KHR: GL.Enum
    abstract COMPRESSED_RGBA_ASTC_8x8_KHR: GL.Enum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR: GL.Enum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR: GL.Enum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR: GL.Enum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR: GL.Enum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR: GL.Enum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR: GL.Enum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR: GL.Enum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR: GL.Enum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR: GL.Enum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR: GL.Enum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR: GL.Enum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR: GL.Enum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR: GL.Enum
    abstract COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR: GL.Enum

type [<AllowNullLiteral>] WEBGL_compressed_texture_etc =
    abstract COMPRESSED_R11_EAC: GL.Enum
    abstract COMPRESSED_RG11_EAC: GL.Enum
    abstract COMPRESSED_RGB8_ETC2: GL.Enum
    abstract COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2: GL.Enum
    abstract COMPRESSED_RGBA8_ETC2_EAC: GL.Enum
    abstract COMPRESSED_SIGNED_R11_EAC: GL.Enum
    abstract COMPRESSED_SIGNED_RG11_EAC: GL.Enum
    abstract COMPRESSED_SRGB8_ALPHA8_ETC2_EAC: GL.Enum
    abstract COMPRESSED_SRGB8_ETC2: GL.Enum
    abstract COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2: GL.Enum

type [<AllowNullLiteral>] WEBGL_compressed_texture_etc1 =
    abstract COMPRESSED_RGB_ETC1_WEBGL: GL.Enum

/// The WEBGL_compressed_texture_s3tc extension is part of the WebGL API and exposes four S3TC compressed texture formats.
type [<AllowNullLiteral>] WEBGL_compressed_texture_s3tc =
    abstract COMPRESSED_RGBA_S3TC_DXT1_EXT: GL.Enum
    abstract COMPRESSED_RGBA_S3TC_DXT3_EXT: GL.Enum
    abstract COMPRESSED_RGBA_S3TC_DXT5_EXT: GL.Enum
    abstract COMPRESSED_RGB_S3TC_DXT1_EXT: GL.Enum

type [<AllowNullLiteral>] WEBGL_compressed_texture_s3tc_srgb =
    abstract COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT: GL.Enum
    abstract COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT: GL.Enum
    abstract COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT: GL.Enum
    abstract COMPRESSED_SRGB_S3TC_DXT1_EXT: GL.Enum

/// The WEBGL_debug_renderer_info extension is part of the WebGL API and exposes two constants with information about the graphics driver for debugging purposes.
type [<AllowNullLiteral>] WEBGL_debug_renderer_info =
    abstract UNMASKED_RENDERER_WEBGL: GL.Enum
    abstract UNMASKED_VENDOR_WEBGL: GL.Enum

type [<AllowNullLiteral>] WEBGL_debug_shaders =
    abstract getTranslatedShaderSource: shader: WebGLShader -> string

/// The WEBGL_depth_texture extension is part of the WebGL API and defines 2D depth and depth-stencil textures.
type [<AllowNullLiteral>] WEBGL_depth_texture =
    abstract UNSIGNED_INT_24_8_WEBGL: GL.Enum

type [<AllowNullLiteral>] WEBGL_draw_buffers =
    abstract drawBuffersWEBGL: buffers: ResizeArray<GL.Enum> -> unit
    abstract COLOR_ATTACHMENT0_WEBGL: GL.Enum
    abstract COLOR_ATTACHMENT10_WEBGL: GL.Enum
    abstract COLOR_ATTACHMENT11_WEBGL: GL.Enum
    abstract COLOR_ATTACHMENT12_WEBGL: GL.Enum
    abstract COLOR_ATTACHMENT13_WEBGL: GL.Enum
    abstract COLOR_ATTACHMENT14_WEBGL: GL.Enum
    abstract COLOR_ATTACHMENT15_WEBGL: GL.Enum
    abstract COLOR_ATTACHMENT1_WEBGL: GL.Enum
    abstract COLOR_ATTACHMENT2_WEBGL: GL.Enum
    abstract COLOR_ATTACHMENT3_WEBGL: GL.Enum
    abstract COLOR_ATTACHMENT4_WEBGL: GL.Enum
    abstract COLOR_ATTACHMENT5_WEBGL: GL.Enum
    abstract COLOR_ATTACHMENT6_WEBGL: GL.Enum
    abstract COLOR_ATTACHMENT7_WEBGL: GL.Enum
    abstract COLOR_ATTACHMENT8_WEBGL: GL.Enum
    abstract COLOR_ATTACHMENT9_WEBGL: GL.Enum
    abstract DRAW_BUFFER0_WEBGL: GL.Enum
    abstract DRAW_BUFFER10_WEBGL: GL.Enum
    abstract DRAW_BUFFER11_WEBGL: GL.Enum
    abstract DRAW_BUFFER12_WEBGL: GL.Enum
    abstract DRAW_BUFFER13_WEBGL: GL.Enum
    abstract DRAW_BUFFER14_WEBGL: GL.Enum
    abstract DRAW_BUFFER15_WEBGL: GL.Enum
    abstract DRAW_BUFFER1_WEBGL: GL.Enum
    abstract DRAW_BUFFER2_WEBGL: GL.Enum
    abstract DRAW_BUFFER3_WEBGL: GL.Enum
    abstract DRAW_BUFFER4_WEBGL: GL.Enum
    abstract DRAW_BUFFER5_WEBGL: GL.Enum
    abstract DRAW_BUFFER6_WEBGL: GL.Enum
    abstract DRAW_BUFFER7_WEBGL: GL.Enum
    abstract DRAW_BUFFER8_WEBGL: GL.Enum
    abstract DRAW_BUFFER9_WEBGL: GL.Enum
    abstract MAX_COLOR_ATTACHMENTS_WEBGL: GL.Enum
    abstract MAX_DRAW_BUFFERS_WEBGL: GL.Enum

type [<AllowNullLiteral>] WEBGL_lose_context =
    abstract loseContext: unit -> unit
    abstract restoreContext: unit -> unit

type [<AllowNullLiteral>] WEBGL_multi_draw =
    abstract multiDrawArraysInstancedWEBGL: mode: GL.Enum * firstsList: U2<Int32Array, ResizeArray<GL.Int>> * firstsOffset: GL.UInt * countsList: U2<Int32Array, ResizeArray<GL.Sizei>> * countsOffset: GL.UInt * instanceCountsList: U2<Int32Array, ResizeArray<GL.Sizei>> * instanceCountsOffset: GL.UInt * drawcount: GL.Sizei -> unit
    abstract multiDrawArraysWEBGL: mode: GL.Enum * firstsList: U2<Int32Array, ResizeArray<GL.Int>> * firstsOffset: GL.UInt * countsList: U2<Int32Array, ResizeArray<GL.Sizei>> * countsOffset: GL.UInt * drawcount: GL.Sizei -> unit
    abstract multiDrawElementsInstancedWEBGL: mode: GL.Enum * countsList: U2<Int32Array, ResizeArray<GL.Sizei>> * countsOffset: GL.UInt * ``type``: GL.Enum * offsetsList: U2<Int32Array, ResizeArray<GL.Sizei>> * offsetsOffset: GL.UInt * instanceCountsList: U2<Int32Array, ResizeArray<GL.Sizei>> * instanceCountsOffset: GL.UInt * drawcount: GL.Sizei -> unit
    abstract multiDrawElementsWEBGL: mode: GL.Enum * countsList: U2<Int32Array, ResizeArray<GL.Sizei>> * countsOffset: GL.UInt * ``type``: GL.Enum * offsetsList: U2<Int32Array, ResizeArray<GL.Sizei>> * offsetsOffset: GL.UInt * drawcount: GL.Sizei -> unit
