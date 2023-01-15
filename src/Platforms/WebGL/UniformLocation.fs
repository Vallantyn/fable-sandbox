namespace Platforms.WebGL

open Systems.Renderer

open WebGL.Types
open WebGL2.RenderingContext

type UniformLocation (uniformLocation:WebGLUniformLocation option, renderer:IRenderer) =
    let _data = uniformLocation
    let GL = renderer.As<RenderingContext>();

    new (renderer) = UniformLocation (None, renderer)

    interface IUniformLocation with
        member _.Try () =
            _data
            |> Option.map (fun ul -> ul)

        member _.Float  with set f                      = GL.uniform1f (_data, f)
        member _.Float2 with set (f0, f1)               = GL.uniform2f (_data, f0, f1)
        member _.Float3 with set (f0, f1, f2)           = GL.uniform3f (_data, f0, f1, f2)
        member _.Float4 with set (f0, f1, f2, f3)       = GL.uniform4f (_data, f0, f1, f2, f3)

        member _.Int  with set i                        = GL.uniform1i (_data, i)
        member _.Int2 with set (i0, i1)                 = GL.uniform2i (_data, i0, i1)
        member _.Int3 with set (i0, i1, i2)             = GL.uniform3i (_data, i0, i1, i2)
        member _.Int4 with set (i0, i1, i2, i3)         = GL.uniform4i (_data, i0, i1, i2, i3)

        member _.UInt  with set ui                      = GL.uniform1ui (_data, ui)
        member _.UInt2 with set (ui0, ui1)              = GL.uniform2ui (_data, ui0, ui1)
        member _.UInt3 with set (ui0, ui1, ui2)         = GL.uniform3ui (_data, ui0, ui1, ui2)
        member _.UInt4 with set (ui0, ui1, ui2, ui3)    = GL.uniform4ui (_data, ui0, ui1, ui2, ui3)
