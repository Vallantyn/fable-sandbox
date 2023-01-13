#r "nuget: Silk.Net"
#r "nuget: Pastel"

open System

open Silk.NET.Input;
open Silk.NET.OpenGL;
open Silk.NET.Maths;
open Silk.NET.Windowing;

open Pastel
open Silk.NET.OpenGL

Console.WriteLine ($"""Hello {"Silk".Pastel (ConsoleColor.Cyan)}!""")

let vertices = [|
     0.5;  0.5; 0.0;
     0.5; -0.5; 0.0;
    -0.5; -0.5; 0.0;
    -0.5;  0.5; 0.5;
|]

let mutable options = WindowOptions.Default
options.Size <- Vector2D<int>(800, 600)
options.Title <- "LearnOpenGL with Silk.NET, F# Edition!"

let window = Window.Create options

let mutable gl:GL = null

let onKeyDown (_:IKeyboard) (key:Key) (_:int): unit =
    if key = Key.Escape then window.Close ()
    else ()

let onLoad () =
    let input = window.CreateInput ()
    for kb in input.Keyboards do
        kb.add_KeyDown onKeyDown

    gl <- GL.GetApi (window)

    let vao = gl.GenVertexArray ()
    gl.BindVertexArray (vao)

    let vbo = gl.GenBuffer ()
    gl.BindBuffer (BufferTargetARB.ArrayBuffer, vbo)

    let v = fixed &vertices[0]
    // let v = v |> NativeInterop.NativePtr.toVoidPtr
    gl.BufferData (BufferTargetARB.ArrayBuffer, unativeint (vertices.Length * sizeof<uint>), (NativeInterop.NativePtr.toVoidPtr v), BufferUsageARB.StaticDraw)

let onUpdate (dt) = ()

let onRender (dt) = ()

let onClose () = ()

window.add_Load onLoad
window.add_Update onUpdate
window.add_Render onRender
window.add_Closing onClose

window.Run ()