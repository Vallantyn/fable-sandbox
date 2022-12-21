module App.Core.Renderers

open System.Reflection

type IRenderer =
    abstract Render: unit->unit

type Renderer () =
    interface IRenderer with
        member _.Render() = ()

type RendererFactory() =
    static member GetRenderer ():IRenderer =
        Renderer()
