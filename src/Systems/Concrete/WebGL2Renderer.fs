namespace Systems.Implementations

open Systems
open Systems.Renderer

open HTML.Types

open WebGL
open WebGL.Types
open WebGL2
open HTML.Canvas

type Shader (renderer:Systems.IRenderer, ``type``) =
    let _renderer = renderer
    let GL = _renderer.As<RenderingContext.WebGL2RenderingContext>();

    let _data = GL.createShader ``type``

    // interface IOptionWrapper<WebGLShader> with
    //     member _.Try () = _data

    interface Renderer.IShader with
        member _.Try () =
            _data
            |> Option.map (fun s -> s)

        member _.IsShader() = GL.isShader _data
        member _.GetInfoLog() =
            _data
            |> Option.bind GL.getShaderInfoLog
            |> Option.defaultValue ""

        member _.GetParameter param =
            _data
            |> Option.map (
                fun shader ->
                    match GL.getShaderParameter (shader, param) with
                    | Fable.Core.U2.Case1 c -> Choice1Of2 c
                    | Fable.Core.U2.Case2 c -> Choice2Of2 c
            )
            |> Option.defaultValue (Choice2Of2 false)

        member _.GetSource () =
            _data
            |> Option.bind GL.getShaderSource
            |> Option.defaultValue ""

        member _.SetSource source =
            _data
            |> Option.iter (fun shader -> GL.shaderSource (shader, source))

        member _.Source
            with get ()              =
                _data
                |> Option.bind GL.getShaderSource
                |> Option.defaultValue ""

            and  set (source:string) =
                _data
                |> Option.iter (fun shader -> GL.shaderSource (shader, source))

    // static member op_Dereference (shader:IShader) = shader.Try ()
type UniformLocation (uniformLocation:WebGLUniformLocation option, renderer:IRenderer) =
    let _data = uniformLocation
    let GL = renderer.As<RenderingContext.WebGL2RenderingContext>();

    new (renderer) = UniformLocation (None, renderer)

    interface IUniformLocation with
        member _.Try () =
            _data
            |> Option.map (fun ul -> ul)

        member _.SetFloat f                = GL.uniform1f (_data, f)
        member _.SetFloat (f0, f1)         = GL.uniform2f (_data, f0, f1)
        member _.SetFloat (f0, f1, f2)     = GL.uniform3f (_data, f0, f1, f2)
        member _.SetFloat (f0, f1, f2, f3) = GL.uniform4f (_data, f0, f1, f2, f3)

        member _.SetInt i                  = GL.uniform1i (_data, i)
        member _.SetInt (i0, i1)           = GL.uniform2i (_data, i0, i1)
        member _.SetInt (i0, i1, i2)       = GL.uniform3i (_data, i0, i1, i2)
        member _.SetInt (i0, i1, i2, i3)   = GL.uniform4i (_data, i0, i1, i2, i3)

        // member _.SetUInt ui                   = GL.uniform1ui (_data, ui)
        // member _.SetUInt (ui0, ui1)           = GL.uniform2ui (_data, ui0, ui1)
        // member _.SetUInt (ui0, ui1, ui2)      = GL.uniform3ui (_data, ui0, ui1, ui2)
        // member _.SetUInt (ui0, ui1, ui2, ui3) = GL.uniform4ui (_data, ui0, ui1, ui2, ui3)

type ActiveInfo (activeInfo:WebGLActiveInfo option) =
    let _data:WebGLActiveInfo option = activeInfo

    new () = ActiveInfo None

    interface IActiveInfo with
        member _.Try () =
            _data
            |> Option.map (fun i -> i)

        member _.Name =
            _data
            |> Option.map (fun i -> i.name)
            |> Option.defaultValue ""

        member _.Size =
            _data
            |> Option.map (fun i -> i.size)
            |> Option.defaultValue -1

        member _.Type =
            _data
            |> Option.map (fun i -> i.``type``)
            |> Option.defaultValue 1u

