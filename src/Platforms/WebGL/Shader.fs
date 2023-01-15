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

        member _.Compile () =
            data
            |> Option.iter GL.compileShader
            
        member _.Delete() =
            data
            |> GL.deleteShader

        member _.GetParameter param =
            data
            |> Option.map (
                fun shader ->
                    match GL.getShaderParameter (shader, uint param) with
                    | U2.Case1 c -> Choice1Of2 (LanguagePrimitives.EnumOfValue c)
                    | U2.Case2 c -> Choice2Of2 c
            )
            |> Option.defaultValue (Choice2Of2 false)

        member _.Source
            with get ()              =
                data
                |> Option.bind GL.getShaderSource
                |> Option.defaultValue ""

            and  set (source:string) =
                data
                |> Option.iter (fun shader -> GL.shaderSource (shader, source))

        member _.bIsShader          = GL.isShader data

        member _.InfoLog =
            data
            |> Option.bind GL.getShaderInfoLog
            |> Option.defaultValue ""

        member My.ShaderType        = My.GetShaderType ()
        member My.bCompiled    = My.GetCompileStatus ()
        member My.bDeleted     = My.GetDeleteStatus ()
