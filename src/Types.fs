module Types

open Helpers.Tuples

type Point = {x:float;y:float;}
let point x y = {x=x;y=y;}
let point' n = {x=n;y=n;}
let point2tuple p = (p.x,p.y)
let tuple2point t = {x=(fst t);y=(snd t)}

type Size = {w:float;h:float;}
let size w h = {w=w;h=h;}
let size2tuple s = (s.w,s.h)
let tuple2size t = {w=(fst t);h=(snd t)}

type Rect = {p:Point;s:Size;}
let rect p s = {p=p;s=s;}
let rect2tuple r = (r.p.x,r.p.y,r.s.w,r.s.h)
let tuple2rect t = { p={x=(fst' t);y=(snd' t);}; s={w=(trd' t);h=(frt t);}; }

type HSL = { h: float; s: float; l: float; }
let hsl h s l = {h=h; s=s; l=l}
let hue h = {h=h;s=100.;l=50.}
let hsl2str hsl = $"hsl({hsl.h},{hsl.s}%%,{hsl.l}%%)"

type RGB = { r:int; g:int; b:int; }
let rgb r g b = {r=r;g=g;b=b}
let rgb2str rgb = $"rgb({rgb.r},{rgb.g},{rgb.b})"