(**
---
title: A Literate Script
category: Samples
categoryindex: 1
index: 1
---
*)

(*** condition: prepare ***)
#nowarn "211"
#I "../src/bin/Debug/net7.0"
#r "App.dll"

(**
# App Sample
Opens
*)
open App

(**
Lets bindings
*)
let ExampleVar = 0

(**
Application Start
*)
Start()
|> Loop 0.