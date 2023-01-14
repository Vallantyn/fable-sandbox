namespace Platforms.WebGL

open Systems.Renderer

open WebGL2.RenderingContext

type AttributeLocation (renderer:IRenderer, index) =
    let _renderer = renderer
    let GL = _renderer.As<RenderingContext>()

    let _index = index

    interface IAttributeLocation with
        member _.Get () = _index

        member _.Enable () =
            if _index >= 0
            then GL.enableVertexAttribArray (uint _index)
            else Browser.Dom.console.error ($"BAD INDEX: {_index}")

        member _.Disable () =
            if _index >= 0
            then GL.disableVertexAttribArray (uint _index)
            else Browser.Dom.console.error ($"BAD INDEX: {_index}")

        member _.Pointer (size, ``type``, bNormalize, stride, offset) =
            if _index >= 0 then GL.vertexAttribPointer (uint _index, size, ``type``, bNormalize, stride, offset)
            else Browser.Dom.console.error ($"BAD INDEX: {_index}")
