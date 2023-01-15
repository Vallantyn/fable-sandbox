namespace Systems.Renderer

[<AutoOpen>]
module AttributeLocation =
    type IAttributeLocation =
        inherit IWrapper<int>

        abstract Enable: unit -> unit
        abstract Disable: unit -> unit
        abstract VertexPointer: size:int * ``type``:uint * bNormalize:bool * stride:int * offset:int -> unit

    let EnableAttributeLocation (al:IAttributeLocation) = al.Enable (); al
    let DisableAttributeLocation (al:IAttributeLocation) = al.Disable (); al
    let VertexAttributePointer size t n s o (al:IAttributeLocation) = al.VertexPointer (size, t, n, s, o); al


[<AutoOpen>]
module AttributeLocationExtension =
    type IAttributeLocation with
        static member Enable (al:IAttributeLocation) =
            al.Enable ()
            al
        static member Disable (al:IAttributeLocation) =
            al.Disable ()
            al
        static member VertexAttributePointer size ``type`` bNormalize stride offset (al:IAttributeLocation) =
            al.VertexPointer (size, ``type``, bNormalize, stride, offset)
            al