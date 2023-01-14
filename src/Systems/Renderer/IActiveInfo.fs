namespace Systems.Renderer

[<AutoOpen>]
module ActiveInfo =
    /// Part of the WebGL API and represents the information returned by calling the `WebGLRenderingContext.getActiveAttrib()` and `WebGLRenderingContext.getActiveUniform()` methods.
    type IActiveInfo =
        inherit IOptionWrapper

        abstract member Name: string with get
        abstract member Size: int with get
        abstract member Type: uint with get
