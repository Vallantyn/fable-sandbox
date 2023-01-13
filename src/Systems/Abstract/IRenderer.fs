namespace Systems

/// Types for the IRenderer System
module Renderer = 

    /// Constants passed to `GL.clear()` to clear buffer masks.
    [<System.Flags>]
    type EBufferBit =
    /// Passed to clear to `clear` the current depth buffer.
    | Depth     = 0x00000100u
    /// Passed to clear to `clear` the current stencil buffer.
    | Stencil   = 0x00000400u
    /// Passed to clear to `clear` the current color buffer.
    | Color     = 0x00004000u

    /// Constants passed to `GL.drawElements()` or `GL.drawArrays()` to specify what kind of primitive to render.
    type ERenderingPrimitive =
    /// Passed to `drawElements` or `drawArrays` to draw single points.
    | Points        = 0x0000u
    /// Passed to `drawElements` or `drawArrays` to draw lines.  
    /// Each vertex connects to the one after it.
    | Lines         = 0x0001u
    /// Passed to `drawElements` or `drawArrays` to draw lines.  
    /// Each set of two vertices is treated as a separate line segment.
    | LineLoop      = 0x0002u
    /// Passed to `drawElements` or `drawArrays` to draw a connected group of lines segments from the first vertex to the last.
    | LineStrip     = 0x0003u
    /// Passed to `drawElements` or `drawArrays` to draw triangles.  
    /// Each set of three vertices creates a separate triangle.
    | Triangles     = 0x0004u
    /// Passed to `drawElements` or `drawArrays` to draw a connected group of triangles.
    | TriangleStrip = 0x0005u
    /// Passed to `drawElements` or `drawArrays` to draw a connected group of triangles.  
    /// Each vertex connects to the previous and the first vertex in the fan.
    | TriangleFan   = 0x0006u

    /// Constants passed to `GL.blendFunc()` or `GL.blendFuncSeparate()` to specify the blending mode (for both, RBG and alpha, or separately).
    type EBlendingMode =
    /// Passed to `blendFunc` or `blendFuncSeparate` to turn off a component.
    | Zero                  = 0u
    /// Passed to `blendFunc` or `blendFuncSeparate` to turn on a component.
    | One                   = 1u
    /// Passed to `blendFunc` or `blendFuncSeparate` to multiply a component by the source elements color.
    | SrcColor              = 0x0300u
    /// Passed to `blendFunc` or `blendFuncSeparate` to multiply a component by one minus the source elements color.
    | OneMinusSrcColor      = 0x0301u
    /// Passed to `blendFunc` or `blendFuncSeparate` to multiply a component by the source's alpha.
    | SrcAlpha              = 0x0302u
    /// Passed to `blendFunc` or `blendFuncSeparate` to multiply a component by one minus the source's alpha.
    | OneMinusSrcAlpha      = 0x0303u
    /// Passed to `blendFunc` or `blendFuncSeparate` to multiply a component by the destination's alpha.
    | DstAlpha              = 0x0304u
    /// Passed to `blendFunc` or `blendFuncSeparate` to multiply a component by one minus the destination's alpha.
    | OneMinusDstAlpha      = 0x0305u
    /// Passed to `blendFunc` or `blendFuncSeparate` to multiply a component by the destination's color.
    | DstColor              = 0x0306u
    /// Passed to `blendFunc` or `blendFuncSeparate` to multiply a component by one minus the destination's color.
    | OneMinusDstColor      = 0x0307u
    /// Passed to `blendFunc` or `blendFuncSeparate` to multiply a component by the minimum of source's alpha or one minus the destination's alpha.
    | SrcAlphaSaturate      = 0x0308u
    /// Passed to `blendFunc` or `blendFuncSeparate` to specify a constant color blend function.
    | ConstantColor         = 0x8001u
    /// Passed to `blendFunc` or `blendFuncSeparate` to specify one minus a constant color blend function.
    | OneMinusConstantColor = 0x8002u
    /// Passed to `blendFunc` or `blendFuncSeparate` to specify a constant alpha blend function.
    | ConstantAlpha         = 0x8003u
    /// Passed to `blendFunc` or `blendFuncSeparate` to specify one minus a constant alpha blend function.
    | OneMinusConstantAlpha = 0x8004u

    /// Constants passed to `GL.blendEquation()` or `GL.blendEquationSeparate()` to control how the blending is calculated (for both, RBG and alpha, or separately).
    type EBlendingEquation =
    /// Passed to `blendEquation` or `blendEquationSeparate` to set an addition blend function.
    | FuncAdd               = 0x8006u
    /// Passed to `blendEquation` or `blendEquationSeparate` to specify a subtraction blend function (source - destination).
    | FuncSubtract          = 0x800Au
    /// Passed to `blendEquation` or `blendEquationSeparate` to specify a reverse subtraction blend function (destination - source).
    | FuncReverseSubtract   = 0x800Bu
    
    /// Constants passed to `GL.getParameter()` to specify what information to return.
    type EGLParameter =
    | TODO = 0u

    /// GL.createShader(..., source)
    type EShaderType =
    /// GL.FRAGMENT_SHADER
    | Fragment  = 0x8B30u
    /// GL.VERTEX_SHADER
    | Vertex    = 0x8B31u
    
    type EShaderParameter =
    | Delete    = 0x8B80u
    | Compile   = 0x8B81u

    type EParameter =
    // WebGL 1
    | ActiveTexture
    | AliasedLineWidthRange
    | AliasedPointSizeRange
    | AlphaBits
    | ArrayBufferBinding
    | Blend
    | BlendColor
    | BlendDstRGB
    | BlendDstAlpha
    | BlendEquation
    | BlendEquationRGB
    | BlendEquationAlpha
    | BlendSrcRGB
    | BlendSrcAlpha
    | BlueBits
    | ColorClearValue
    | ColorWriteMask
    | CompressedTextureFormat
    | CullFace
    | CullFaceMode
    | CurrentProgram
    | DepthBits
    | DepthClearValue
    | DepthFunc
    | DepthRange
    | DepthTest
    | DepthWriteMask
    | Dither
    | ElementArrayBufferBinding
    | FramebufferBinding
    | FrontFace
    | GenerateMipmapHint
    | GreenBits
    | ImplementationColorReadFormat
    | ImplementationColorReadType
    | LineWidth
    | MaxCombinedTextureImageUnits
    | MaxCubeMapTextureSize
    | MaxFragmentUniformVectors
    | MaxRenderbufferSize
    | MaxTextureImageUnits
    | MaxTextureSize
    | MaxVaryingVectors
    | MaxVertexAttribs
    | MaxVertexTextureImageUnits
    | MaxVertexUniformVectors
    | MaxViewportDims
    | PackAlignment
    | PolygonOffsetFactor
    | PolygonOffsetFill
    | PolygonOffsetUnits
    | RedBits
    | RenderbufferBindings
    | Renderer
    | SampleBuffers
    | SampleCoverageInvert
    | SampleCoverageValue
    | Samples
    | ScissorBox
    | ScissorTest
    | ShadingLanguageVersion
    | StencilBackFail
    | StencilBackFunc
    | StencilBackPassDepthFail
    | StencilBackPassDepthPass
    | StencilBackRef
    | StencilBackValueMask
    | StencilBackWritemask
    | StencilBits
    | StencilClearValue
    | StencilFail
    | StencilFunc
    | StencilPassDepthFail
    | StencilPassDepthPass
    | StencilRef
    | StencilTest
    | StencilValueMask
    | StencilWriteMask
    | SubpixelsBits
    | TextureBindingCubeMap
    | UnpackAlignment
    | UnpackColorspaceConversionWebGL
    | UnpackFlipYWebGL
    | UnpackPremultiplyAlphaWebGL
    | Vendor
    | Version
    | Viewport
    // WebGL 2
    | CopyReadBufferBinding
    | CopyWriteBufferBinding
    // | DrawBuffer // Note: needs too many shit
    // Extensions
    | Ext

    type IWrapper =
        abstract member Get: unit -> obj

    type IOptionWrapper =
        abstract member Try: unit -> obj option

    /// Represent a Vertex/Fragment Shader
    type IShader =
        inherit IOptionWrapper
        abstract member IsShader: unit -> bool
        abstract member GetInfoLog: unit -> string
        abstract member GetParameter: uint -> Choice<uint, bool>
        abstract member GetSource: unit -> string
        abstract member SetSource: string -> unit
        abstract member Source: string with get, set

    /// Part of the WebGL API and represents the information returned by calling the `WebGLRenderingContext.getActiveAttrib()` and `WebGLRenderingContext.getActiveUniform()` methods.
    type IActiveInfo =
        inherit IOptionWrapper
        abstract member Name: string with get
        abstract member Size: int with get
        abstract member Type: uint with get
        // abstract name: string
        // abstract size: GLint
        // abstract ``type``: GLenum

    /// Part of the WebGL API and represents the location of a uniform variable in a shader program.
    type IUniformLocation =
        inherit IOptionWrapper
        abstract member SetFloat: single -> unit
        abstract member SetFloat: single * single -> unit
        abstract member SetFloat: single * single * single -> unit
        abstract member SetFloat: single * single * single * single -> unit
        abstract member SetInt: int -> unit
        abstract member SetInt: int * int -> unit
        abstract member SetInt: int * int * int -> unit
        abstract member SetInt: int * int * int * int -> unit

    /// Represent a Shader Program
    type IProgram =
        inherit IOptionWrapper
        abstract member IsProgram: unit -> bool

        abstract member AttachShader: IShader -> unit
        abstract member DetachShader: IShader -> unit
        abstract member GetAttachedShaders: unit -> IShader array

        abstract member Link: unit -> unit
        abstract member Use: unit -> unit
        abstract member Validate: unit -> unit

        abstract member GetInfoLog: unit -> string

        // Note: overload for each return type ?
        // Note: Create each GetXXX() ?
        abstract member GetParameter: glenum:uint -> obj option

        abstract member GetActiveAttribute: uint -> IActiveInfo
        abstract member GetAttributeLocation: string -> int
        abstract member BindAttributeLocation: uint * string -> unit

        // Note: overload for each return type ?
        abstract member GetUniform: IUniformLocation -> obj option
        abstract member GetActiveUniform: uint -> IActiveInfo
        abstract member GetUniformLocation: string -> IUniformLocation

open Renderer

type IRenderer =
    inherit Renderer.IWrapper
    /// Clear the Screen
    abstract member Clear: unit -> unit // todo: color as param ?
    /// Creates a new Shader
    abstract member CreateShader: glenum:uint -> Renderer.IShader
    abstract member DeleteShader: Renderer.IShader -> unit
    /// Creates a new Program from a Vertex & Fragment shader
    abstract member CreateProgram: unit -> Renderer.IProgram
    abstract member DeleteProgram: Renderer.IProgram -> unit
    
[<AutoOpen>]    
module RendererExtensions =
    type Renderer.IWrapper with
        member My.As<'T>() = My.Get() :?> 'T

    type Renderer.IOptionWrapper with
        member My.TryAs<'T>() =
            My.Try()
            |> Option.map (fun o -> o :?> 'T)

module Shader =
    let inline SetSource source (s:IShader) = s.Source <- source; s
    let inline Compile (s:IShader) = (* s.Compile(); *) s

module Program =
    let inline AttachShader (s:IShader) (p:IProgram) = p.AttachShader s; p
    let inline Link (p:IProgram) = p.Link(); p
