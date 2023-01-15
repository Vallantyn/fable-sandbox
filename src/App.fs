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

let program =
    gl
    |> CreateProgramWithSources
        (importDefault "${outDir}/../shaders/shader.vert")
        (importDefault "${outDir}/../shaders/shader.frag")
    |> CheckProgram

let uResolution = program.GetUniformLocation "u_resolution"

let positionBuffer =
    gl
    |> CreateBuffer
    |> BindBuffer EBufferTarget.Array

let positions = [|
    0f;              0f;// 10f; 20f;
    single window.Width;   0f;// 80f; 20f;
    0f;              single window.Height;// 10f; 30f;
    0f;              single window.Height;// 10f; 30f;
    single window.Width;   0f;// 80f; 20f;
    single window.Width;   single window.Height;// 80f; 30f;
|]

positionBuffer.Data (EBufferTarget.Array, positions, EBufferUsage.StaticDraw)

let vao =
     gl
     |> CreateVertexArray
     |> BindVertexArray

let aPosition =
    program.GetAttributeLocation "a_position"
    |> EnableAttributeLocation
    |> VertexAttributePointer 2 GL.FLOAT false 0 0

gl
|> Viewport 0 0 window.Width window.Height
|> ClearWithColor 0.5 0.5 0.5 1.0
|> ignore

program.Use ()
uResolution.Float2 <- (window.Width, window.Height)

vao.Bind ()

gl
|> DrawArrays ERenderingPrimitive.Triangles 0 6
|> ignore
