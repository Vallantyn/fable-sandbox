module Core.Systems.Logger

open Core.Systems.ILogger

open type System.Console

type LoggerSystem () =
    interface ILoggerSystem with
        member _.Log (msg) = Fable.Core.JS.console.log ("%c%s", "", msg)
        member _.Debug (msg) = Fable.Core.JS.console.debug ("%c%s", "", msg)
        member _.Info (msg) = Fable.Core.JS.console.info ("%c%s", "color:silver", msg)
        member _.Warn (msg) = Fable.Core.JS.console.warn ("%c%s", "", msg)
        member _.Error (msg) = Fable.Core.JS.console.error ("%c%s", "", msg)