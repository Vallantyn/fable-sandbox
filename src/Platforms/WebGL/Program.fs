namespace Platforms.WebGL

open Systems.Renderer
open WebGL.Types
open WebGL2.RenderingContext

type Program (renderer:IRenderer) =
    let _renderer = renderer
    let GL = _renderer.As<RenderingContext>();

    let data = GL.createProgram ()

    interface IProgram with
        member _.Try () =
            data
            |> Option.map (fun p -> p)

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

        member _.GetAttachedShaders () =
            data
            |> Option.bind GL.getAttachedShaders
            |> Option.map (
                fun shaders ->
                    shaders.ToArray ()
                    |> Array.map (fun shader ->
                        Shader (_renderer, Some shader)
                        :> IShader
                    )
            )
            |> Option.defaultValue [||]

        member _.GetAttributeLocation name =
            data
            |> Option.map (fun program -> GL.getAttribLocation (program, name))
            |> Option.map (fun location -> AttributeLocation (_renderer, location))
            |> Option.defaultValue (AttributeLocation (_renderer, -1))
            :> IAttributeLocation

        member _.GetInfoLog () =
            data
            |> Option.bind GL.getProgramInfoLog
            |> Option.defaultValue ""

        member _.GetParameter param =
            data
            |> Option.bind (
                fun program ->
                    GL.getProgramParameter (program, param)
            )

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
                    (GL.getUniformLocation (program, name), _renderer) |> UniformLocation
            )
            |> Option.defaultValue (UniformLocation(_renderer))
            :> IUniformLocation

        member _.Link () =
            data
            |> Option.iter GL.linkProgram

        member _.Use () = GL.useProgram data
        member _.Validate () =
            data
            |> Option.iter GL.validateProgram

        member this.IsProgram() = failwith "todo"
