/// App Module
module App

// open Browser

// open Types
// open Canvas

/// App's state
// type State = {
//     /// Current Time
//     time:float;
//     /// Time elpased since last <see cref='M:App.Update'/>
//     deltaTime:float;
//     /// Background <see cref="T:Canvas.Color" />
//     color:Color;
// }

/// <summary>Setup of the App</summary>
/// <returns>Initial <see cref='T:App.State'/>.</returns>
// let Start () =
//     window.addEventListener ("resize", onWindowResize)
//     setupWindow ()
//     {
//         time=0.;
//         deltaTime=0.;
//         color=(Hue 90);
//     }

/// <summary>Updates our State</summary>
/// <param name="state">Current <see cref='T:App.State'/> to update.</param>
/// <returns>An updated <see cref='T:App.State'/>.</returns>
// let Update state:State =
//     let hue =
//         match state.color with
//         | Hue h -> Hue <| h + state.deltaTime * 10. % 360.
//         | _ -> state.color

//     { state with color = hue }

/// Padding for the main window, just to have a nice black outline around it
// let padding = 10.

// open Fable.Core.JsInterop

/// <summary>Draws our scene</summary>
/// <param name="state"><see cref='T:App.State'/> used to draw our scene.</param>
// let Draw state =
//     let p = (point' padding)
//     let s = size (canvas.width - padding * 2.) (canvas.height - padding * 2.)

//     let cs = 12

//     (
//         use _ = new DrawContext { defaultStyle with fill=(Literal "darkgray"); }
//         p |> (Rectangle s).Draw
//     )
//     (
//         use _ = new DrawContext { defaultStyle with fill=(Literal "red"); }
//         context.font <- $"1em Consolas"
        
//         let tm = context.measureText("M")        
//         let fontAscent = tm?fontBoundingBoxAscent
//         let fontDescent = tm?fontBoundingBoxDescent
//         let bboxL = tm?actualBoundingBoxLeft
//         let bboxR = tm?actualBoundingBoxRight

//         let lineHeight = fontAscent+fontDescent
//         let blockWidth = bboxL + bboxR
        
//         for x in [(40-blockWidth)..blockWidth..400] do
//             for y in [(40-lineHeight)..lineHeight..400] do
//                 context.fillRect (float x, float y, 1., 1.)
//     )
//     (
//         use _ = new DrawContext { defaultStyle with fill=(Literal "black") }
//         context.font <- $"1em Consolas"

//         let tm = context.measureText("M")        
//         let fontAscent = tm?fontBoundingBoxAscent
//         let fontDescent = tm?fontBoundingBoxDescent
//         let bboxL = tm?actualBoundingBoxLeft
//         let bboxR = tm?actualBoundingBoxRight

//         let lineHeight = fontAscent+fontDescent
//         let blockWidth = bboxL + bboxR

//         let x = 40.
//         let y = 40.

//         context.fillText ("╭─────╮", x, y)
//         context.fillText ("│ Box │", x, y + lineHeight)
//         context.fillText ("╰─────╯", x, y + lineHeight * 2.)

//         let y = y + lineHeight * 5.

//         context.fillText (" ┌ ┬ ┐ ╭ ╮", x,  y)
//         context.fillText (" ├ ┼ ┤ ─ │", x,  y + lineHeight)
//         context.fillText (" └ ┴ ┘ ╰ ╯", x,  y + lineHeight * 2.)

//         let y = y + lineHeight * 5.

//         context.fillText ("abcdefghijklmnopqrstuvqxyz", x,  y)
//         context.fillText ("ABCDEFGHIJKLMNOPQRSTUVWXYZ", x,  y + lineHeight)
//         context.fillText ("0123456789[]{}()_-+=*%!?/\\|", x,  y + lineHeight * 2.)
//     )
//     (   
//         use _ = new DrawContext { defaultStyle with stroke=(Literal "magenta"); fill=(Literal "magenta") }
//         context.font <- $"1em Consolas"

//         let tm = context.measureText("M")
//         let w = tm.width
//         let fontAscent = tm?fontBoundingBoxAscent
//         let fontDescent = tm?fontBoundingBoxDescent
//         let bboxL = tm?actualBoundingBoxLeft
//         let bboxR = tm?actualBoundingBoxRight

//         let x = 120.
//         let y = 40.

//         // context.moveTo (x, y); context.lineTo (x + w, y)
//         context.moveTo (x + w, y); context.lineTo (x + w, y - fontAscent)
//         context.moveTo (x + w, y); context.lineTo (x + w, y + fontDescent)
//         context.moveTo (x + w, y); context.lineTo (x + w - bboxL, y)
//         context.moveTo (x + w, y); context.lineTo (x + w + bboxR, y)

