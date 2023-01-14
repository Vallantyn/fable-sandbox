namespace Platforms.WebGL

open Fable.Core
open Systems.Renderer

open WebGL.Types
open WebGL2.RenderingContext

open HTML.Types

[<Mangle>]
type Renderer (window:IWindow) =
    let _window = window
    let GL = _window.As<HTMLCanvasElement>().getContext_webgl2()

    interface IRenderer with
        member _.Get () = GL

        member _.Viewport (x, y, w, h) = GL.viewport (x, y, w, h)

        member _.ClearStencil stencil = GL.clearStencil stencil
        member _.ClearDepth depth = GL.clearDepth depth
        member _.ClearColor (r, g, b, a) = GL.clearColor (r, g, b, a)
        member _.Clear bits = GL.clear (uint bits)

        member _.DrawArrays (t, o, c) = GL.drawArrays (uint t, o, c)

        member My.CreateShader ``type`` = Shader (My, ``type``)
        member _.DeleteShader shader =
            shader
            |> TryAs<WebGLShader>
            |> GL.deleteShader

        member My.CreateProgram () = Program My
        member _.DeleteProgram program =
            program
            |> TryAs<WebGLProgram>
            |> GL.deleteProgram

        member My.CreateBuffer () = Buffer My
        member _.DeleteBuffer buffer =
            buffer
            |> TryAs<WebGLBuffer>
            |> GL.deleteBuffer

        member this.BufferData (target, data:int array, usage) =
            GL.bufferData (target, data, usage)

        member this.BufferData (target, data:uint array, usage) =
            GL.bufferData (target, data, usage)

        member this.BufferData (target, data:single array, usage) =
            GL.bufferData (target, data, usage)

        member this.BufferData (target, data:float array, usage) =
            GL.bufferData (target, data, usage)

        member this.CreateFrameBuffer() = failwith "todo"
        member this.DeleteFrameBuffer(var0) = failwith "todo"

        member this.CreateQuery() = failwith "todo"
        member this.DeleteQuery(var0) = failwith "todo"

        member this.CreateRenderBuffer() = failwith "todo"
        member this.DeleteRenderBuffer(var0) = failwith "todo"

        member this.CreateSampler() = failwith "todo"
        member this.DeleteSampler(var0) = failwith "todo"

        member this.CreateTexture() = failwith "todo"
        member this.DeleteTexture(var0) = failwith "todo"

        member this.CreateTransformFeedback() = failwith "todo"
        member this.DeleteTransformFeedback(var0) = failwith "todo"

        member My.CreateVertexArray() = VertexArray My
        member this.DeleteVertexArray(var0) = failwith "todo"
