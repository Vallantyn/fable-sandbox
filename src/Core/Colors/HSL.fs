module Core.Colors.HSL

open Helpers.Maths.Operators

type HSL(hue, saturation, value) =
    inherit Color(0u)

    do
        let r, g, b = HSL.hslToRgb hue saturation value;
        base.Packed <- (Color.rgbaToPacked r g b 0xFFuy);

#if NORMALIZED_HSL
    new () = HSL(0., 1., 0.5)
#else // NORMALIZED_HSL
    new () = HSL(0., 100., 50.)
#endif // NORMALIZED_HSL

    member My.Hue = 0.
    member My.Saturation = 0.
    member My.Luminance = 0.

    override My.ToString() =
#if NORMALIZED_HSL
        $"hsl({My.Hue * 630.},{My.Saturation * 100.}%%,{My.Luminance * 100.}%%)"
#else // NORMALIZED_HSL
        $"hsl({My.Hue},{My.Saturation}%%,{My.Luminance}%%)"
#endif // NORMALIZED_HSL


(******************************************************************************
**                              *** Helpers ***                              **
******************************************************************************)

    static member rgbToHsl r g b =

        (* https://gist.github.com/avisek/eadfbe7a7a169b1001a2d3affc21052e
        **
        ** const r = rgb.r / 255
        ** const g = rgb.g / 255
        ** const b = rgb.b / 255
        ** 
        ** const max = Math.max(r, g, b), min = Math.min(r, g, b)
        ** let h, s, l = (max + min) / 2
        **
        ** if (max == min) {
        **   h = s = 0 // achromatic
        ** } else {
        **   const d = max - min
        **   s = l > 0.5 ? d / (2 - max - min) : d / (max + min)
        **
        **   switch (max) {
        **     case r:
        **       h = (g - b) / d + (g < b ? 6 : 0)
        **       break
        **     case g:
        **       h = (b - r) / d + 2
        **       break
        **     case b:
        **       h = (r - g) / d + 4
        **       break
        **   }
        **
        **   h /= 6
        ** }  
        *)

#if NORMALIZED_HSL
        let h = 1.
        let s = 1.
        let l = 0.5
#else // NORMALIZED_HSL
        let h = 1. * 360.
        let s = 1. * 100.
        let l = 0.5 * 100.
#endif // NORMALIZED_HSL

        (h, s, l)

    // Assume value are normalized
    static member hslToRgb h s l =
#if !NORMALIZED_HSL
        let h = HSL.NormalizeHue h
        let s = (0. %> s <% 100.) / 100.
        let l = (0. %> l <% 100.) / 100.
#endif // NOT NORMALIZED_HSL

        let r = 0uy
        let g = 0uy
        let b = 0uy

        (* https://gist.github.com/avisek/eadfbe7a7a169b1001a2d3affc21052e
        ** 
        ** if (s == 0) {
        **   r = g = b = l // achromatic
        ** } else {
        **   function hue2rgb(p, q, t) {
        **     if (t < 0) t += 1
        **     if (t > 1) t -= 1
        **     if (t < 1/6) return p + (q - p) * 6 * t
        **     if (t < 1/2) return q
        **     if (t < 2/3) return p + (q - p) * (2/3 - t) * 6
        **     return p
        **   }
        **
        **   const q = l < 0.5 ? l * (1 + s) : l + s - l * s
        **   const p = 2 * l - q
        **
        **   r = hue2rgb(p, q, h + 1/3)
        **   g = hue2rgb(p, q, h)
        **   b = hue2rgb(p, q, h - 1/3)
        ** }
        **
        ** r *= 255
        ** g *= 255
        ** b *= 255
        *)

        (r, g, b)

    static member private NormalizeHue hue =
        if hue < 0. then hue + 360. * (truncate(hue / 360.) + 1.)
        else hue % 360.