type Program (renderer:Systems.IRenderer) =
    let _renderer = renderer
    let GL = _renderer.As<RenderingContext.WebGL2RenderingContext>();

    // let _vert = vs
    // let _frag = fs
    
    let _data = GL.createProgram ()

    // do
    //     match _data, _vert.Get<WebGLShader>(), _frag.Get<WebGLShader>() with
    //     | Some program, vertex, fragment ->
    //         GL.attachShader (program, vertex)
    //         GL.attachShader (program, fragment)

    //         GL.linkProgram program
    //     | _ -> ()

    // static member op_True (p:P) = true
    // static member op_False (p:P) = false
    // static member op_Dereference (p:P) = p

    interface Renderer.IProgram with
        member _.Try () =
            _data
            |> Option.map (fun p -> p)

        member _.AttachShader (shader) =
            match _data, shader.TryAs<WebGLShader>() with
            | Some program, Some shader -> GL.attachShader (program, shader)
            | _ -> ()
            // _data
            // |> Option.iter (
            //     fun program ->
            //         GL.attachShader (program, shader.TryAs<WebGLShader>())
            // )

        member _.BindAttributeLocation (index, name) =
            _data
            |> Option.iter (
                fun program ->
                    GL.bindAttribLocation (program, index, name)
            )

        member _.DetachShader (shader) =
            match _data, shader.TryAs<WebGLShader>() with
            | Some program, Some shader -> GL.detachShader (program, shader)
            | _ -> ()
            // _data
            // |> Option.iter (
            //     fun program ->
            //         GL.detachShader (program, shader.Try())
            // )

        member _.GetActiveAttribute (index) =
            _data
            |> Option.map (
                fun program ->
                    GL.getActiveAttrib (program, index) |> ActiveInfo
            )
            |> Option.defaultValue (ActiveInfo())
            :> IActiveInfo

        member _.GetActiveUniform (index) =
            _data
            |> Option.map (
                fun program ->
                    GL.getActiveUniform (program, index) |> ActiveInfo
            )
            |> Option.defaultValue (ActiveInfo())
            :> IActiveInfo

        member _.GetAttachedShaders () =
            _data
            |> Option.bind GL.getAttachedShaders
            |> Option.map (
                fun shaders ->
                    shaders.ToArray ()
                    |> Array.map (fun shader ->
                        shader :?> IShader
                    )
            )
            |> Option.defaultValue [||]

        member _.GetAttributeLocation (name) =
            _data
            |> Option.map (
                fun program ->
                    GL.getAttribLocation (program, name)
            )
            |> Option.defaultValue -1

        member _.GetInfoLog () =
            _data
            |> Option.bind GL.getProgramInfoLog
            |> Option.defaultValue ""

        member _.GetParameter (param) =
            _data
            |> Option.bind (
                fun program ->
                    GL.getProgramParameter (program, param)
            )

        member _.GetUniform (location) =
            _data
            |> Option.bind (
                fun program ->
                    GL.getUniform (program, location :?> WebGLUniformLocation)
            )

        member _.GetUniformLocation (name) =
            _data
            |> Option.map (
                fun program ->
                    (GL.getUniformLocation (program, name), _renderer) |> UniformLocation
            )
            |> Option.defaultValue (UniformLocation(_renderer))
            :> IUniformLocation

        member _.Link () =
            _data
            |> Option.iter GL.linkProgram

        member _.Use () = GL.useProgram _data
        member _.Validate () =
            _data
            |> Option.iter GL.validateProgram

        member this.IsProgram() = failwith "todo"

type WebGL2Renderer (window:Systems.IWindow) =
    let _window = window
    let _gl = _window.Get<HTMLCanvasElement>().getContext_webgl2()

    interface Systems.IRenderer with
        member _.Get () = _gl

        member _.Clear () = _gl.clear(_gl.COLOR_BUFFER_BIT)

        member My.CreateShader ``type`` = Shader (My, ``type``)
        member My.DeleteShader shader = shader.TryAs<WebGLShader>() |> _gl.deleteShader
        member My.CreateProgram () = Program My
        member My.DeleteProgram program = program.TryAs<WebGLProgram>() |> _gl.deleteProgram

    member private _.CreateShader_Internal source ``type`` =
        match _gl.createShader ``type`` with
        | Some shader ->
            _gl.shaderSource (shader, source)
            _gl.compileShader shader
            ()
        | None -> ()
        
    member My.CreateVertexShader source =
        My.CreateShader_Internal source _gl.VERTEX_SHADER

    member My.CreateFragmentShader source =
        My.CreateShader_Internal source _gl.FRAGMENT_SHADER

namespace Systems.GL

open Systems
open Systems.Renderer

open HTML.Types

open WebGL
open WebGL.Types
open WebGL2
open HTML.Canvas

open Fable.Core

[<AutoOpen>]
module PlatformWebGL =
    let [<Global>] GL:RenderingContext.WebGL2RenderingContext = jsNative

    let glCreateShader t = GL.createShader t
    let glDeleteShader s = GL.deleteShader s

    let glIsShader s = GL.isShader s
    let glGetShaderInfoLog s = GL.getShaderInfoLog s

    let glCreateProgram () = GL.createProgram
    let glDeleteProgram p = GL.deleteProgram p

    type WebGLShader with
        member My.getInfoLog () = GL.getShaderInfoLog My
