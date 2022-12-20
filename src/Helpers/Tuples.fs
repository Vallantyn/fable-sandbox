module Helpers.Tuples

let fst' (n,_,_,_) = n
let snd' (_,n,_,_) = n
let trd (_,_,n) = n
let trd' (_,_,n,_) = n
let frt (_,_,_,n) = n

let (||||>) (a, b, c, d) f = f a b c d
let (<||||) (a, b, c, d) f = f a b c d