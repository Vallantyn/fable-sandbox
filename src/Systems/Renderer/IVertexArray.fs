namespace Systems.Renderer

[<AutoOpen>]
module VertexArray =
    type IVertexArray =
        inherit IOptionWrapper

        abstract member IsVertexArray: unit -> bool
        abstract member Bind: unit -> unit

    let Bind (va:IVertexArray) = va.Bind (); va
