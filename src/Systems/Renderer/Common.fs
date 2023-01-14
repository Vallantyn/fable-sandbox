namespace Systems.Renderer

type IWrapper =
    abstract member Get: unit -> obj

type IWrapper<'T> =
    abstract member Get: unit -> 'T

type IOptionWrapper =
    abstract member Try: unit -> obj option

[<AutoOpen>]
module Wrapper =
    type IWrapper with
        member My.As<'T>() = My.Get() :?> 'T

    type IOptionWrapper with
        member My.TryAs<'T>() =
            My.Try()
            |> Option.map (fun o -> o :?> 'T)

    let As<'T> (w:IWrapper) = w.As<'T>();
    let TryAs<'T> (ow:IOptionWrapper) = ow.TryAs<'T>();
