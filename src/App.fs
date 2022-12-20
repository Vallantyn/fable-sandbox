/// App Module
module App

open Browser

open Types
open Canvas

/// App's state
type State = {
    /// Current Time
    time:float;
    /// Time elpased since last <see cref='M:App.Update'/>
    deltaTime:float;
    /// Background <see cref="T:Canvas.Color" />
    color:Color;
}

/// <summary>Setup of the App</summary>
/// <returns>Initial <see cref='T:App.State'/>.</returns>
let Start () =
    window.addEventListener ("resize", onWindowResize)
    setupWindow ()
    {
        time=0.;
        deltaTime=0.;
        color=(Hue 90);
    }

/// <summary>Updates our State</summary>
/// <param name="state">Current <see cref='T:App.State'/> to update.</param>
/// <returns>An updated <see cref='T:App.State'/>.</returns>
let Update state:State =
    let hue =
        match state.color with
        | Hue h -> Hue <| h + state.deltaTime * 10. % 360.
        | _ -> state.color

    { state with color = hue }

/// Padding for the main window, just to have a nice black outline around it
let padding = 10.

/// <summary>Draws our scene</summary>
/// <param name="state"><see cref='T:App.State'/> used to draw our scene.</param>
let Draw state =
    let p = (point' padding)
    let s = size (canvas.width - padding * 2.) (canvas.height - padding * 2.)

    ( use d = new DrawContext { defaultStyle with fill=state.color; }
    p |> (Rectangle s).Draw )

/// <summary>
/// Main loop, will `cref:M:Update` our state, clear our canvas, then call `cref:M:App.Draw`.<br/>
/// Will use `requestAnimationFrame`.
/// </summary>
/// <param name="time">Time elapsed since our app started as a `Double`.</param>
/// <param name="state">Current <see cref='T:App.State'/>.</param>
let rec Loop time state =
    let dt = (time - state.time) / 1000.

    let state = 
        { state with
            time = time;
            deltaTime = dt;
        } |> Update

    let p = point' 0.
    let s = size canvas.width canvas.height

    (rect p s)
    |> Clear

    state
    |> Draw

    window.requestAnimationFrame (fun time -> state |> Loop time)
    |> ignore

Start ()
|> Loop 0.
