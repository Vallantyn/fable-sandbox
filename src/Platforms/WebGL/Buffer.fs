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

        member _.Data (target, usage) = GL.bufferData (uint target, uint usage)
        member _.Data(target: EBufferTarget, usage: EBufferUsage, sourceOffset: uint) = GL.bufferData (uint target, uint usage, sourceOffset)
        member _.Data(target: EBufferTarget, size: int, usage: EBufferUsage) = GL.bufferData (uint target, size, uint usage)
        member _.Data(target: EBufferTarget, sourceData: TBufferSourceData, usage: EBufferUsage) =
            match sourceData with
            | IntBuffer     b -> GL.bufferData (uint target, b, uint usage)
            | UIntBuffer    b -> GL.bufferData (uint target, b, uint usage)
            | SingleBuffer  b -> GL.bufferData (uint target, b, uint usage)
            | FloatBuffer   b -> GL.bufferData (uint target, b, uint usage)
        member _.Data(target, sourceData, usage, sourceOffset) =
            match sourceData with
            | IntBuffer     b -> GL.bufferData (uint target, b, uint usage, sourceOffset)
            | UIntBuffer    b -> GL.bufferData (uint target, b, uint usage, sourceOffset)
            | SingleBuffer  b -> GL.bufferData (uint target, b, uint usage, sourceOffset)
            | FloatBuffer   b -> GL.bufferData (uint target, b, uint usage, sourceOffset)
        member _.Data(target, sourceData, usage, sourceOffset, length) =
            match sourceData with
            | IntBuffer     b -> GL.bufferData (uint target, b, uint usage, sourceOffset, length)
            | UIntBuffer    b -> GL.bufferData (uint target, b, uint usage, sourceOffset, length)
            | SingleBuffer  b -> GL.bufferData (uint target, b, uint usage, sourceOffset, length)
            | FloatBuffer   b -> GL.bufferData (uint target, b, uint usage, sourceOffset, length)
        member _.GetParameter(target, parameter) = failwith "todo"
        member _.SubData(target, sourceOffset) = failwith "todo"
        member _.SubData(target: EBufferTarget, sourceOffset: uint, sourceData: TBufferSourceData): unit = failwith "todo"
        member _.SubData(target: EBufferTarget, byteOffset: uint, sourceOffset: uint): unit = failwith "todo"
        member _.SubData(target, byteOffset, sourceData, sourceOffset) = failwith "todo"
        member _.SubData(target, byteOffset, sourceData, sourceOffset, length) = failwith "todo"
