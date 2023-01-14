namespace Systems.Renderer

[<AutoOpen>]
module UniformLocation =
    /// Part of the WebGL API and represents the location of a uniform variable in a shader program.
    [<Fable.Core.Mangle>]
    type IUniformLocation =
        inherit IOptionWrapper

        abstract member SetFloat: float -> unit
        abstract member SetFloat: float * float -> unit
        abstract member SetFloat: float * float * float -> unit
        abstract member SetFloat: float * float * float * float -> unit

        abstract member SetInt: int -> unit
        abstract member SetInt: int * int -> unit
        abstract member SetInt: int * int * int -> unit
        abstract member SetInt: int * int * int * int -> unit

        abstract member SetUInt: uint -> unit
        abstract member SetUInt: uint * uint -> unit
        abstract member SetUInt: uint * uint * uint -> unit
        abstract member SetUInt: uint * uint * uint * uint -> unit
