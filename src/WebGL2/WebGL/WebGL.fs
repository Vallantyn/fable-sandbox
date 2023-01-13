// ts2fable 0.7.1
namespace WebGL.RenderingContext

open System
open Fable.Core
open Fable.Core.JS

open WebGL.Types
open WebGL.Base
open WebGL.Overloads

// let [<Import("WebGLRenderingContextType","webgl")>] WebGLRenderingContextType: WebGLRenderingContextType = jsNative

/// Provides an interface to the OpenGL ES 2.0 graphics rendering context for the drawing surface of an HTML <canvas> element.
type [<AllowNullLiteral>] WebGLRenderingContext =
    inherit WebGLRenderingContextBase
    inherit WebGLRenderingContextOverloads

type [<AllowNullLiteral>] WebGLRenderingContextType =
    abstract prototype: WebGLRenderingContext with get, set
    [<Emit "new $0($1...)">] abstract Create: unit -> obj
    /// Passed to `clear` to clear the current depth buffer.
    abstract DEPTH_BUFFER_BIT: GLenum
    /// Passed to `clear` to clear the current stencil buffer.
    abstract STENCIL_BUFFER_BIT: GLenum
    /// Passed to `clear` to clear the current color buffer.
    abstract COLOR_BUFFER_BIT: GLenum
    /// Passed to `drawElements` or `drawArrays` to draw single points.
    abstract POINTS: GLenum
    /// Passed to `drawElements` or `drawArrays` to draw lines.  
    /// Each vertex connects to the one after it.
    abstract LINES: GLenum
    /// Passed to `drawElements` or `drawArrays` to draw lines.  
    /// Each set of two vertices is treated as a separate line segment.
    abstract LINE_LOOP: GLenum
    /// Passed to `drawElements` or `drawArrays` to draw a connected group of line segments from the first vertex to the last.
    abstract LINE_STRIP: GLenum
    /// Passed to `drawElements` or `drawArrays` to draw triangles.  
    /// Each set of three vertices creates a separate triangle.
    abstract TRIANGLES: GLenum
    /// Passed to `drawElements` or `drawArrays` to draw a connected group of triangles.
    abstract TRIANGLE_STRIP: GLenum
    /// Passed to `drawElements` or `drawArrays` to draw a connected group of triangles.  
    /// Each vertex connects to the previous and the first vertex in the fan.
    abstract TRIANGLE_FAN: GLenum
    abstract ACTIVE_ATTRIBUTES: GLenum
    abstract ACTIVE_TEXTURE: GLenum
    abstract ACTIVE_UNIFORMS: GLenum
    abstract ALIASED_LINE_WIDTH_RANGE: GLenum
    abstract ALIASED_POINT_SIZE_RANGE: GLenum
    abstract ALPHA: GLenum
    abstract ALPHA_BITS: GLenum
    abstract ALWAYS: GLenum
    abstract ARRAY_BUFFER: GLenum
    abstract ARRAY_BUFFER_BINDING: GLenum
    abstract ATTACHED_SHADERS: GLenum
    abstract BACK: GLenum
    abstract BLEND: GLenum
    abstract BLEND_COLOR: GLenum
    abstract BLEND_DST_ALPHA: GLenum
    abstract BLEND_DST_RGB: GLenum
    abstract BLEND_EQUATION: GLenum
    abstract BLEND_EQUATION_ALPHA: GLenum
    abstract BLEND_EQUATION_RGB: GLenum
    abstract BLEND_SRC_ALPHA: GLenum
    abstract BLEND_SRC_RGB: GLenum
    abstract BLUE_BITS: GLenum
    abstract BOOL: GLenum
    abstract BOOL_VEC2: GLenum
    abstract BOOL_VEC3: GLenum
    abstract BOOL_VEC4: GLenum
    abstract BROWSER_DEFAULT_WEBGL: GLenum
    abstract BUFFER_SIZE: GLenum
    abstract BUFFER_USAGE: GLenum
    abstract BYTE: GLenum
    abstract CCW: GLenum
    abstract CLAMP_TO_EDGE: GLenum
    abstract COLOR_ATTACHMENT0: GLenum
    abstract COLOR_CLEAR_VALUE: GLenum
    abstract COLOR_WRITEMASK: GLenum
    abstract COMPILE_STATUS: GLenum
    abstract COMPRESSED_TEXTURE_FORMATS: GLenum
    abstract CONSTANT_ALPHA: GLenum
    abstract CONSTANT_COLOR: GLenum
    abstract CONTEXT_LOST_WEBGL: GLenum
    abstract CULL_FACE: GLenum
    abstract CULL_FACE_MODE: GLenum
    abstract CURRENT_PROGRAM: GLenum
    abstract CURRENT_VERTEX_ATTRIB: GLenum
    abstract CW: GLenum
    abstract DECR: GLenum
    abstract DECR_WRAP: GLenum
    abstract DELETE_STATUS: GLenum
    abstract DEPTH_ATTACHMENT: GLenum
    abstract DEPTH_BITS: GLenum
    abstract DEPTH_CLEAR_VALUE: GLenum
    abstract DEPTH_COMPONENT: GLenum
    abstract DEPTH_COMPONENT16: GLenum
    abstract DEPTH_FUNC: GLenum
    abstract DEPTH_RANGE: GLenum
    abstract DEPTH_STENCIL: GLenum
    abstract DEPTH_STENCIL_ATTACHMENT: GLenum
    abstract DEPTH_TEST: GLenum
    abstract DEPTH_WRITEMASK: GLenum
    abstract DITHER: GLenum
    abstract DONT_CARE: GLenum
    abstract DST_ALPHA: GLenum
    abstract DST_COLOR: GLenum
    abstract DYNAMIC_DRAW: GLenum
    abstract ELEMENT_ARRAY_BUFFER: GLenum
    abstract ELEMENT_ARRAY_BUFFER_BINDING: GLenum
    abstract EQUAL: GLenum
    abstract FASTEST: GLenum
    abstract FLOAT: GLenum
    abstract FLOAT_MAT2: GLenum
    abstract FLOAT_MAT3: GLenum
    abstract FLOAT_MAT4: GLenum
    abstract FLOAT_VEC2: GLenum
    abstract FLOAT_VEC3: GLenum
    abstract FLOAT_VEC4: GLenum
    abstract FRAGMENT_SHADER: GLenum
    abstract FRAMEBUFFER: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_OBJECT_NAME: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE: GLenum
    abstract FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL: GLenum
    abstract FRAMEBUFFER_BINDING: GLenum
    abstract FRAMEBUFFER_COMPLETE: GLenum
    abstract FRAMEBUFFER_INCOMPLETE_ATTACHMENT: GLenum
    abstract FRAMEBUFFER_INCOMPLETE_DIMENSIONS: GLenum
    abstract FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT: GLenum
    abstract FRAMEBUFFER_UNSUPPORTED: GLenum
    abstract FRONT: GLenum
    abstract FRONT_AND_BACK: GLenum
    abstract FRONT_FACE: GLenum
    abstract FUNC_ADD: GLenum
    abstract FUNC_REVERSE_SUBTRACT: GLenum
    abstract FUNC_SUBTRACT: GLenum
    abstract GENERATE_MIPMAP_HINT: GLenum
    abstract GEQUAL: GLenum
    abstract GREATER: GLenum
    abstract GREEN_BITS: GLenum
    abstract HIGH_FLOAT: GLenum
    abstract HIGH_INT: GLenum
    abstract IMPLEMENTATION_COLOR_READ_FORMAT: GLenum
    abstract IMPLEMENTATION_COLOR_READ_TYPE: GLenum
    abstract INCR: GLenum
    abstract INCR_WRAP: GLenum
    abstract INT: GLenum
    abstract INT_VEC2: GLenum
    abstract INT_VEC3: GLenum
    abstract INT_VEC4: GLenum
    abstract INVALID_ENUM: GLenum
    abstract INVALID_FRAMEBUFFER_OPERATION: GLenum
    abstract INVALID_OPERATION: GLenum
    abstract INVALID_VALUE: GLenum
    abstract INVERT: GLenum
    abstract KEEP: GLenum
    abstract LEQUAL: GLenum
    abstract LESS: GLenum
    abstract LINEAR: GLenum
    abstract LINEAR_MIPMAP_LINEAR: GLenum
    abstract LINEAR_MIPMAP_NEAREST: GLenum
    abstract LINE_WIDTH: GLenum
    abstract LINK_STATUS: GLenum
    abstract LOW_FLOAT: GLenum
    abstract LOW_INT: GLenum
    abstract LUMINANCE: GLenum
    abstract LUMINANCE_ALPHA: GLenum
    abstract MAX_COMBINED_TEXTURE_IMAGE_UNITS: GLenum
    abstract MAX_CUBE_MAP_TEXTURE_SIZE: GLenum
    abstract MAX_FRAGMENT_UNIFORM_VECTORS: GLenum
    abstract MAX_RENDERBUFFER_SIZE: GLenum
    abstract MAX_TEXTURE_IMAGE_UNITS: GLenum
    abstract MAX_TEXTURE_SIZE: GLenum
    abstract MAX_VARYING_VECTORS: GLenum
    abstract MAX_VERTEX_ATTRIBS: GLenum
    abstract MAX_VERTEX_TEXTURE_IMAGE_UNITS: GLenum
    abstract MAX_VERTEX_UNIFORM_VECTORS: GLenum
    abstract MAX_VIEWPORT_DIMS: GLenum
    abstract MEDIUM_FLOAT: GLenum
    abstract MEDIUM_INT: GLenum
    abstract MIRRORED_REPEAT: GLenum
    abstract NEAREST: GLenum
    abstract NEAREST_MIPMAP_LINEAR: GLenum
    abstract NEAREST_MIPMAP_NEAREST: GLenum
    abstract NEVER: GLenum
    abstract NICEST: GLenum
    abstract NONE: GLenum
    abstract NOTEQUAL: GLenum
    abstract NO_ERROR: GLenum
    abstract ONE: GLenum
    abstract ONE_MINUS_CONSTANT_ALPHA: GLenum
    abstract ONE_MINUS_CONSTANT_COLOR: GLenum
    abstract ONE_MINUS_DST_ALPHA: GLenum
    abstract ONE_MINUS_DST_COLOR: GLenum
    abstract ONE_MINUS_SRC_ALPHA: GLenum
    abstract ONE_MINUS_SRC_COLOR: GLenum
    abstract OUT_OF_MEMORY: GLenum
    abstract PACK_ALIGNMENT: GLenum
    abstract POLYGON_OFFSET_FACTOR: GLenum
    abstract POLYGON_OFFSET_FILL: GLenum
    abstract POLYGON_OFFSET_UNITS: GLenum
    abstract RED_BITS: GLenum
    abstract RENDERBUFFER: GLenum
    abstract RENDERBUFFER_ALPHA_SIZE: GLenum
    abstract RENDERBUFFER_BINDING: GLenum
    abstract RENDERBUFFER_BLUE_SIZE: GLenum
    abstract RENDERBUFFER_DEPTH_SIZE: GLenum
    abstract RENDERBUFFER_GREEN_SIZE: GLenum
    abstract RENDERBUFFER_HEIGHT: GLenum
    abstract RENDERBUFFER_INTERNAL_FORMAT: GLenum
    abstract RENDERBUFFER_RED_SIZE: GLenum
    abstract RENDERBUFFER_STENCIL_SIZE: GLenum
    abstract RENDERBUFFER_WIDTH: GLenum
    abstract RENDERER: GLenum
    abstract REPEAT: GLenum
    abstract REPLACE: GLenum
    abstract RGB: GLenum
    abstract RGB565: GLenum
    abstract RGB5_A1: GLenum
    abstract RGBA: GLenum
    abstract RGBA4: GLenum
    abstract SAMPLER_2D: GLenum
    abstract SAMPLER_CUBE: GLenum
    abstract SAMPLES: GLenum
    abstract SAMPLE_ALPHA_TO_COVERAGE: GLenum
    abstract SAMPLE_BUFFERS: GLenum
    abstract SAMPLE_COVERAGE: GLenum
    abstract SAMPLE_COVERAGE_INVERT: GLenum
    abstract SAMPLE_COVERAGE_VALUE: GLenum
    abstract SCISSOR_BOX: GLenum
    abstract SCISSOR_TEST: GLenum
    abstract SHADER_TYPE: GLenum
    abstract SHADING_LANGUAGE_VERSION: GLenum
    abstract SHORT: GLenum
    abstract SRC_ALPHA: GLenum
    abstract SRC_ALPHA_SATURATE: GLenum
    abstract SRC_COLOR: GLenum
    abstract STATIC_DRAW: GLenum
    abstract STENCIL_ATTACHMENT: GLenum
    abstract STENCIL_BACK_FAIL: GLenum
    abstract STENCIL_BACK_FUNC: GLenum
    abstract STENCIL_BACK_PASS_DEPTH_FAIL: GLenum
    abstract STENCIL_BACK_PASS_DEPTH_PASS: GLenum
    abstract STENCIL_BACK_REF: GLenum
    abstract STENCIL_BACK_VALUE_MASK: GLenum
    abstract STENCIL_BACK_WRITEMASK: GLenum
    abstract STENCIL_BITS: GLenum
    abstract STENCIL_CLEAR_VALUE: GLenum
    abstract STENCIL_FAIL: GLenum
    abstract STENCIL_FUNC: GLenum
    abstract STENCIL_INDEX8: GLenum
    abstract STENCIL_PASS_DEPTH_FAIL: GLenum
    abstract STENCIL_PASS_DEPTH_PASS: GLenum
    abstract STENCIL_REF: GLenum
    abstract STENCIL_TEST: GLenum
    abstract STENCIL_VALUE_MASK: GLenum
    abstract STENCIL_WRITEMASK: GLenum
    abstract STREAM_DRAW: GLenum
    abstract SUBPIXEL_BITS: GLenum
    abstract TEXTURE: GLenum
    abstract TEXTURE0: GLenum
    abstract TEXTURE1: GLenum
    abstract TEXTURE10: GLenum
    abstract TEXTURE11: GLenum
    abstract TEXTURE12: GLenum
    abstract TEXTURE13: GLenum
    abstract TEXTURE14: GLenum
    abstract TEXTURE15: GLenum
    abstract TEXTURE16: GLenum
    abstract TEXTURE17: GLenum
    abstract TEXTURE18: GLenum
    abstract TEXTURE19: GLenum
    abstract TEXTURE2: GLenum
    abstract TEXTURE20: GLenum
    abstract TEXTURE21: GLenum
    abstract TEXTURE22: GLenum
    abstract TEXTURE23: GLenum
    abstract TEXTURE24: GLenum
    abstract TEXTURE25: GLenum
    abstract TEXTURE26: GLenum
    abstract TEXTURE27: GLenum
    abstract TEXTURE28: GLenum
    abstract TEXTURE29: GLenum
    abstract TEXTURE3: GLenum
    abstract TEXTURE30: GLenum
    abstract TEXTURE31: GLenum
    abstract TEXTURE4: GLenum
    abstract TEXTURE5: GLenum
    abstract TEXTURE6: GLenum
    abstract TEXTURE7: GLenum
    abstract TEXTURE8: GLenum
    abstract TEXTURE9: GLenum
    abstract TEXTURE_2D: GLenum
    abstract TEXTURE_BINDING_2D: GLenum
    abstract TEXTURE_BINDING_CUBE_MAP: GLenum
    abstract TEXTURE_CUBE_MAP: GLenum
    abstract TEXTURE_CUBE_MAP_NEGATIVE_X: GLenum
    abstract TEXTURE_CUBE_MAP_NEGATIVE_Y: GLenum
    abstract TEXTURE_CUBE_MAP_NEGATIVE_Z: GLenum
    abstract TEXTURE_CUBE_MAP_POSITIVE_X: GLenum
    abstract TEXTURE_CUBE_MAP_POSITIVE_Y: GLenum
    abstract TEXTURE_CUBE_MAP_POSITIVE_Z: GLenum
    abstract TEXTURE_MAG_FILTER: GLenum
    abstract TEXTURE_MIN_FILTER: GLenum
    abstract TEXTURE_WRAP_S: GLenum
    abstract TEXTURE_WRAP_T: GLenum
    abstract UNPACK_ALIGNMENT: GLenum
    abstract UNPACK_COLORSPACE_CONVERSION_WEBGL: GLenum
    abstract UNPACK_FLIP_Y_WEBGL: GLenum
    abstract UNPACK_PREMULTIPLY_ALPHA_WEBGL: GLenum
    abstract UNSIGNED_BYTE: GLenum
    abstract UNSIGNED_INT: GLenum
    abstract UNSIGNED_SHORT: GLenum
    abstract UNSIGNED_SHORT_4_4_4_4: GLenum
    abstract UNSIGNED_SHORT_5_5_5_1: GLenum
    abstract UNSIGNED_SHORT_5_6_5: GLenum
    abstract VALIDATE_STATUS: GLenum
    abstract VENDOR: GLenum
    abstract VERSION: GLenum
    abstract VERTEX_ATTRIB_ARRAY_BUFFER_BINDING: GLenum
    abstract VERTEX_ATTRIB_ARRAY_ENABLED: GLenum
    abstract VERTEX_ATTRIB_ARRAY_NORMALIZED: GLenum
    abstract VERTEX_ATTRIB_ARRAY_POINTER: GLenum
    abstract VERTEX_ATTRIB_ARRAY_SIZE: GLenum
    abstract VERTEX_ATTRIB_ARRAY_STRIDE: GLenum
    abstract VERTEX_ATTRIB_ARRAY_TYPE: GLenum
    abstract VERTEX_SHADER: GLenum
    abstract VIEWPORT: GLenum
    abstract ZERO: GLenum

namespace WebGL

open Fable.Core
open HTML.Types
open WebGL.RenderingContext

[<AutoOpen>]
module WebGLRenderingContext =

    type HTMLCanvasElement with
        [<Emit "$0.getContext('webgl',$1)">]
        member __.getContext_webgl(): WebGLRenderingContext = jsNative

    let [<Global>] WebGLRenderingContext: WebGLRenderingContextType = jsNative