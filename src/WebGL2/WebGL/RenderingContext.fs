// ts2fable 0.7.1
namespace WebGL.RenderingContext

open Fable.Core

open WebGL.Types

/// Provides an interface to the OpenGL ES 2.0 graphics rendering context for the drawing surface of an HTML <canvas> element.
[<AllowNullLiteral; CompiledName("WebGLRenderingContext")>]
type RenderingContext =
    inherit Base
    inherit Overloads

[<AllowNullLiteral; CompiledName("WebGLRenderingContextType")>]
type RenderingContextType =
    abstract prototype: RenderingContext with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj
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

namespace WebGL

open Fable.Core
open HTML.Types
open WebGL.RenderingContext

[<AutoOpen>]
module WebGLRenderingContext =

    type HTMLCanvasElement with
        [<Emit "$0.getContext('webgl',$1)">]
        member _.getContext_webgl(): RenderingContext = jsNative

    let [<Global>] WebGLRenderingContext: RenderingContextType = jsNative
