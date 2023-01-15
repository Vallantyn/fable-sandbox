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
    abstract Viewport: x:int * y:int * width:int * height:int -> unit

    abstract ClearColor:    r:float * g:float * b:float * a:float -> unit
    abstract ClearDepth:    depth:float -> unit
    abstract ClearStencil:  stencil:int -> unit
    abstract Clear:         bufferBits:EBufferBit -> unit

    abstract DrawArrays: primitiveType:ERenderingPrimitive * offset:int * count:int -> unit

    /// Creates a new Shader
    abstract CreateShader:              shaderType:EShaderType -> IShader
    abstract CreateProgram:             unit -> IProgram
    abstract CreateBuffer:              unit -> IBuffer
    abstract CreateFrameBuffer:         unit -> IFrameBuffer
    abstract CreateRenderBuffer:        unit -> IRenderBuffer
    abstract CreateTexture:             unit -> ITexture
    abstract CreateSampler:             unit -> ISampler
    abstract CreateVertexArray:         unit -> IVertexArray
    abstract CreateQuery:               unit -> IQuery
    abstract CreateTransformFeedback:   unit -> ITransformFeedback

[<AutoOpen>]
module Renderer =
    type IRenderer with
        member My.ClearWithColor (r, g, b, ?a) =
            let a = defaultArg a 0.
            My.ClearColor (r, g, b, a)
            My.Clear EBufferBit.Color
        member inline _.Delete<'T when 'T: (member Delete: unit -> unit)> (object:'T)   = object.Delete()

    let inline CreateShader shaderType (renderer:IRenderer) = renderer.CreateShader shaderType
    let inline CreateProgram (renderer:IRenderer) = renderer.CreateProgram ()
    let inline CreateBuffer (renderer:IRenderer) = renderer.CreateBuffer () 
    let inline CreateFrameBuffer (renderer:IRenderer) = renderer.CreateFrameBuffer ()
    let inline CreateRenderBuffer (renderer:IRenderer) = renderer.CreateRenderBuffer ()
    let inline CreateTexture (renderer:IRenderer) = renderer.CreateTexture () 
    let inline CreateSampler (renderer:IRenderer) = renderer.CreateSampler () 
    let inline CreateVertexArray (renderer:IRenderer) = renderer.CreateVertexArray ()
    let inline CreateQuery (renderer:IRenderer) = renderer.CreateQuery () 
    let inline CreateTransformFeedback (renderer:IRenderer) = renderer.CreateTransformFeedback ()

    let inline Delete object (r:IRenderer) = r.Delete object

    let inline Viewport x y w h (renderer:IRenderer) = renderer.Viewport (x, y, w, h); renderer
    let inline Clear bufferBits (renderer:IRenderer) = renderer.Clear bufferBits; renderer
    let inline ClearWithColor r g b a (renderer:IRenderer) = renderer.ClearWithColor (r, g, b, a); renderer
    let inline DrawArrays primitiveType offset count (renderer:IRenderer) = renderer.DrawArrays (primitiveType, offset, count); renderer

    let CreateShaderWithSource shaderType shaderSource renderer =
        renderer
        |> CreateShader shaderType
        |> SetShaderSource shaderSource
        |> CompileShader
        |> CheckShader

    let CreateProgramWithShaders vertexShader fragmentShader renderer =
        renderer
        |> CreateProgram
        |> AttachShader vertexShader
        |> AttachShader fragmentShader
        |> LinkProgram

    let CreateVertexShaderWithSource vertexShaderSource renderer =
        renderer
        |> CreateShaderWithSource
            EShaderType.Vertex
            vertexShaderSource

    let CreateFragmentShaderWithSource fragmentShaderSource renderer =
        renderer
        |> CreateShaderWithSource
            EShaderType.Fragment
            fragmentShaderSource

    let CreateProgramWithSources vertexShaderSource fragmentShaderSource renderer =
        renderer
        |> CreateProgramWithShaders
            (renderer |> CreateVertexShaderWithSource vertexShaderSource)
            (renderer |> CreateFragmentShaderWithSource fragmentShaderSource)
