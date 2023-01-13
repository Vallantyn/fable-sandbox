namespace Core.Systems

type SystemManager () =
    member private _.LoggerSystem = LoggerSystem()
    // member private _.RendererSystem = RendererSystem()

    member private _.WindowSystem = Systems.Implementations.HTMLCanvasWindow()
    member private My.RendererSystem = Systems.Implementations.WebGL2Renderer(My.WindowSystem)

    static member private Instance = lazy SystemManager()

    static member Logger :ILoggerSystem = SystemManager.Instance.Value.LoggerSystem
    static member Window :Systems.IWindow = SystemManager.Instance.Value.WindowSystem
    static member Renderer :Systems.IRenderer = SystemManager.Instance.Value.RendererSystem
    // static member Renderer :IRendererSystem = SystemManager.Instance.Value.RendererSystem

// [<AutoOpen>]
// module SystemManagerExtension =

//     open Core.Systems

//     let log = SystemManager.Logger
//     let window = SystemManager.Window
//     let renderer = SystemManager.Renderer