//         context.fillText ($"W:{w} A:{fontDescent} D:{fontDescent}", x + 40., y)
//         context.fillText ($"L:{bboxL} R:{bboxR}", x + 40., y + (fontAscent + fontDescent))
//     )

/// <summary>
/// Main loop, will `cref:M:Update` our state, clear our canvas, then call `cref:M:App.Draw`.<br/>
/// Will use `requestAnimationFrame`.
/// </summary>
/// <param name="time">Time elapsed since our app started as a `Double`.</param>
/// <param name="state">Current <see cref='T:App.State'/>.</param>
// let rec Loop time state =
//     let dt = (time - state.time) / 1000.

//     let state = 
//         { state with
//             time = time;
//             deltaTime = dt;
//         } |> Update

//     let p = point' 0.
//     let s = size canvas.width canvas.height

//     (rect p s)
//     |> Clear

//     state
//     |> Draw

//     window.requestAnimationFrame (fun time -> state |> Loop time)
//     |> ignore

open Core.Systems
open Systems

SystemManager.Logger.Log "Hello Warudo!"
SystemManager.Logger.Debug "Hello Warudo!"
SystemManager.Logger.Info "Hello Warudo!"
SystemManager.Logger.Warn "Hello Warudo!"
SystemManager.Logger.Error "Hello Warudo!"

// Start ()
// |> Loop 0.

// WEGBL2 SANDBOX

open Browser.Dom
// open Browser.WebGL
// open Browser.Types
open Fable.Core.JS
open Fable.Core.JsInterop
open Fable.Core.JS

open WebGL
open WebGL2
open Fable.Core

let window = SystemManager.Window
let gl = SystemManager.Renderer
let GL = gl.As<RenderingContext.WebGL2RenderingContext>()

let createShader etype source =
    gl.CreateShader etype
    |> Shader.SetSource source
    |> Shader.Compile

    //     let result = gl.getShaderParameter (shader, gl.COMPILE_STATUS);
    //
    //     match gl.getShaderParameter (shader, gl.COMPILE_STATUS) with
    //     | U2.Case2 status when status = true ->
    //         Some shader
    //     | _ ->
    //         console.log (gl.getShaderInfoLog shader)
    //         gl.deleteShader (Some shader)
    //         None
    // | _ -> None

let createProgram vertexShader fragmentShader =
    gl.CreateProgram ()
    |> Program.AttachShader vertexShader
    |> Program.AttachShader fragmentShader
    |> Program.Link
    // |> Program.GetParameter GL.LINK_STATUS
    // |> Option.map (fun p ->
    //
    // )

    //     match gl.getProgramParameter (program, gl.LINK_STATUS) with
    //     | None ->
    //         console.log (gl.getProgramInfoLog program)
    //         gl.deleteProgram (Some program)
    //         None
    //     | _ -> Some program
    // | _ -> None

let vertexShaderSource = importDefault "${outDir}/../shaders/shader.vert"
let fragmentShaderSource = importDefault "${outDir}/../shaders/shader.frag"

let vertexShader = createShader GL.VERTEX_SHADER vertexShaderSource
let fragmentShader = createShader GL.FRAGMENT_SHADER fragmentShaderSource

let program = createProgram vertexShader fragmentShader

let positionAttributeLocation = program.GetAttributeLocation "a_position"
let resolutionUniformLocation = program.GetUniformLocation "u_resolution"

let positionBuffer = gl.CreateBuffer()
positionBuffer.Bind GL.ARRAY_BUFFER

let positions = [|
    10; 20;
    80; 20;
    10; 30;
    10; 30;
    80; 20;
    80; 30;
|]

let ff = Constructors.Float32Array.Create(positions)
gl.BufferData (gl.ARRAY_BUFFER, (Some (!^ ff.buffer)), gl.STATIC_DRAW)

let vao = gl.CreateVertexArray ()
vao.Bind ()

positionAttributeLocation.EnableVertexArray ()

let size = 2
let t = GL.FLOAT
let normalize = false
let stride = 0
let offset = 0

positionAttributeLocation.VertexPointer (size, t, normalize, stride, offset)

GL.viewport (0, 0, window.Width, window.Height)
GL.clearColor (0f, 0f, 0f, 0f)
// gl.clear gl.COLOR_BUFFER_BIT
GL.clear GL.COLOR_BUFFER_BIT

program.Use ()
resolutionUniformLocation.SetFloat (single window.Width, single window.Height)

vao.Bind ()

let primitiveType = GL.TRIANGLES;
// let offset = 0.0;
let count = 6;
GL.drawArrays (primitiveType, offset, count)

()
