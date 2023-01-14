namespace Platforms.WebGL

open Systems.Renderer

open WebGL.Types
open WebGL2.RenderingContext

open Fable.Core

type Shader (renderer:IRenderer, shader:WebGLShader option) =
    let GL = renderer.As<RenderingContext>();

    let data = shader

    new (renderer:IRenderer, shaderType:EShaderType) =
        let shader =
            renderer.As<RenderingContext>()
                    .createShader (uint shaderType)
        Shader (renderer, shader)

    interface IShader with
        member _.Try () =
            data
            |> Option.map (fun s -> s)

        member _.IsShader() = GL.isShader data
        member _.Compile () =
            data
            |> Option.iter GL.compileShader

        member _.GetInfoLog() =
            data
            |> Option.bind GL.getShaderInfoLog
            |> Option.defaultValue ""

        member _.GetParameter param =
            data
            |> Option.map (
                fun shader ->
                    match GL.getShaderParameter (shader, param) with
                    | U2.Case1 c -> Choice1Of2 c
                    | U2.Case2 c -> Choice2Of2 c
            )
            |> Option.defaultValue (Choice2Of2 false)

        member _.GetSource () =
            data
            |> Option.bind GL.getShaderSource
            |> Option.defaultValue ""

        member _.SetSource source =
            data
            |> Option.iter (fun shader -> GL.shaderSource (shader, source))

        member _.Source
            with get ()              =
                data
                |> Option.bind GL.getShaderSource
                |> Option.defaultValue ""

            and  set (source:string) =
                data
                |> Option.iter (fun shader -> GL.shaderSource (shader, source))
