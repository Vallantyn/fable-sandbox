namespace Systems

type IWindow =
    abstract Get: unit -> obj
    abstract Width: int
    abstract Height: int

[<AutoOpen>]    
module WindowExtensions =
    type IWindow with
        member My.Get<'T>() =
            My.Get() :?> 'T
