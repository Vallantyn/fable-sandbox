module App.Core.Renderers

/// A Renderer
[<Interface>]
type IRenderer =
    /// Renders stuff
    abstract Render: unit -> unit
