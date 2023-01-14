namespace Systems.Renderer

[<AutoOpen>]
module AttributeLocation =
    type IAttributeLocation =
        inherit IWrapper<int>

        abstract member Enable: unit -> unit
        abstract member Disable: unit -> unit
        abstract Pointer: size:int * ``type``:uint * bNormalize:bool * stride:int * offset:int -> unit

    let Enable (al:IAttributeLocation) = al.Enable (); al
    let Disable (al:IAttributeLocation) = al.Disable (); al
    let Pointer size t n s o (al:IAttributeLocation) = al.Pointer (size, t, n, s, o); al
