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

        member _.DrawArrays (primitiveType, offset, count) = GL.drawArrays (uint primitiveType, offset, count)

        member this.BufferData (target, data:int array, usage) =
            GL.bufferData (target, data, usage)

        member this.BufferData (target, data:uint array, usage) =
            GL.bufferData (target, data, usage)

        member this.BufferData (target, data:single array, usage) =
            GL.bufferData (target, data, usage)

        member this.BufferData (target, data:float array, usage) =
            GL.bufferData (target, data, usage)

        member My.CreateShader shaderType = Shader (My, shaderType)

        member My.CreateProgram () = Program My

        member My.CreateBuffer () = Buffer My
        
        member this.CreateFrameBuffer() = failwith "todo"

        member this.CreateQuery() = failwith "todo"

        member this.CreateRenderBuffer() = failwith "todo"

        member this.CreateSampler() = failwith "todo"

        member this.CreateTexture() = failwith "todo"

        member this.CreateTransformFeedback() = failwith "todo"

        member My.CreateVertexArray() = VertexArray My