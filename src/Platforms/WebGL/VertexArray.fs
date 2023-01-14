namespace Platforms.WebGL

open Systems.Renderer

open WebGL2.RenderingContext

type VertexArray (renderer:IRenderer) =
    let _renderer = renderer
    let GL = _renderer.As<RenderingContext>()

    let data = GL.createVertexArray ()

    interface IVertexArray with
        member this.Try() =
            data
            |> Option.map (fun va -> va)
        member _.Bind() = GL.bindVertexArray data
        member _.IsVertexArray() = failwith "todo"
