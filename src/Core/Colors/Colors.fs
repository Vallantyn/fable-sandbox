module Core.Colors

/// Color stored as **RGBA**, packed in an `uint32` with `R` as the *least significant* octet:  
/// 
/// `|-------|-------|-------|-------`  
/// `A.......B.......G.......R.......`
type Color (n:uint32) =

    new () = Color(0u)
    
    new (r:byte, g:byte, b:byte, ?a:byte) =
        Color (Color.rgbaToPacked r g b (defaultArg a 0xFFuy))

    // new (r:single, g:single, b:single, ?a:single) =
    //     let r = r * 255.f |> byte
    //     let g = g * 255.f |> byte
    //     let b = b * 255.f |> byte
    //     let a = (defaultArg a 1.f) * 255.f |> byte
    //     Color(r, g, b, a)

    /// Red Component
    member My.R
        with get () = Color.packedToR My.Packed
        and  set  r = My.Packed <- (My.Packed &&& 0xFFFFFF00u) ||| Color.rToPacked r

    /// Green Component
    member My.G
        with get () = Color.packedToG My.Packed
        and  set  g = My.Packed <- (My.Packed &&& 0xFFFF00FFu) ||| Color.gToPacked g

    /// Blue Component
    member My.B
        with get () = Color.packedToB My.Packed
        and  set  b = My.Packed <- (My.Packed &&& 0xFF00FFFFu) ||| Color.bToPacked b

    /// Alpha Component
    member My.A
        with get () = Color.packedToA My.Packed
        and  set  a = My.Packed <- (My.Packed &&& 0x00FFFFFFu) ||| Color.aToPacked a

    /// Packed Value
    member val Packed = n with get, set

    override My.ToString() = $"rgba({My.R},{My.G},{My.B},{My.A})"

    member _.Gf = 0.f
    member _.Bf = 0.f
    member _.Rf = 0.f
    member _.Af = 0.f

    member _.Hue = 360.
    member _.Saturation = 0.
    member _.Luminance = 0.

    member _.ToRGBAString () = ""
    member _.ToHLSLString () = ""


(******************************************************************************
**                              *** Helpers ***                              **
******************************************************************************)

    static member internal rgbaToPacked (r:byte) (g:byte) (b:byte) (a:byte) =
        (uint32 a <<< 24) |||
        (uint32 b <<< 16) |||
        (uint32 g <<<  8) |||
        (uint32 r       )

    static member private packedToR n = byte (n        &&& 0xFFu)
    static member private rToPacked (r:byte) = (uint32 r)

    static member private packedToG n = byte (n >>>  8 &&& 0xFFu)
    static member private gToPacked (g:byte) = (uint32 g) <<< 8

    static member private packedToB n = byte (n >>> 16 &&& 0xFFu)
    static member private bToPacked (b:byte) = (uint32 b) <<< 16

    static member private packedToA n = byte (n >>> 24 &&& 0xFFu)
    static member private aToPacked (a:byte) = (uint32 a) <<< 24

    static member private packedToRgba n = (
        Color.packedToR n,
        Color.packedToG n,
        Color.packedToB n,
        Color.packedToA n
    )


