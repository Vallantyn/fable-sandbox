namespace Systems.Renderer

[<AutoOpen>]
module Shader =
    /// GL.createShader(..., source)
    type EShaderType =
    /// GL.FRAGMENT_SHADER
    | Fragment  = 0x8B30u
    /// GL.VERTEX_SHADER
    | Vertex    = 0x8B31u

    /// Represent a Vertex/Fragment Shader
    type IShader =
        inherit IOptionWrapper

        abstract member IsShader: unit -> bool
        abstract member Compile: unit -> unit
        abstract member GetInfoLog: unit -> string
        abstract member GetParameter: uint -> Choice<uint, bool>
        abstract member GetSource: unit -> string
        abstract member SetSource: string -> unit
        abstract member Source: string with get, set

    let inline SetSource source (s:IShader) = s.Source <- source; s
    let inline Compile (s:IShader) = s.Compile(); s
