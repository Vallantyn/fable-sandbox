/// App Module
module App

open Fable.Core.JsInterop // import
open Core.Systems // SystemManager
open Systems.Renderer // Window
open WebGL2.RenderingContext // WebGL2

let window = SystemManager.Window

window.Width <- int Browser.Dom.window.innerWidth
window.Height <- int Browser.Dom.window.innerHeight

let gl = SystemManager.Renderer
let GL = gl.As<RenderingContext>()

let sharedVertexShader =
    gl
    |> CreateVertexShaderWithSource
        (importDefault "${outDir}/../shaders/vertex.glsl")

let circleProgram =
    gl
    |> CreateProgramWithShaders
        sharedVertexShader
        (gl |> CreateFragmentShaderWithSource (importDefault "${outDir}/../shaders/circle.glsl"))

let rectProgram =
    gl
    |> CreateProgramWithShaders
        sharedVertexShader
        (gl |> CreateFragmentShaderWithSource (importDefault "${outDir}/../shaders/rectangle.glsl"))

// let program =
//     gl
//     |> CreateProgramWithSources
//         (importDefault "${outDir}/../shaders/vertex.glsl")
//         (importDefault "${outDir}/../shaders/shader.frag")
//     |> CheckProgram

let uCirclePosition = circleProgram.GetUniformLocation "u_position"
let uCircleRadius = circleProgram.GetUniformLocation "u_radius"
let uCircleColor = circleProgram.GetUniformLocation "u_color"

let uRectPosition = rectProgram.GetUniformLocation "u_position"
let uRectSize = rectProgram.GetUniformLocation "u_size"
let uRectColor = rectProgram.GetUniformLocation "u_color"

let uCircleResolution = circleProgram.GetUniformLocation "u_resolution"
let uRectResolution = rectProgram.GetUniformLocation "u_resolution"

// let positionBuffer =
//     gl
//     |> CreateBuffer
//     |> BindBuffer EBufferTarget.Array
//
// let positions = [|
//     0f;              0f;// 10f; 20f;
//     single window.Width;   0f;// 80f; 20f;
//     0f;              single window.Height;// 10f; 30f;
//     0f;              single window.Height;// 10f; 30f;
//     single window.Width;   0f;// 80f; 20f;
//     single window.Width;   single window.Height;// 80f; 30f;
// |]
//
// positionBuffer.Data (EBufferTarget.Array, positions, EBufferUsage.StaticDraw)

let vao =
     gl
     |> CreateVertexArray
     |> BindVertexArray

// let aPosition =
//     program.GetAttributeLocation "a_position"
//     |> EnableAttributeLocation
//     |> VertexAttributePointer 2 GL.FLOAT false 0 0

GL.enable GL.BLEND
GL.blendFunc (GL.SRC_ALPHA, GL.ONE_MINUS_SRC_ALPHA)

gl
|> Viewport 0 0 window.Width window.Height
|> ClearWithColor 0.5 0.5 0.5 1.0
|> ignore

circleProgram.Use ()
uCircleResolution.Float2 <- (window.Width, window.Height)

uCirclePosition.Float2  <- (50, 50)
uCircleRadius.Float     <- 50
uCircleColor.Float4     <- (1, 0, 0, 1)

vao.Bind ()

gl
|> DrawArrays ERenderingPrimitive.Triangles 0 6
|> ignore

rectProgram.Use ()
uRectResolution.Float2 <- (window.Width, window.Height)

uRectPosition.Float2   <- (75, 75)
uRectSize.Float2       <- (50, 50)
uRectColor.Float4      <- (0, 1, 0, 1)

vao.Bind ()

gl
|> DrawArrays ERenderingPrimitive.TriangleFan 0 4
|> ignore