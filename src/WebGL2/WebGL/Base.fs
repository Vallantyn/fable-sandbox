// ts2fable 0.7.1
namespace WebGL.RenderingContext

open Fable.Core
open HTML.Types
open WebGL.Types
open WebGL.Extensions

[<AllowNullLiteral; CompiledName("WebGLRenderingContextBase")>]
type Base =
    abstract canvas: HTMLCanvasElement//U2<HTMLCanvasElement, OffscreenCanvas>
    abstract drawingBufferHeight: GL.Sizei
    abstract drawingBufferWidth: GL.Sizei
    abstract activeTexture: texture: GL.Enum -> unit
    abstract attachShader: program: WebGLProgram * shader: WebGLShader -> unit
    abstract bindAttribLocation: program: WebGLProgram * index: GL.UInt * name: string -> unit
    abstract bindBuffer: target: GL.Enum * buffer: WebGLBuffer option -> unit
    abstract bindFramebuffer: target: GL.Enum * framebuffer: WebGLFramebuffer option -> unit
    abstract bindRenderbuffer: target: GL.Enum * renderbuffer: WebGLRenderbuffer option -> unit
    abstract bindTexture: target: GL.Enum * texture: WebGLTexture option -> unit
    abstract blendColor: red: GL.Clampf * green: GL.Clampf * blue: GL.Clampf * alpha: GL.Clampf -> unit
    abstract blendEquation: mode: GL.Enum -> unit
    abstract blendEquationSeparate: modeRGB: GL.Enum * modeAlpha: GL.Enum -> unit
    abstract blendFunc: sfactor: GL.Enum * dfactor: GL.Enum -> unit
    abstract blendFuncSeparate: srcRGB: GL.Enum * dstRGB: GL.Enum * srcAlpha: GL.Enum * dstAlpha: GL.Enum -> unit
    abstract checkFramebufferStatus: target: GL.Enum -> GL.Enum
    abstract clear: mask: GL.Bitfield -> unit
    abstract clearColor: red: GL.Clampf * green: GL.Clampf * blue: GL.Clampf * alpha: GL.Clampf -> unit
    abstract clearDepth: depth: GL.Clampf -> unit
    abstract clearStencil: s: GL.Int -> unit
    abstract colorMask: red: GL.Boolean * green: GL.Boolean * blue: GL.Boolean * alpha: GL.Boolean -> unit
    abstract compileShader: shader: WebGLShader -> unit
    abstract copyTexImage2D: target: GL.Enum * level: GL.Int * internalformat: GL.Enum * x: GL.Int * y: GL.Int * width: GL.Sizei * height: GL.Sizei * border: GL.Int -> unit
    abstract copyTexSubImage2D: target: GL.Enum * level: GL.Int * xoffset: GL.Int * yoffset: GL.Int * x: GL.Int * y: GL.Int * width: GL.Sizei * height: GL.Sizei -> unit
    abstract createBuffer: unit -> WebGLBuffer option
    abstract createFramebuffer: unit -> WebGLFramebuffer option
    abstract createProgram: unit -> WebGLProgram option
    abstract createRenderbuffer: unit -> WebGLRenderbuffer option
    abstract createShader: ``type``: GL.Enum -> WebGLShader option
    abstract createTexture: unit -> WebGLTexture option
    abstract cullFace: mode: GL.Enum -> unit
    abstract deleteBuffer: buffer: WebGLBuffer option -> unit
    abstract deleteFramebuffer: framebuffer: WebGLFramebuffer option -> unit
    abstract deleteProgram: program: WebGLProgram option -> unit
    abstract deleteRenderbuffer: renderbuffer: WebGLRenderbuffer option -> unit
    abstract deleteShader: shader: WebGLShader option -> unit
    abstract deleteTexture: texture: WebGLTexture option -> unit
    abstract depthFunc: func: GL.Enum -> unit
    abstract depthMask: flag: GL.Boolean -> unit
    abstract depthRange: zNear: GL.Clampf * zFar: GL.Clampf -> unit
    abstract detachShader: program: WebGLProgram * shader: WebGLShader -> unit
    abstract disable: cap: GL.Enum -> unit
    abstract disableVertexAttribArray: index: GL.UInt -> unit
    abstract drawArrays: mode: GL.Enum * first: GL.Int * count: GL.Sizei -> unit
    abstract drawElements: mode: GL.Enum * count: GL.Sizei * ``type``: GL.Enum * offset: GL.IntPtr -> unit
    abstract enable: cap: GL.Enum -> unit
    abstract enableVertexAttribArray: index: GL.UInt -> unit
    abstract finish: unit -> unit
    abstract flush: unit -> unit
    abstract framebufferRenderbuffer: target: GL.Enum * attachment: GL.Enum * renderbuffertarget: GL.Enum * renderbuffer: WebGLRenderbuffer option -> unit
    abstract framebufferTexture2D: target: GL.Enum * attachment: GL.Enum * textarget: GL.Enum * texture: WebGLTexture option * level: GL.Int -> unit
    abstract frontFace: mode: GL.Enum -> unit
    abstract generateMipmap: target: GL.Enum -> unit
    abstract getActiveAttrib: program: WebGLProgram * index: GL.UInt -> WebGLActiveInfo option
    abstract getActiveUniform: program: WebGLProgram * index: GL.UInt -> WebGLActiveInfo option
    abstract getAttachedShaders: program: WebGLProgram -> ResizeArray<WebGLShader> option
    abstract getAttribLocation: program: WebGLProgram * name: string -> GL.Int
    abstract getBufferParameter: target: GL.Enum * pname: GL.Enum -> obj option
    // abstract getContextAttributes: unit -> WebGLContextAttributes option
    abstract getError: unit -> GL.Enum
    [<Emit "$0.getExtension('ANGLE_instanced_arrays')">] abstract getExtension_ANGLE_instanced_arrays: unit -> ANGLE_instanced_arrays option
    [<Emit "$0.getExtension('EXT_blend_minmax')">] abstract getExtension_EXT_blend_minmax: unit -> EXT_blend_minmax option
    [<Emit "$0.getExtension('EXT_color_buffer_float')">] abstract getExtension_EXT_color_buffer_float: unit -> EXT_color_buffer_float option
    [<Emit "$0.getExtension('EXT_color_buffer_half_float')">] abstract getExtension_EXT_color_buffer_half_float: unit -> EXT_color_buffer_half_float option
    [<Emit "$0.getExtension('EXT_float_blend')">] abstract getExtension_EXT_float_blend: unit -> EXT_float_blend option
    [<Emit "$0.getExtension('EXT_frag_depth')">] abstract getExtension_EXT_frag_depth: unit -> EXT_frag_depth option
    [<Emit "$0.getExtension('EXT_sRGB')">] abstract getExtension_EXT_sRGB: unit -> EXT_sRGB option
    [<Emit "$0.getExtension('EXT_shader_texture_lod')">] abstract getExtension_EXT_shader_texture_lod: unit -> EXT_shader_texture_lod option
    [<Emit "$0.getExtension('EXT_texture_compression_bptc')">] abstract getExtension_EXT_texture_compression_bptc: unit -> EXT_texture_compression_bptc option
    [<Emit "$0.getExtension('EXT_texture_compression_rgtc')">] abstract getExtension_EXT_texture_compression_rgtc: unit -> EXT_texture_compression_rgtc option
    [<Emit "$0.getExtension('EXT_texture_filter_anisotropic')">] abstract getExtension_EXT_texture_filter_anisotropic: unit -> EXT_texture_filter_anisotropic option
    [<Emit "$0.getExtension('KHR_parallel_shader_compile')">] abstract getExtension_KHR_parallel_shader_compile: unit -> KHR_parallel_shader_compile option
    [<Emit "$0.getExtension('OES_element_index_uint')">] abstract getExtension_OES_element_index_uint: unit -> OES_element_index_uint option
    [<Emit "$0.getExtension('OES_fbo_render_mipmap')">] abstract getExtension_OES_fbo_render_mipmap: unit -> OES_fbo_render_mipmap option
    [<Emit "$0.getExtension('OES_standard_derivatives')">] abstract getExtension_OES_standard_derivatives: unit -> OES_standard_derivatives option
    [<Emit "$0.getExtension('OES_texture_float')">] abstract getExtension_OES_texture_float: unit -> OES_texture_float option
    [<Emit "$0.getExtension('OES_texture_float_linear')">] abstract getExtension_OES_texture_float_linear: unit -> OES_texture_float_linear option
    [<Emit "$0.getExtension('OES_texture_half_float')">] abstract getExtension_OES_texture_half_float: unit -> OES_texture_half_float option
    [<Emit "$0.getExtension('OES_texture_half_float_linear')">] abstract getExtension_OES_texture_half_float_linear: unit -> OES_texture_half_float_linear option
    [<Emit "$0.getExtension('OES_vertex_array_object')">] abstract getExtension_OES_vertex_array_object: unit -> OES_vertex_array_object option
    [<Emit "$0.getExtension('OVR_multiview2')">] abstract getExtension_OVR_multiview2: unit -> OVR_multiview2 option
    [<Emit "$0.getExtension('WEBGL_color_buffer_float')">] abstract getExtension_WEBGL_color_buffer_float: unit -> WEBGL_color_buffer_float option
    [<Emit "$0.getExtension('WEBGL_compressed_texture_astc')">] abstract getExtension_WEBGL_compressed_texture_astc: unit -> WEBGL_compressed_texture_astc option
    [<Emit "$0.getExtension('WEBGL_compressed_texture_etc')">] abstract getExtension_WEBGL_compressed_texture_etc: unit -> WEBGL_compressed_texture_etc option
    [<Emit "$0.getExtension('WEBGL_compressed_texture_etc1')">] abstract getExtension_WEBGL_compressed_texture_etc1: unit -> WEBGL_compressed_texture_etc1 option
    [<Emit "$0.getExtension('WEBGL_compressed_texture_s3tc')">] abstract getExtension_WEBGL_compressed_texture_s3tc: unit -> WEBGL_compressed_texture_s3tc option
    [<Emit "$0.getExtension('WEBGL_compressed_texture_s3tc_srgb')">] abstract getExtension_WEBGL_compressed_texture_s3tc_srgb: unit -> WEBGL_compressed_texture_s3tc_srgb option
    [<Emit "$0.getExtension('WEBGL_debug_renderer_info')">] abstract getExtension_WEBGL_debug_renderer_info: unit -> WEBGL_debug_renderer_info option
    [<Emit "$0.getExtension('WEBGL_debug_shaders')">] abstract getExtension_WEBGL_debug_shaders: unit -> WEBGL_debug_shaders option
    [<Emit "$0.getExtension('WEBGL_depth_texture')">] abstract getExtension_WEBGL_depth_texture: unit -> WEBGL_depth_texture option
    [<Emit "$0.getExtension('WEBGL_draw_buffers')">] abstract getExtension_WEBGL_draw_buffers: unit -> WEBGL_draw_buffers option
    [<Emit "$0.getExtension('WEBGL_lose_context')">] abstract getExtension_WEBGL_lose_context: unit -> WEBGL_lose_context option
    [<Emit "$0.getExtension('WEBGL_multi_draw')">] abstract getExtension_WEBGL_multi_draw: unit -> WEBGL_multi_draw option
    abstract getExtension: name: string -> obj option
    abstract getFramebufferAttachmentParameter: target: GL.Enum * attachment: GL.Enum * pname: GL.Enum -> obj option
    abstract getParameter: pname: GL.Enum -> obj option
    abstract getProgramInfoLog: program: WebGLProgram -> string option
    abstract getProgramParameter: program: WebGLProgram * pname: GL.Enum -> obj option
    abstract getRenderbufferParameter: target: GL.Enum * pname: GL.Enum -> obj option
    abstract getShaderInfoLog: shader: WebGLShader -> string option
    abstract getShaderParameter: shader: WebGLShader * pname: GL.Enum -> U2<GL.Enum, GL.Boolean>
    abstract getShaderPrecisionFormat: shadertype: GL.Enum * precisiontype: GL.Enum -> WebGLShaderPrecisionFormat option
    abstract getShaderSource: shader: WebGLShader -> string option
    abstract getSupportedExtensions: unit -> ResizeArray<string> option
    abstract getTexParameter: target: GL.Enum * pname: GL.Enum -> obj option
    abstract getUniform: program: WebGLProgram * location: WebGLUniformLocation -> obj option
    abstract getUniformLocation: program: WebGLProgram * name: string -> WebGLUniformLocation option
    abstract getVertexAttrib: index: GL.UInt * pname: GL.Enum -> obj option
    abstract getVertexAttribOffset: index: GL.UInt * pname: GL.Enum -> GL.IntPtr
    abstract hint: target: GL.Enum * mode: GL.Enum -> unit
    abstract isBuffer: buffer: WebGLBuffer option -> GL.Boolean
    abstract isContextLost: unit -> bool
    abstract isEnabled: cap: GL.Enum -> GL.Boolean
    abstract isFramebuffer: framebuffer: WebGLFramebuffer option -> GL.Boolean
    abstract isProgram: program: WebGLProgram option -> GL.Boolean
    abstract isRenderbuffer: renderbuffer: WebGLRenderbuffer option -> GL.Boolean
    abstract isShader: shader: WebGLShader option -> GL.Boolean
    abstract isTexture: texture: WebGLTexture option -> GL.Boolean
    abstract lineWidth: width: GL.Float -> unit
    abstract linkProgram: program: WebGLProgram -> unit
    abstract pixelStorei: pname: GL.Enum * param: U2<GL.Int, GL.Boolean> -> unit
    abstract polygonOffset: factor: GL.Float * units: GL.Float -> unit
    abstract renderbufferStorage: target: GL.Enum * internalformat: GL.Enum * width: GL.Sizei * height: GL.Sizei -> unit
    abstract sampleCoverage: value: GL.Clampf * invert: GL.Boolean -> unit
    abstract scissor: x: GL.Int * y: GL.Int * width: GL.Sizei * height: GL.Sizei -> unit
    abstract shaderSource: shader: WebGLShader * source: string -> unit
    abstract stencilFunc: func: GL.Enum * ref: GL.Int * mask: GL.UInt -> unit
    abstract stencilFuncSeparate: face: GL.Enum * func: GL.Enum * ref: GL.Int * mask: GL.UInt -> unit
    abstract stencilMask: mask: GL.UInt -> unit
    abstract stencilMaskSeparate: face: GL.Enum * mask: GL.UInt -> unit
    abstract stencilOp: fail: GL.Enum * zfail: GL.Enum * zpass: GL.Enum -> unit
    abstract stencilOpSeparate: face: GL.Enum * fail: GL.Enum * zfail: GL.Enum * zpass: GL.Enum -> unit
    abstract texParameterf: target: GL.Enum * pname: GL.Enum * param: GL.Float -> unit
    abstract texParameteri: target: GL.Enum * pname: GL.Enum * param: GL.Int -> unit
    abstract uniform1f: location: WebGLUniformLocation option * x: GL.Float -> unit
    abstract uniform1i: location: WebGLUniformLocation option * x: GL.Int -> unit
    abstract uniform2f: location: WebGLUniformLocation option * x: GL.Float * y: GL.Float -> unit
    abstract uniform2i: location: WebGLUniformLocation option * x: GL.Int * y: GL.Int -> unit
    abstract uniform3f: location: WebGLUniformLocation option * x: GL.Float * y: GL.Float * z: GL.Float -> unit
    abstract uniform3i: location: WebGLUniformLocation option * x: GL.Int * y: GL.Int * z: GL.Int -> unit
    abstract uniform4f: location: WebGLUniformLocation option * x: GL.Float * y: GL.Float * z: GL.Float * w: GL.Float -> unit
    abstract uniform4i: location: WebGLUniformLocation option * x: GL.Int * y: GL.Int * z: GL.Int * w: GL.Int -> unit
    abstract useProgram: program: WebGLProgram option -> unit
    abstract validateProgram: program: WebGLProgram -> unit
    abstract vertexAttrib1f: index: GL.UInt * x: GL.Float -> unit
    abstract vertexAttrib1fv: index: GL.UInt * values: Float32List -> unit
    abstract vertexAttrib2f: index: GL.UInt * x: GL.Float * y: GL.Float -> unit
    abstract vertexAttrib2fv: index: GL.UInt * values: Float32List -> unit
    abstract vertexAttrib3f: index: GL.UInt * x: GL.Float * y: GL.Float * z: GL.Float -> unit
    abstract vertexAttrib3fv: index: GL.UInt * values: Float32List -> unit
    abstract vertexAttrib4f: index: GL.UInt * x: GL.Float * y: GL.Float * z: GL.Float * w: GL.Float -> unit
    abstract vertexAttrib4fv: index: GL.UInt * values: Float32List -> unit
    abstract vertexAttribPointer: index: GL.UInt * size: GL.Int * ``type``: GL.Enum * normalized: GL.Boolean * stride: GL.Sizei * offset: GL.IntPtr -> unit
    abstract viewport: x: GL.Int * y: GL.Int * width: GL.Sizei * height: GL.Sizei -> unit
    /// Passed to `clear` to clear the current depth buffer.
    abstract DEPTH_BUFFER_BIT: GL.Enum
    /// Passed to `clear` to clear the current stencil buffer.
    abstract STENCIL_BUFFER_BIT: GL.Enum
    /// Passed to `clear` to clear the current color buffer.
    abstract COLOR_BUFFER_BIT: GL.Enum
    /// Passed to `drawElements` or `drawArrays` to draw single points.
    abstract POINTS: GL.Enum
    /// Passed to `drawElements` or `drawArrays` to draw lines.  
    /// Each vertex connects to the one after it.
    abstract LINES: GL.Enum
    /// Passed to `drawElements` or `drawArrays` to draw lines.  
    /// Each set of two vertices is treated as a separate line segment.
    abstract LINE_LOOP: GL.Enum
    /// Passed to `drawElements` or `drawArrays` to draw a connected group of line segments from the first vertex to the last.
    abstract LINE_STRIP: GL.Enum
    /// Passed to `drawElements` or `drawArrays` to draw triangles.  
    /// Each set of three vertices creates a separate triangle.
    abstract TRIANGLES: GL.Enum
    /// Passed to `drawElements` or `drawArrays` to draw a connected group of triangles.
    abstract TRIANGLE_STRIP: GL.Enum
    /// Passed to `drawElements` or `drawArrays` to draw a connected group of triangles.  
    /// Each vertex connects to the previous and the first vertex in the fan.
    abstract TRIANGLE_FAN: GL.Enum
    abstract ACTIVE_ATTRIBUTES: GL.Enum
    abstract ACTIVE_TEXTURE: GL.Enum
    abstract ACTIVE_UNIFORMS: GL.Enum
    abstract ALIASED_LINE_WIDTH_RANGE: GL.Enum
    abstract ALIASED_POINT_SIZE_RANGE: GL.Enum
    abstract ALPHA: GL.Enum
    abstract ALPHA_BITS: GL.Enum
    abstract ALWAYS: GL.Enum
    abstract ARRAY_BUFFER: GL.Enum
    abstract ARRAY_BUFFER_BINDING: GL.Enum
    abstract ATTACHED_SHADERS: GL.Enum
    abstract BACK: GL.Enum
    abstract BLEND: GL.Enum
    abstract BLEND_COLOR: GL.Enum
    abstract BLEND_DST_ALPHA: GL.Enum
    abstract BLEND_DST_RGB: GL.Enum
    abstract BLEND_EQUATION: GL.Enum
    abstract BLEND_EQUATION_ALPHA: GL.Enum
    abstract BLEND_EQUATION_RGB: GL.Enum
    abstract BLEND_SRC_ALPHA: GL.Enum
    abstract BLEND_SRC_RGB: GL.Enum
    abstract BLUE_BITS: GL.Enum
    abstract BOOL: GL.Enum
    abstract BOOL_VEC2: GL.Enum
    abstract BOOL_VEC3: GL.Enum
    abstract BOOL_VEC4: GL.Enum
    abstract BROWSER_DEFAULT_WEBGL: GL.Enum
    abstract BUFFER_SIZE: GL.Enum
    abstract BUFFER_USAGE: GL.Enum
    abstract BYTE: GL.Enum
    abstract CCW: GL.Enum
    abstract CLAMP_TO_EDGE: GL.Enum
    abstract COLOR_ATTACHMENT0: GL.Enum
    abstract COLOR_CLEAR_VALUE: GL.Enum
    abstract COLOR_WRITEMASK: GL.Enum
    abstract COMPILE_STATUS: GL.Enum
    abstract COMPRESSED_TEXTURE_FORMATS: GL.Enum
    abstract CONSTANT_ALPHA: GL.Enum
    abstract CONSTANT_COLOR: GL.Enum
    abstract CONTEXT_LOST_WEBGL: GL.Enum
    abstract CULL_FACE: GL.Enum
    abstract CULL_FACE_MODE: GL.Enum
    abstract CURRENT_PROGRAM: GL.Enum
    abstract CURRENT_VERTEX_ATTRIB: GL.Enum
    abstract CW: GL.Enum
    abstract DECR: GL.Enum
    abstract DECR_WRAP: GL.Enum
    abstract DELETE_STATUS: GL.Enum
    abstract DEPTH_ATTACHMENT: GL.Enum
    abstract DEPTH_BITS: GL.Enum
    abstract DEPTH_CLEAR_VALUE: GL.Enum
    abstract DEPTH_COMPONENT: GL.Enum
    abstract DEPTH_COMPONENT16: GL.Enum
    abstract DEPTH_FUNC: GL.Enum
    abstract DEPTH_RANGE: GL.Enum
    abstract DEPTH_STENCIL: GL.Enum
    abstract DEPTH_STENCIL_ATTACHMENT: GL.Enum
    abstract DEPTH_TEST: GL.Enum
    abstract DEPTH_WRITEMASK: GL.Enum
    abstract DITHER: GL.Enum
    abstract DONT_CARE: GL.Enum
    abstract DST_ALPHA: GL.Enum
    abstract DST_COLOR: GL.Enum
    abstract DYNAMIC_DRAW: GL.Enum
    abstract ELEMENT_ARRAY_BUFFER: GL.Enum
    abstract ELEMENT_ARRAY_BUFFER_BINDING: GL.Enum
    abstract EQUAL: GL.Enum
    abstract FASTEST: GL.Enum
    abstract FLOAT: GL.Enum
    abstract FLOAT_MAT2: GL.Enum
    abstract FLOAT_MAT3: GL.Enum
    abstract FLOAT_MAT4: GL.Enum
    abstract FLOAT_VEC2: GL.Enum
    abstract FLOAT_VEC3: GL.Enum
    abstract FLOAT_VEC4: GL.Enum
    abstract FRAGMENT_SHADER: GL.Enum
    abstract FRAMEBUFFER: GL.Enum
    abstract FRAMEBUFFER_ATTACHMENT_OBJECT_NAME: GL.Enum
    abstract FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE: GL.Enum
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE: GL.Enum
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL: GL.Enum
    abstract FRAMEBUFFER_BINDING: GL.Enum
    abstract FRAMEBUFFER_COMPLETE: GL.Enum
    abstract FRAMEBUFFER_INCOMPLETE_ATTACHMENT: GL.Enum
    abstract FRAMEBUFFER_INCOMPLETE_DIMENSIONS: GL.Enum
    abstract FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT: GL.Enum
    abstract FRAMEBUFFER_UNSUPPORTED: GL.Enum
    abstract FRONT: GL.Enum
    abstract FRONT_AND_BACK: GL.Enum
    abstract FRONT_FACE: GL.Enum
    abstract FUNC_ADD: GL.Enum
    abstract FUNC_REVERSE_SUBTRACT: GL.Enum
    abstract FUNC_SUBTRACT: GL.Enum
    abstract GENERATE_MIPMAP_HINT: GL.Enum
    abstract GEQUAL: GL.Enum
    abstract GREATER: GL.Enum
    abstract GREEN_BITS: GL.Enum
    abstract HIGH_FLOAT: GL.Enum
    abstract HIGH_INT: GL.Enum
    abstract IMPLEMENTATION_COLOR_READ_FORMAT: GL.Enum
    abstract IMPLEMENTATION_COLOR_READ_TYPE: GL.Enum
    abstract INCR: GL.Enum
    abstract INCR_WRAP: GL.Enum
    abstract INT: GL.Enum
    abstract INT_VEC2: GL.Enum
    abstract INT_VEC3: GL.Enum
    abstract INT_VEC4: GL.Enum
    abstract INVALID_ENUM: GL.Enum
    abstract INVALID_FRAMEBUFFER_OPERATION: GL.Enum
    abstract INVALID_OPERATION: GL.Enum
    abstract INVALID_VALUE: GL.Enum
    abstract INVERT: GL.Enum
    abstract KEEP: GL.Enum
    abstract LEQUAL: GL.Enum
    abstract LESS: GL.Enum
    abstract LINEAR: GL.Enum
    abstract LINEAR_MIPMAP_LINEAR: GL.Enum
    abstract LINEAR_MIPMAP_NEAREST: GL.Enum
    abstract LINE_WIDTH: GL.Enum
    abstract LINK_STATUS: GL.Enum
    abstract LOW_FLOAT: GL.Enum
    abstract LOW_INT: GL.Enum
    abstract LUMINANCE: GL.Enum
    abstract LUMINANCE_ALPHA: GL.Enum
    abstract MAX_COMBINED_TEXTURE_IMAGE_UNITS: GL.Enum
    abstract MAX_CUBE_MAP_TEXTURE_SIZE: GL.Enum
    abstract MAX_FRAGMENT_UNIFORM_VECTORS: GL.Enum
    abstract MAX_RENDERBUFFER_SIZE: GL.Enum
    abstract MAX_TEXTURE_IMAGE_UNITS: GL.Enum
    abstract MAX_TEXTURE_SIZE: GL.Enum
    abstract MAX_VARYING_VECTORS: GL.Enum
    abstract MAX_VERTEX_ATTRIBS: GL.Enum
    abstract MAX_VERTEX_TEXTURE_IMAGE_UNITS: GL.Enum
    abstract MAX_VERTEX_UNIFORM_VECTORS: GL.Enum
    abstract MAX_VIEWPORT_DIMS: GL.Enum
    abstract MEDIUM_FLOAT: GL.Enum
    abstract MEDIUM_INT: GL.Enum
    abstract MIRRORED_REPEAT: GL.Enum
    abstract NEAREST: GL.Enum
    abstract NEAREST_MIPMAP_LINEAR: GL.Enum
    abstract NEAREST_MIPMAP_NEAREST: GL.Enum
    abstract NEVER: GL.Enum
    abstract NICEST: GL.Enum
    abstract NONE: GL.Enum
    abstract NOTEQUAL: GL.Enum
    abstract NO_ERROR: GL.Enum
    abstract ONE: GL.Enum
    abstract ONE_MINUS_CONSTANT_ALPHA: GL.Enum
    abstract ONE_MINUS_CONSTANT_COLOR: GL.Enum
    abstract ONE_MINUS_DST_ALPHA: GL.Enum
    abstract ONE_MINUS_DST_COLOR: GL.Enum
    abstract ONE_MINUS_SRC_ALPHA: GL.Enum
    abstract ONE_MINUS_SRC_COLOR: GL.Enum
    abstract OUT_OF_MEMORY: GL.Enum
    abstract PACK_ALIGNMENT: GL.Enum
    abstract POLYGON_OFFSET_FACTOR: GL.Enum
    abstract POLYGON_OFFSET_FILL: GL.Enum
    abstract POLYGON_OFFSET_UNITS: GL.Enum
    abstract RED_BITS: GL.Enum
    abstract RENDERBUFFER: GL.Enum
    abstract RENDERBUFFER_ALPHA_SIZE: GL.Enum
    abstract RENDERBUFFER_BINDING: GL.Enum
    abstract RENDERBUFFER_BLUE_SIZE: GL.Enum
    abstract RENDERBUFFER_DEPTH_SIZE: GL.Enum
    abstract RENDERBUFFER_GREEN_SIZE: GL.Enum
    abstract RENDERBUFFER_HEIGHT: GL.Enum
    abstract RENDERBUFFER_INTERNAL_FORMAT: GL.Enum
    abstract RENDERBUFFER_RED_SIZE: GL.Enum
    abstract RENDERBUFFER_STENCIL_SIZE: GL.Enum
    abstract RENDERBUFFER_WIDTH: GL.Enum
    abstract RENDERER: GL.Enum
    abstract REPEAT: GL.Enum
    abstract REPLACE: GL.Enum
    abstract RGB: GL.Enum
    abstract RGB565: GL.Enum
    abstract RGB5_A1: GL.Enum
    abstract RGBA: GL.Enum
    abstract RGBA4: GL.Enum
    abstract SAMPLER_2D: GL.Enum
    abstract SAMPLER_CUBE: GL.Enum
    abstract SAMPLES: GL.Enum
    abstract SAMPLE_ALPHA_TO_COVERAGE: GL.Enum
    abstract SAMPLE_BUFFERS: GL.Enum
    abstract SAMPLE_COVERAGE: GL.Enum
    abstract SAMPLE_COVERAGE_INVERT: GL.Enum
    abstract SAMPLE_COVERAGE_VALUE: GL.Enum
    abstract SCISSOR_BOX: GL.Enum
    abstract SCISSOR_TEST: GL.Enum
    abstract SHADER_TYPE: GL.Enum
    abstract SHADING_LANGUAGE_VERSION: GL.Enum
    abstract SHORT: GL.Enum
    abstract SRC_ALPHA: GL.Enum
    abstract SRC_ALPHA_SATURATE: GL.Enum
    abstract SRC_COLOR: GL.Enum
    abstract STATIC_DRAW: GL.Enum
    abstract STENCIL_ATTACHMENT: GL.Enum
    abstract STENCIL_BACK_FAIL: GL.Enum
    abstract STENCIL_BACK_FUNC: GL.Enum
    abstract STENCIL_BACK_PASS_DEPTH_FAIL: GL.Enum
    abstract STENCIL_BACK_PASS_DEPTH_PASS: GL.Enum
    abstract STENCIL_BACK_REF: GL.Enum
    abstract STENCIL_BACK_VALUE_MASK: GL.Enum
    abstract STENCIL_BACK_WRITEMASK: GL.Enum
    abstract STENCIL_BITS: GL.Enum
    abstract STENCIL_CLEAR_VALUE: GL.Enum
    abstract STENCIL_FAIL: GL.Enum
    abstract STENCIL_FUNC: GL.Enum
    abstract STENCIL_INDEX8: GL.Enum
    abstract STENCIL_PASS_DEPTH_FAIL: GL.Enum
    abstract STENCIL_PASS_DEPTH_PASS: GL.Enum
    abstract STENCIL_REF: GL.Enum
    abstract STENCIL_TEST: GL.Enum
    abstract STENCIL_VALUE_MASK: GL.Enum
    abstract STENCIL_WRITEMASK: GL.Enum
    abstract STREAM_DRAW: GL.Enum
    abstract SUBPIXEL_BITS: GL.Enum
    abstract TEXTURE: GL.Enum
    abstract TEXTURE0: GL.Enum
    abstract TEXTURE1: GL.Enum
    abstract TEXTURE10: GL.Enum
    abstract TEXTURE11: GL.Enum
    abstract TEXTURE12: GL.Enum
    abstract TEXTURE13: GL.Enum
    abstract TEXTURE14: GL.Enum
    abstract TEXTURE15: GL.Enum
    abstract TEXTURE16: GL.Enum
    abstract TEXTURE17: GL.Enum
    abstract TEXTURE18: GL.Enum
    abstract TEXTURE19: GL.Enum
    abstract TEXTURE2: GL.Enum
    abstract TEXTURE20: GL.Enum
    abstract TEXTURE21: GL.Enum
    abstract TEXTURE22: GL.Enum
    abstract TEXTURE23: GL.Enum
    abstract TEXTURE24: GL.Enum
    abstract TEXTURE25: GL.Enum
    abstract TEXTURE26: GL.Enum
    abstract TEXTURE27: GL.Enum
    abstract TEXTURE28: GL.Enum
    abstract TEXTURE29: GL.Enum
    abstract TEXTURE3: GL.Enum
    abstract TEXTURE30: GL.Enum
    abstract TEXTURE31: GL.Enum
    abstract TEXTURE4: GL.Enum
    abstract TEXTURE5: GL.Enum
    abstract TEXTURE6: GL.Enum
    abstract TEXTURE7: GL.Enum
    abstract TEXTURE8: GL.Enum
    abstract TEXTURE9: GL.Enum
    abstract TEXTURE_2D: GL.Enum
    abstract TEXTURE_BINDING_2D: GL.Enum
    abstract TEXTURE_BINDING_CUBE_MAP: GL.Enum
    abstract TEXTURE_CUBE_MAP: GL.Enum
    abstract TEXTURE_CUBE_MAP_NEGATIVE_X: GL.Enum
    abstract TEXTURE_CUBE_MAP_NEGATIVE_Y: GL.Enum
    abstract TEXTURE_CUBE_MAP_NEGATIVE_Z: GL.Enum
    abstract TEXTURE_CUBE_MAP_POSITIVE_X: GL.Enum
    abstract TEXTURE_CUBE_MAP_POSITIVE_Y: GL.Enum
    abstract TEXTURE_CUBE_MAP_POSITIVE_Z: GL.Enum
    abstract TEXTURE_MAG_FILTER: GL.Enum
    abstract TEXTURE_MIN_FILTER: GL.Enum
    abstract TEXTURE_WRAP_S: GL.Enum
    abstract TEXTURE_WRAP_T: GL.Enum
    abstract UNPACK_ALIGNMENT: GL.Enum
    abstract UNPACK_COLORSPACE_CONVERSION_WEBGL: GL.Enum
    abstract UNPACK_FLIP_Y_WEBGL: GL.Enum
    abstract UNPACK_PREMULTIPLY_ALPHA_WEBGL: GL.Enum
    abstract UNSIGNED_BYTE: GL.Enum
    abstract UNSIGNED_INT: GL.Enum
    abstract UNSIGNED_SHORT: GL.Enum
    abstract UNSIGNED_SHORT_4_4_4_4: GL.Enum
    abstract UNSIGNED_SHORT_5_5_5_1: GL.Enum
    abstract UNSIGNED_SHORT_5_6_5: GL.Enum
    abstract VALIDATE_STATUS: GL.Enum
    abstract VENDOR: GL.Enum
    abstract VERSION: GL.Enum
    abstract VERTEX_ATTRIB_ARRAY_BUFFER_BINDING: GL.Enum
    abstract VERTEX_ATTRIB_ARRAY_ENABLED: GL.Enum
    abstract VERTEX_ATTRIB_ARRAY_NORMALIZED: GL.Enum
    abstract VERTEX_ATTRIB_ARRAY_POINTER: GL.Enum
    abstract VERTEX_ATTRIB_ARRAY_SIZE: GL.Enum
    abstract VERTEX_ATTRIB_ARRAY_STRIDE: GL.Enum
    abstract VERTEX_ATTRIB_ARRAY_TYPE: GL.Enum
    abstract VERTEX_SHADER: GL.Enum
    abstract VIEWPORT: GL.Enum
    abstract ZERO: GL.Enum

// type GetShaderParameterParam =
// | ShaderType = 0x8B4F
// | DeleteStatus = 0x8B80
// | CompileStatus = 0x8B81

// type GetShaderParameterReturnValue =
// | ShaderType
// | DeleteStatus
// | CompileStatus
