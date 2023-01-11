module Terminal

open Canvas

type Terminal () =
    member _.cursor = (0., 0.)

    static member private _Instance = lazy Terminal()

    static member Write str = 
        Canvas.context.fillText (str, (fst Terminal._Instance.Value.cursor), (snd Terminal._Instance.Value.cursor))

    static member WriteLine str = ()
