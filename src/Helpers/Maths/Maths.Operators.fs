module Helpers.Maths.Operators

open Microsoft.FSharp.Core.LanguagePrimitives

let inline (%>) a b = max a b
let inline (<%) a b = min a b

let inline clamp value lower higher = lower %> value <% higher
let inline clamp01 value = GenericZero %> value <% GenericOne