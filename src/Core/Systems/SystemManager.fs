module Core.Systems

open Core.Systems.ILogger
open Core.Systems.IRenderer

open Core.Systems.Logger
open Core.Systems.Renderer

type SystemManager () =
    member private _.LoggerSystem = LoggerSystem()
    // member private _.RendererSystem = RendererSystem()

    static member private Instance = lazy SystemManager()

    static member Logger :ILoggerSystem = SystemManager.Instance.Value.LoggerSystem
    // static member Renderer :IRendererSystem = SystemManager.Instance.Value.RendererSystem