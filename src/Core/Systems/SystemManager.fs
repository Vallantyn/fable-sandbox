namespace Core.Systems

open Systems.Renderer
open Platforms.WebGL

type SystemManager () =
    member private _.LoggerSystem = LoggerSystem()
    // member private _.RendererSystem = RendererSystem()

    member private _.WindowSystem = Window()
    member private My.RendererSystem = Renderer (My.WindowSystem)

    static member private Instance = lazy SystemManager()

    static member Logger :ILoggerSystem = SystemManager.Instance.Value.LoggerSystem
    static member Window :IWindow = SystemManager.Instance.Value.WindowSystem
    static member Renderer :IRenderer = SystemManager.Instance.Value.RendererSystem
    // static member Renderer :IRendererSystem = SystemManager.Instance.Value.RendererSystem

// [<AutoOpen>]
// module SystemManagerExtension =

//     open Core.Systems

//     let log = SystemManager.Logger
//     let window = SystemManager.Window
//     let renderer = SystemManager.Renderer
