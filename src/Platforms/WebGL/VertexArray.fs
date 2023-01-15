namespace Platforms.WebGL

open Systems.Renderer

open WebGL2.RenderingContext

type VertexArray (renderer:IRenderer) =
    let GL = renderer.As<RenderingContext>()

    let data = GL.createVertexArray ()

    interface IVertexArray with
        member this.Try() =
            data
            |> Option.map (fun va -> va)

        member _.Bind() = GL.bindVertexArray data
        member _.bIsVertexArray with get () = GL.isVertexArray data
