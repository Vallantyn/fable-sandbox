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

SystemManager.Logger.Log "Hello Warudo!"
SystemManager.Logger.Debug "Hello Warudo!"
SystemManager.Logger.Info "Hello Warudo!"
SystemManager.Logger.Warn "Hello Warudo!"
SystemManager.Logger.Error "Hello Warudo!"

// Start ()
// |> Loop 0.

// WEGBL2 SANDBOX

open Browser.Dom
open Browser.WebGL
open Browser.Types
open Fable.Core.JS
open Fable.Core.JsInterop
open Fable.Core.JS

let canvas = document.getElementsByTagName("canvas")[0] :?> Browser.Types.HTMLCanvasElement

canvas.width <- window.innerWidth
canvas.height <- window.innerHeight

let gl = canvas.getContext_webgl2 ()

let createShader etype source =
    let shader = gl.createShader etype
    gl.shaderSource (shader, source)
    gl.compileShader shader
    let success = gl.getShaderParameter (shader, gl.COMPILE_STATUS)
    if success <> null then Some shader
    else
        console.log (gl.getShaderInfoLog shader)
        gl.deleteShader shader
        None

let createProgram vertexShader fragmentShader =
    let program = gl.createProgram()

    gl.attachShader (program, vertexShader)
    gl.attachShader (program, fragmentShader)

    gl.linkProgram program

    let success = gl.getProgramParameter (program, gl.LINK_STATUS)

    if success <> null then Some program
    else
        console.log (gl.getProgramInfoLog program)
        gl.deleteProgram program
        None

let vertexShaderSource = """#version 300 es
 
// an attribute is an input (in) to a vertex shader.
// It will receive data from a buffer
in vec4 a_position;
 
// all shaders have a main function
void main() {
 
  // gl_Position is a special variable a vertex shader
  // is responsible for setting
  gl_Position = a_position;
}
"""
 
let fragmentShaderSource = """#version 300 es
 
// fragment shaders don't have a default precision so we need
// to pick one. highp is a good default. It means "high precision"
precision highp float;
 
// we need to declare an output for the fragment shader
out vec4 outColor;
 
void main() {
  // Just set the output to a constant reddish-purple
  outColor = vec4(1, 0, 0.5, 1);
}
"""

let vertexShader = createShader gl.VERTEX_SHADER vertexShaderSource
let fragmentShader = createShader gl.FRAGMENT_SHADER fragmentShaderSource

console.log vertexShader
console.log fragmentShader

let program =
    match (vertexShader, fragmentShader) with
    | Some v, Some f -> createProgram v f
    | _, _ -> None

console.log program

let positionAttributeLocation =
    match program with
    | Some p -> Some (gl.getAttribLocation (p, "a_position"))
    | None -> None

console.log positionAttributeLocation

let positionBuffer = gl.createBuffer()
gl.bindBuffer (gl.ARRAY_BUFFER, positionBuffer)

let positions = [|
    -0.5; -0.5;
    -0.5;  0.5;
     0.5; -0.5;
|]

let f = Constructors.Float32Array.Create(positions)
gl.bufferData (gl.ARRAY_BUFFER, !^ f.buffer, gl.STATIC_DRAW)

let vao = gl.createVertexArray()
gl.bindVertexArray (vao)

console.log vao

match positionAttributeLocation with
| Some a -> gl.enableVertexAttribArray a
| None -> console.error "no pal"

let size = 2.0
let t = gl.FLOAT
let normalize = false
let stride = 0.0
let offset = 0.0

match positionAttributeLocation with
| Some a -> gl.vertexAttribPointer (a, size, t, normalize, stride, offset)
| None -> console.error "no pal"

gl.viewport (0, 0, canvas.width, canvas.height)
gl.clearColor (0, 0, 0, 0)
gl.clear gl.COLOR_BUFFER_BIT

match program with
| Some p -> gl.useProgram p
| None -> console.error "no program"

gl.bindVertexArray vao

let primitiveType = gl.TRIANGLES;
// let offset = 0.0;
let count = 3.0;
gl.drawArrays (primitiveType, offset, count)

()