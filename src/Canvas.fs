module Canvas

open Browser.Dom
open Fable.Core.JsInterop
open Fable.Import

let internal canvas = Browser.document.getElementsByTagName_canvas()[0]
let internal context = canvas.getContext_2d ()

let fillStyle (fillStyle:string) =
    context.fillStyle <- !^fillStyle
