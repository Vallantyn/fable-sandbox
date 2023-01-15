namespace Systems.Renderer

[<AutoOpen>]
module UniformLocation =
    /// Part of the WebGL API and represents the location of a uniform variable in a shader program.
    [<Fable.Core.Mangle>]
    type IUniformLocation =
        inherit IOptionWrapper

        abstract Float: float with set
        abstract Float2: float * float with set
        abstract Float3: float * float * float with set
        abstract Float4: float * float * float * float with set

        abstract member Int: int with set
        abstract member Int2: int * int with set
        abstract member Int3: int * int * int with set
        abstract member Int4: int * int * int * int with set

        abstract member UInt: uint with set
        abstract member UInt2: uint * uint with set
        abstract member UInt3: uint * uint * uint with set
        abstract member UInt4: uint * uint * uint * uint with set

    let SetUniformFloat f (ul:IUniformLocation)             = ul.Float <- f
    let SetUniformFloat2 f0 f1 (ul:IUniformLocation)        = ul.Float2 <- f0, f1
    let SetUniformFloat3 f0 f1 f2 (ul:IUniformLocation)     = ul.Float3 <- f0, f1, f2
    let SetUniformFloat4 f0 f1 f2 f3 (ul:IUniformLocation)  = ul.Float4 <- f0, f1, f2, f3
    let SetUniformInt i (ul:IUniformLocation)               = ul.Int <- i
    let SetUniformInt2 i0 i1 (ul:IUniformLocation)          = ul.Int2 <- i0, i1
    let SetUniformInt3 i0 i1 i2 (ul:IUniformLocation)       = ul.Int3 <- i0, i1, i2
    let SetUniformInt4 i0 i1 i2 i3 (ul:IUniformLocation)    = ul.Int4 <- i0, i1, i2, i3
    let SetUniformUInt ui (ul:IUniformLocation)                 = ul.Int <- ui
    let SetUniformUInt2 ui0 ui1 (ul:IUniformLocation)           = ul.Int2 <- ui0, ui1
    let SetUniformUInt3 ui0 ui1 ui2 (ul:IUniformLocation)       = ul.Int3 <- ui0, ui1, ui2
    let SetUniformUInt4 ui0 ui1 ui2 ui3 (ul:IUniformLocation)   = ul.Int4 <- ui0, ui1, ui2, ui3