namespace Systems.Renderer

type IWindow =
    inherit IWrapper

    abstract Width: int with get, set
    abstract Height: int with get, set
