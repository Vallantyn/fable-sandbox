namespace Systems.Renderer

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

// [<Fable.Core.Mangle>]
type IRenderer =
    inherit IWrapper

    /// Clear the Screen
    abstract member Viewport: int * int * int * int -> unit

    abstract member ClearColor: float * float * float * float -> unit
    abstract member ClearDepth: float -> unit
    abstract member ClearStencil: int -> unit
    abstract member Clear: EBufferBit -> unit

    abstract member DrawArrays: ERenderingPrimitive * int * int -> unit

    /// Creates a new Shader
    abstract member CreateShader: EShaderType -> IShader
    abstract member DeleteShader: IShader -> unit

    abstract member CreateProgram: unit -> IProgram
    abstract member DeleteProgram: IProgram -> unit

    abstract member CreateBuffer: unit -> IBuffer
    abstract member DeleteBuffer: IBuffer -> unit

    abstract member BufferData: uint * int array * uint -> unit
    abstract member BufferData: uint * uint array * uint -> unit
    abstract member BufferData: uint * single array * uint -> unit
    abstract member BufferData: uint * float array * uint -> unit

    abstract member CreateFrameBuffer: unit -> IFrameBuffer
    abstract member DeleteFrameBuffer: IFrameBuffer -> unit

    abstract member CreateRenderBuffer: unit -> IRenderBuffer
    abstract member DeleteRenderBuffer: IRenderBuffer -> unit

    abstract member CreateTexture: unit -> ITexture
    abstract member DeleteTexture: ITexture -> unit

    abstract member CreateSampler: unit -> ISampler
    abstract member DeleteSampler: ISampler -> unit

    abstract member CreateVertexArray: unit -> IVertexArray
    abstract member DeleteVertexArray: IVertexArray -> unit

    abstract member CreateQuery: unit -> IQuery
    abstract member DeleteQuery: IQuery -> unit

    abstract member CreateTransformFeedback: unit -> ITransformFeedback
    abstract member DeleteTransformFeedback: ITransformFeedback -> unit

[<AutoOpen>]
module Renderer =
    type IRenderer with
        member My.ClearWithColor (r, g, b, ?a) =
            let a = defaultArg a 0.
            My.ClearColor (r, g, b, a)
            My.Clear EBufferBit.Color

        // member My.ClearColor (c:System.Drawing.Color) =
        //     let r = float (c.R / 0xFFuy)
        //     let g = float (c.G / 0xFFuy)
        //     let b = float (c.B / 0xFFuy)
        //     let a = float (c.A / 0xFFuy)
        //     My.ClearColor (r, g, b, a)
        //
        // member My.ClearWithColor (c:System.Drawing.Color) =
        //     My.ClearColor c
        //     My.Clear EBufferBit.Color

    let CreateShader etype source (r:IRenderer) =
        r.CreateShader etype
        |> SetSource source
        |> Compile

    let CreateVertexShader source (r:IRenderer) = r |> CreateShader EShaderType.Vertex source
    let CreateFragmentShader source (r:IRenderer) = r |> CreateShader EShaderType.Fragment source
