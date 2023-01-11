module Core.Systems.IRenderer

type IRendererSystem =
    abstract member Clear: Types.Rect -> unit
    abstract member Nope: unit -> unit