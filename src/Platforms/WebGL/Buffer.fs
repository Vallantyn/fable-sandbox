namespace Platforms.WebGL

open Systems.Renderer

open WebGL2.RenderingContext

type Buffer (renderer:IRenderer) =
    let _renderer = renderer
    let GL = _renderer.As<RenderingContext>()

    let _data = GL.createBuffer ()

    interface IBuffer with
        member this.Try() = failwith "todo"
        member _.IsBuffer () = GL.isBuffer _data
        member _.Bind target = GL.bindBuffer (target, _data)
