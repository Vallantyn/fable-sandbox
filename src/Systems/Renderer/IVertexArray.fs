namespace Systems.Renderer

[<AutoOpen>]
module VertexArray =
    type IVertexArray =
        inherit IOptionWrapper

        abstract bIsVertexArray: bool with get
        abstract Bind: unit -> unit

    let BindVertexArray (va:IVertexArray) = va.Bind (); va
