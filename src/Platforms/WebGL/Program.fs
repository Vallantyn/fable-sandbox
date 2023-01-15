namespace Platforms.WebGL

open Fable.Core
open Systems.Renderer
open WebGL.Types
open WebGL2.RenderingContext

type Program (renderer:IRenderer) =
    let renderer = renderer
    let GL = renderer.As<RenderingContext>();

    let data = GL.createProgram ()

    interface IProgram with
        member _.Try () =
            data
            |> Option.map (fun p -> p)

        member _.Delete() = GL.deleteProgram data

        member _.AttachShader shader =
            match data, shader.TryAs<WebGLShader>() with
            | Some program, Some shader -> GL.attachShader (program, shader)
            | _ -> ()
            // _data
            // |> Option.iter (
            //     fun program ->
            //         GL.attachShader (program, shader.TryAs<WebGLShader>())
            // )

        member _.BindAttributeLocation (index, name) =
            data
            |> Option.iter (
                fun program ->
                    GL.bindAttribLocation (program, index, name)
            )

        member _.DetachShader shader =
            match data, shader.TryAs<WebGLShader>() with
            | Some program, Some shader -> GL.detachShader (program, shader)
            | _ -> ()
            // _data
            // |> Option.iter (
            //     fun program ->
            //         GL.detachShader (program, shader.Try())
            // )

        member _.GetActiveAttribute index =
            data
            |> Option.map (
                fun program ->
                    GL.getActiveAttrib (program, index) |> ActiveInfo
            )
            |> Option.defaultValue (ActiveInfo())
            :> IActiveInfo

        member _.GetActiveUniform index =
            data
            |> Option.map (
                fun program ->
                    GL.getActiveUniform (program, index) |> ActiveInfo
            )
            |> Option.defaultValue (ActiveInfo())
            :> IActiveInfo

        member _.GetAttributeLocation name =
            data
            |> Option.map (fun program -> GL.getAttribLocation (program, name))
            |> Option.map (fun location -> AttributeLocation (renderer, location))
            |> Option.defaultValue (AttributeLocation (renderer, -1))
            :> IAttributeLocation

        member _.GetParameter param =
            data
            |> Option.map (
                fun program ->
                    match GL.getProgramParameter (program, uint param) with
                    | U3.Case1 c -> Choice1Of3 c
                    | U3.Case2 c -> Choice2Of3 c
                    | U3.Case3 c -> Choice3Of3 (LanguagePrimitives.EnumOfValue c)
            )
            |> Option.defaultValue (Choice1Of3 false)

        member _.GetUniform location =
            match data, location.TryAs<WebGLUniformLocation>() with
            | Some program, Some uniformLocation -> GL.getUniform (program, uniformLocation)
            | _ -> None
            // |> Option.bind (
            //     fun program ->
            //         GL.getUniform (program, location.TryAs<WebGLUniformLocation>())
            // )

        member _.GetUniformLocation name =
            data
            |> Option.map (
                fun program ->
                    (GL.getUniformLocation (program, name), renderer) |> UniformLocation
            )
            |> Option.defaultValue (UniformLocation(renderer))
            :> IUniformLocation

        member _.Link () =
            data
            |> Option.iter GL.linkProgram

        member _.Use () = GL.useProgram data
        member _.Validate () =
            data
            |> Option.iter GL.validateProgram

        member _.bIsProgram = data |> GL.isProgram

        member _.InfoLog =
            data
            |> Option.bind GL.getProgramInfoLog
            |> Option.defaultValue ""

        member _.AttachedShaders =
            data
            |> Option.bind GL.getAttachedShaders
            |> Option.map (
                fun shaders ->
                    shaders.ToArray ()
                    |> Array.map (fun shader ->
                        Shader (renderer, Some shader)
                        :> IShader
                    )
            )
            |> Option.defaultValue [||]

        member My.bDeleted = My.GetDeleteStatus ()
        member My.bLinked = My.GetLinkStatus ()
        member My.bValidated = My.GetValidateStatus ()
        member My.AttachedShaderCount = My.GetAttachedShaders ()
        member My.ActiveAttributeCount = My.GetActiveAttributes ()
        member My.ActiveUniformCount = My.GetActiveUniforms ()
        member My.TransformFeedbackBufferMode = My.GetTransformFeedbackBufferMode ()
        member My.TransformFeedbackVaryingCount = My.GetTransformFeedbackVaryings ()
        member My.ActiveUniformBlockCount = My.GetActiveUniformBlocks ()
