module Services.Logger

type ILogger =
    abstract member Log: string -> unit

type Logger () =
    interface ILogger with
        member _.Log message =
            System.Console.WriteLine(message)