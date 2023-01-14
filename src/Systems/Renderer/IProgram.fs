namespace Systems.Renderer

[<AutoOpen>]
module Program =

    /// Represent a Shader Program
    type IProgram =
        inherit IOptionWrapper
        abstract member IsProgram: unit -> bool

        abstract member AttachShader: IShader -> unit
        abstract member DetachShader: IShader -> unit
        abstract member GetAttachedShaders: unit -> IShader array

        abstract member Link: unit -> unit
        abstract member Use: unit -> unit
        abstract member Validate: unit -> unit

        abstract member GetInfoLog: unit -> string

        // Note: overload for each return type ?
        // Note: Create each GetXXX() ?
        abstract member GetParameter: glenum:uint -> obj option

        abstract member GetActiveAttribute: uint -> IActiveInfo
        abstract member GetAttributeLocation: string -> IAttributeLocation
        abstract member BindAttributeLocation: uint * string -> unit

        // Note: overload for each return type ?
        abstract member GetUniform: IUniformLocation -> obj option
        abstract member GetActiveUniform: uint -> IActiveInfo
        abstract member GetUniformLocation: string -> IUniformLocation

    let inline AttachShader (s:IShader) (p:IProgram) = p.AttachShader s; p
    let inline DetachShader (s:IShader) (p:IProgram) = p.DetachShader s; p
    let inline Link (p:IProgram) = p.Link(); p
    let inline Use (p:IProgram) = p.Use(); p
    let inline Validate (p:IProgram) = p.Validate(); p
