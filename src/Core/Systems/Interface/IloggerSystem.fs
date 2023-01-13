namespace Core.Systems

type ILoggerSystem =
    abstract member Log: string -> unit
    abstract member Debug: string -> unit
    abstract member Info: string -> unit
    abstract member Warn: string -> unit
    abstract member Error: string -> unit