(******************************************************************************
**                         *** Predefined Colors ***                         **
******************************************************************************)

    static member Transparent = Color 0x00000000u
    static member AliceBlue = Color 0xFFFFF8F0u
    static member AntiqueWhite = Color 0xFFD7EBFAu
    static member Aqua = Color 0xFFFFFF00u
    static member Aquamarine = Color 0xFFD4FF7Fu
    static member Azure = Color 0xFFFFFFF0u
    static member Beige = Color 0xFFDCF5F5u
    static member Bisque = Color 0xFFC4E4FFu
    static member Black = Color 0xFF000000u
    static member BlanchedAlmond = Color 0xFFCDEBFFu
    static member Blue = Color 0xFFFF0000u
    static member BlueViolet = Color 0xFFE22B8Au
    static member Brown = Color 0xFF2A2AA5u
    static member BurlyWood = Color 0xFF87B8DEu
    static member CadetBlue = Color 0xFFA09E5Fu
    static member Chartreuse = Color 0xFF00FF7Fu
    static member Chocolate = Color 0xFF1E69D2u
    static member Coral = Color 0xFF507FFFu
    static member CornflowerBlue = Color 0xFFED9564u
    static member Cornsilk = Color 0xFFDCF8FFu
    static member Crimson = Color 0xFF3C14DCu
    static member Cyan = Color 0xFFFFFF00u
    static member DarkBlue = Color 0xFF8B0000u
    static member DarkCyan = Color 0xFF8B8B00u
    static member DarkGoldenrod = Color 0xFF0B86B8u
    static member DarkGray = Color 0xFFA9A9A9u
    static member DarkGreen = Color 0xFF006400u
    static member DarkKhaki = Color 0xFF6BB7BDu
    static member DarkMagenta = Color 0xFF8B008Bu
    static member DarkOliveGreen = Color 0xFF2F6B55u
    static member DarkOrange = Color 0xFF008CFFu
    static member DarkOrchid = Color 0xFFCC3299u
    static member DarkRed = Color 0xFF00008Bu
    static member DarkSalmon = Color 0xFF7A96E9u
    static member DarkSeaGreen = Color 0xFF8BBC8Fu
    static member DarkSlateBlue = Color 0xFF8B3D48u
    static member DarkSlateGray = Color 0xFF4F4F2Fu
    static member DarkTurquoise = Color 0xFFD1CE00u
    static member DarkViolet = Color 0xFFD30094u
    static member DeepPink = Color 0xFF9314FFu
    static member DeepSkyBlue = Color 0xFFFFBF00u
    static member DimGray = Color 0xFF696969u
    static member DodgerBlue = Color 0xFFFF901Eu
    static member Firebrick = Color 0xFF2222B2u
    static member FloralWhite = Color 0xFFF0FAFFu
    static member ForestGreen = Color 0xFF228B22u
    static member Fuchsia = Color 0xFFFF00FFu
    static member Gainsboro = Color 0xFFDCDCDCu
    static member GhostWhite = Color 0xFFFFF8F8u
    static member Gold = Color 0xFF00D7FFu
    static member Goldenrod = Color 0xFF20A5DAu
    static member Gray = Color 0xFF808080u
    static member Green = Color 0xFF008000u
    static member GreenYellow = Color 0xFF2FFFADu
    static member Honeydew = Color 0xFFF0FFF0u
    static member HotPink = Color 0xFFB469FFu
    static member IndianRed = Color 0xFF5C5CCDu
    static member Indigo = Color 0xFF82004Bu
    static member Ivory = Color 0xFFF0FFFFu
    static member Khaki = Color 0xFF8CE6F0u
    static member Lavender = Color 0xFFFAE6E6u
    static member LavenderBlush = Color 0xFFF5F0FFu
    static member LawnGreen = Color 0xFF00FC7Cu
    static member LemonChiffon = Color 0xFFCDFAFFu
    static member LightBlue = Color 0xFFE6D8ADu
    static member LightCoral = Color 0xFF8080F0u
    static member LightCyan = Color 0xFFFFFFE0u
    static member LightGoldenrodYellow = Color 0xFFD2FAFAu
    static member LightGray = Color 0xFFD3D3D3u
    static member LightGreen = Color 0xFF90EE90u
    static member LightPink = Color 0xFFC1B6FFu
    static member LightSalmon = Color 0xFF7AA0FFu
    static member LightSeaGreen = Color 0xFFAAB220u
    static member LightSkyBlue = Color 0xFFFACE87u
    static member LightSlateGray = Color 0xFF998877u
    static member LightSteelBlue = Color 0xFFDEC4B0u
    static member LightYellow = Color 0xFFE0FFFFu
    static member Lime = Color 0xFF00FF00u
    static member LimeGreen = Color 0xFF32CD32u
    static member Linen = Color 0xFFE6F0FAu
    static member Magenta = Color 0xFFFF00FFu
    static member Maroon = Color 0xFF000080u
    static member MediumAquamarine = Color 0xFFAACD66u
    static member MediumBlue = Color 0xFFCD0000u
    static member MediumOrchid = Color 0xFFD355BAu
    static member MediumPurple = Color 0xFFDB7093u
    static member MediumSeaGreen = Color 0xFF71B33Cu
    static member MediumSlateBlue = Color 0xFFEE687Bu
    static member MediumSpringGreen = Color 0xFF9AFA00u
    static member MediumTurquoise = Color 0xFFCCD148u
    static member MediumVioletRed = Color 0xFF8515C7u
    static member MidnightBlue = Color 0xFF701919u
    static member MintCream = Color 0xFFFAFFF5u
    static member MistyRose = Color 0xFFE1E4FFu
    static member Moccasin = Color 0xFFB5E4FFu
    static member MonoGameOrange = Color 0xFF003CE7u
    static member NavajoWhite = Color 0xFFADDEFFu
    static member Navy = Color 0xFF800000u
    static member OldLace = Color 0xFFE6F5FDu
    static member Olive = Color 0xFF008080u
    static member OliveDrab = Color 0xFF238E6Bu
    static member Orange = Color 0xFF00A5FFu
    static member OrangeRed = Color 0xFF0045FFu
    static member Orchid = Color 0xFFD670DAu
    static member PaleGoldenrod = Color 0xFFAAE8EEu
    static member PaleGreen = Color 0xFF98FB98u
    static member PaleTurquoise = Color 0xFFEEEEAFu
    static member PaleVioletRed = Color 0xFF9370DBu
    static member PapayaWhip = Color 0xFFD5EFFFu
    static member PeachPuff = Color 0xFFB9DAFFu
    static member Peru = Color 0xFF3F85CDu
    static member Pink = Color 0xFFCBC0FFu
    static member Plum = Color 0xFFDDA0DDu
    static member PowderBlue = Color 0xFFE6E0B0u
    static member Purple = Color 0xFF800080u
    static member RebeccaPurple = Color 0xFF663399u
    static member Red = Color 0xFF0000FFu
    static member RosyBrown = Color 0xFF8F8FBCu
    static member RoyalBlue = Color 0xFFE16941u
    static member SaddleBrown = Color 0xFF13458Bu
    static member Salmon = Color 0xFF7280FAu
    static member SandyBrown = Color 0xFF60A4F4u
    static member SeaGreen = Color 0xFF578B2Eu
    static member SeaShell = Color 0xFFEEF5FFu
    static member Sienna = Color 0xFF2D52A0u
    static member Silver = Color 0xFFC0C0C0u
    static member SkyBlue = Color 0xFFEBCE87u
    static member SlateBlue = Color 0xFFCD5A6Au
    static member SlateGray = Color 0xFF908070u
    static member Snow = Color 0xFFFAFAFFu
    static member SpringGreen = Color 0xFF7FFF00u
    static member SteelBlue = Color 0xFFB48246u
    static member Tan = Color 0xFF8CB4D2u
    static member Teal = Color 0xFF808000u
    static member Thistle = Color 0xFFD8BFD8u
    static member Tomato = Color 0xFF4763FFu
    static member Turquoise = Color 0xFFD0E040u
    static member Violet = Color 0xFFEE82EEu
    static member Wheat = Color 0xFFB3DEF5u
    static member White = Color 0xFFFFFFFFu
    static member WhiteSmoke = Color 0xFFF5F5F5u
    static member Yellow = Color 0xFF00FFFFu
    static member YellowGreen = Color 0xFF32CD9Au
//#endregion
