namespace Systems.Renderer

[<AutoOpen>]
module Buffer =
    type IBuffer =
        inherit IOptionWrapper

        abstract member IsBuffer: unit -> bool
        abstract member Bind: target:uint -> unit

    let Bind target (b:IBuffer) = b.Bind target; b
