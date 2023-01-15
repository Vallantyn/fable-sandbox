namespace Systems.Renderer

[<AutoOpen>]
module Program =

    type EProgramParameter =
    | DeleteStatus                  = 0x8B80u
    | LinkStatus                    = 0x8B82u
    | ValidateStatus                = 0x8B83u
    | AttachedShaders               = 0x8B85u
    | ActiveAttributes              = 0x8B89u
    | ActiveUniforms                = 0x8B86u
    | TransformFeedbackBufferMode   = 0x8C7Fu
    | TransformFeedbackVaryings     = 0x8C83u
    | ActiveUniformBlocks           = 0x8A36u

    type ETransformFeedbackBufferMode =
    | InterleavedAttributes = 0x8C8Cu
    | SeparateAttributes    = 0x8C8Du

    /// Represent a Shader Program
    type IProgram =
        inherit IOptionWrapper

        abstract Delete: unit -> unit

        abstract AttachShader: IShader -> unit
        abstract DetachShader: IShader -> unit

        abstract Link: unit -> unit
        abstract Use: unit -> unit
        abstract Validate: unit -> unit


        // Note: overload for each return type ?
        // Note: Create each GetXXX() ?
        abstract GetParameter: EProgramParameter -> Choice<bool, int, ETransformFeedbackBufferMode>

        abstract GetActiveAttribute: uint -> IActiveInfo
        abstract GetAttributeLocation: string -> IAttributeLocation
        abstract BindAttributeLocation: uint * string -> unit

        // Note: overload for each return type ?
        abstract GetUniform: IUniformLocation -> obj option
        abstract GetActiveUniform: uint -> IActiveInfo
        abstract GetUniformLocation: string -> IUniformLocation

        abstract bIsProgram: bool with get
        abstract InfoLog: string with get
        abstract AttachedShaders: IShader array with get
        
        abstract bDeleted: bool with get               
        abstract bLinked: bool with get                 
        abstract bValidated: bool with get             
        abstract AttachedShaderCount: int with get            
        abstract ActiveAttributeCount: int with get           
        abstract ActiveUniformCount: int with get             
        abstract TransformFeedbackBufferMode: ETransformFeedbackBufferMode option with get
        abstract TransformFeedbackVaryingCount: int with get  
        abstract ActiveUniformBlockCount: int with get

    let inline DeleteProgram (p:IProgram) = p.Delete (); p
    let inline AttachShader (s:IShader) (p:IProgram) = p.AttachShader s; p
    let inline DetachShader (s:IShader) (p:IProgram) = p.DetachShader s; p
    let inline LinkProgram (p:IProgram) = p.Link(); p
    let inline UseProgram (p:IProgram) = p.Use(); p
    let inline ValidateProgram (p:IProgram) = p.Validate(); p


[<AutoOpen>]
module ProgramExtensions =
    type IProgram with
        member internal My.GetDeleteStatus () =
            match My.GetParameter EProgramParameter.DeleteStatus with
            | Choice1Of3 result -> result
            | _ -> false

        member internal My.GetLinkStatus () =
            match My.GetParameter EProgramParameter.LinkStatus with
            | Choice1Of3 result -> result
            | _ -> false

        member internal My.GetValidateStatus () =
            match My.GetParameter EProgramParameter.ValidateStatus with
            | Choice1Of3 result -> result
            | _ -> false

        member internal My.GetAttachedShaders () =
            match My.GetParameter EProgramParameter.AttachedShaders with
            | Choice2Of3 result -> result
            | _ -> -1

        member internal My.GetActiveAttributes () =
            match My.GetParameter EProgramParameter.ActiveAttributes with
            | Choice2Of3 result -> result
            | _ -> -1

        member internal My.GetActiveUniforms () =
            match My.GetParameter EProgramParameter.ActiveUniforms with
            | Choice2Of3 result -> result
            | _ -> -1

        member internal My.GetTransformFeedbackBufferMode () =
            match My.GetParameter EProgramParameter.TransformFeedbackBufferMode with
            | Choice3Of3 result -> Some result
            | _ -> None

        member internal My.GetTransformFeedbackVaryings () =
            match My.GetParameter EProgramParameter.TransformFeedbackVaryings with
            | Choice2Of3 result -> result
            | _ -> -1

        member internal My.GetActiveUniformBlocks () =
            match My.GetParameter EProgramParameter.ActiveUniformBlocks with
            | Choice2Of3 result -> result
            | _ -> -1
        
        // static member Attach (s:IShader) (p:IProgram) =
        //     p.AttachShader s
        //     p

        // static member Link (p:IProgram) =
        //     p.Link ()
        //     p

        // static member Check (p:#IProgram) =
        //     if p.bLinked
        //     then Browser.Dom.console.log ("Program check succeeded!", p)            
        //     else Browser.Dom.console.error ("Program check failed:\n", p.InfoLog)
        //          p.Delete ()
        //     p

    let inline CheckProgram (p:#IProgram) =
        if p.bLinked
        then Browser.Dom.console.log ("Program check succeeded!", p)            
        else Browser.Dom.console.error ("Program check failed:\n", p.InfoLog)
             p.Delete ()
        p