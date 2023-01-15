namespace Platforms.WebGL

open Systems.Renderer

open WebGL2.RenderingContext

type Buffer (renderer:IRenderer) =
    let GL = renderer.As<RenderingContext>()
    let data = GL.createBuffer ()

    interface IBuffer with
        member _.Try() = failwith "todo"

        member _.Delete () = GL.deleteBuffer data

        member _.bIsBuffer with get () = GL.isBuffer data
        member _.Bind target = GL.bindBuffer (uint target, data)
        member _.GetParameter(target, parameter) = failwith "todo"

        member _.Data(target:EBufferTarget, size: int, usage: EBufferUsage) =
            GL.bufferData (uint target, size, uint usage)

        member _.Data(target:EBufferTarget, data:'T array, usage: EBufferUsage) =
            GL.bufferData (uint target, data, uint usage)

        member _.Data(target:EBufferTarget, sourceData:'T array, usage:EBufferUsage, sourceOffset:uint, ?length:uint) =
            match length with
            | Some l -> GL.bufferData (uint target, sourceData, uint usage, sourceOffset, l)
            | None -> GL.bufferData (uint target, sourceData, uint usage, sourceOffset)
