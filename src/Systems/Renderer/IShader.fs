namespace Systems.Renderer

[<AutoOpen>]
module Shader =
    /// GL.createShader(..., source)
    type EShaderType =
    /// GL.FRAGMENT_SHADER
    | Fragment  = 0x8B30u
    /// GL.VERTEX_SHADER
    | Vertex    = 0x8B31u

    type EShaderParameter =
    /// <summary>
    /// Passed to <see cref="M:IShader.GetShaderParameter" /> to determine if a shader was deleted via <see cref="M:IShader.DeleteShader" />.<br/>
    /// Returns <c>false</c> if it was, <c>false</c> otherwise.
    /// </summary>
    | DeleteStatus  = 0x8B80u
    /// <summary>
    /// Passed to <see cref="M:IShader.GetShaderParameter" /> to get the status of the compilation.<br/>
    /// Returns <c>false</c> if the shader was not compiled.<br/>
    /// You can then query <see cref="M:GetShaderInfoLog" /> to find the exact error.
    /// </summary>
    | CompileStatus = 0x8B81u
    /// <summary>
    /// Passed to <see cref="M:IShader.GetShaderParameter" /> to get the shader type.<br/>
    /// Returns <see cref="M:EShaderType.Vertex" /> if the shader is a vertex shader or <see cref="M:EShaderType.Fragment" /> if the shader is a fragment shader.
    /// </summary>
    | ShaderType    = 0x8B4Fu

    /// Represent a Vertex/Fragment Shader
    type IShader =
        inherit IOptionWrapper

        abstract Delete: unit -> unit

        /// <summary>
        /// TODO
        /// </summary>
        abstract Compile: unit -> unit

        /// <summary>
        /// TODO
        /// </summary>
        abstract GetParameter: EShaderParameter -> Choice<EShaderType, bool>

        /// <summary>
        /// TODO
        /// </summary>
        abstract Source: string with get, set
        abstract bIsShader: bool with get
        abstract InfoLog: string with get


        // EXTENSIONS

        abstract ShaderType: EShaderType option with get
        abstract bCompiled: bool with get
        abstract bDeleted: bool with get

    let inline DeleteShader (s:IShader) = s.Delete(); s

    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="s">TODO</param>
    let inline CompileShader (s:IShader) = s.Compile(); s

    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="source">TODO</param>
    /// <param name="s">TODO</param>
    let inline SetShaderSource source (s:IShader) = s.Source <- source; s

[<AutoOpen>]
module ShaderExtension =
    type IShader with

        /// <summary>
        /// TODO: Shorthand for <see cref="M:IShader.GetParameter"/><c>(</c><see cref="M:EShaderParameter.CompileStatus"/><c>)</c>
        /// </summary>
        member internal My.GetCompileStatus () =
            match My.GetParameter EShaderParameter.CompileStatus with
            | Choice2Of2 result -> result
            | _ -> false

        /// <summary>
        /// TODO: Shorthand for <see cref="M:IShader.GetParameter"/><c>(</c><see cref="M:EShaderParameter.DeleteStatus"/><c>)</c>
        /// </summary>
        member internal My.GetDeleteStatus () =
            match My.GetParameter EShaderParameter.DeleteStatus with
            | Choice2Of2 result -> result
            | _ -> false

        /// <summary>
        /// TODO: Shorthand for <see cref="M:IShader.GetParameter"/><c>(</c><see cref="M:EShaderParameter.ShaderType"/><c>)</c>
        /// </summary>
        member internal My.GetShaderType () =
            match My.GetParameter EShaderParameter.ShaderType with
            | Choice1Of2 shaderType -> Some shaderType
            | _ -> None

    let inline SetShaderSource source (s:IShader) =
        s.Source <- source
        s

    let inline CompileShader (s:IShader) =
        s.Compile ()
        s

    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="s">TODO</param>
    let inline CheckShader (s:IShader) =
        if s.bCompiled
        then Browser.Dom.console.debug ("Shader check succeeded!", s)
        else Browser.Dom.console.error ("Shader check failed:\n", s.InfoLog)
             s.Delete ()
        s