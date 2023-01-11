#r "nuget: Pastel"
#r "nuget: Lorem.Universal.NET"

module Style = // 0 3 6 9 C F | 00 3F/40 7F/80 BF/C0 FF
    type Color =
    | Literal of string
    | Console of System.ConsoleColor

    type Size =
    | Auto
    | Value of int

    open Pastel
    open System.Runtime.CompilerServices

    [<Extension>]
    type StringEx =
        [<Extension>]
        static member inline Color(str:string, color:Color):string =
            match color with
            | Literal l -> str.Pastel(l)
            | Console c -> str.Pastel(c)

    type Color with 
        static member White = Literal "FFFFFF"
        static member LightGray = Literal "CCCCCC"
        static member Gray = Literal "7F7F7F"
        static member DarkGray = Literal "333333"
        static member Black = Literal "000000"

        static member Red = Literal "FF0000"
        static member DarkRed = Literal "CC0000"
        static member DarkestRed = Literal "330000"

        static member Yellow = Literal "FFFF00"
        static member DarkYellow = Literal "CCCC00"
        static member DarkestYellow = Literal "333300"

        static member Green = Literal "00FF00"
        static member DarkGreen = Literal "00CC00"
        static member DarkestGreen = Literal "003300"

        static member Cyan = Literal "00FFFF"
        static member DarkCyan = Literal "00CCCC"
        static member DarkestCyan = Literal "003333"

        static member Blue = Literal "0000FF"
        static member DarkBlue = Literal "0000CC"
        static member DarkestBlue = Literal "000033"

        static member Magenta = Literal "FF00FF"
        static member DarkMagenta = Literal "CC00CC"
        static member DarkestMagenta = Literal "330033"

    type TextStyle = { Color:Color }
    type Border = 
    | Simple
    | Double
    | Heavy

module ASCIIHelper =
    open Style
    open System.Text.RegularExpressions

    type BorderStyle =
        | Default of Style.Color
        | Double of Style.Color
        | Heavy of Style.Color

    type BorderStyle with
        static member DefaultStyle = Default Style.Color.White
        static member DefaultDouble = Double Style.Color.White
        static member DefaultHeavy = Heavy Style.Color.White

    type BoxStyle = {
        Text:Style.TextStyle;
        Top:BorderStyle;
        Bottom:BorderStyle;
        Left:BorderStyle;
        Right:BorderStyle;
    }
    
    type BoxStyle with
        member My.Borders style =
            { My with Top=style; Bottom=style; Left=style; Right=style}
        member My.Horizontal style =
            { My with Top=style; Bottom=style; }
        member My.Vertical style =
            { My with Left=style; Right=style}
    
    let DefaultStyle = {
        Text = { Color = Style.Color.White }
        Top = BorderStyle.DefaultStyle
        Bottom = BorderStyle.DefaultStyle
        Left = BorderStyle.DefaultStyle
        Right = BorderStyle.DefaultStyle
    }

    type BoxTileSets =
        static member simple                = "─│┌┬┐├┼┤└┴┘"
        static member double                = "═║╔╦╗╠╬╣╚╩╝"
        static member doubleVertical        = "─║╓╥╖╟╫╢╙╨╜"
        static member doubleHorizontal      = "═│╒╤╕╞╪╡╘╧╛"
        static member heavy                 = "━┃┏┳┓┣╋┫┗┻┛"
        static member heavyLeft             = "╾│┏┭┐┣┽┤┗┵┘"
        static member heavyRight            = "╼│┌┮┓├┾┫└┶┛"
        static member heavyHorizontal       = "━│┍┯┑┝┿┥┕┷┙"
        static member heavyUp               = "─╿┏┳┓┞╀┦└┴┘"
        static member heavyDown             = "─╽┌┬┐┟╁┧┗┻┛"
        static member heavyVertical         = "─┃┎┰┒┠╂┨┖┸┚"
        static member heavyUpLeft           = "─┃┏┱┐┡╃┤└┴┘"
        static member heavyUpRight          = "─┃┌┲┓├╄┩└┴┘"
        static member heavyDownLeft         = "─┃┌┬┐┢╅┤┗┹┘"
        static member heavyDownRight        = "─┃┌┬┐├╆┪└┺┛"
        static member heavyHorizontalUp     = "─┃┏┳┓┡╇┩└┴┘"
        static member heavyHorizontalDown   = "─┃┌┬┐┢╈┪┗┻┛"
        static member heavyVerticalLeft     = "─┃┏┱┐┣╉┤┗┹┘"
        static member heavyVerticalRight    = "─┃┌┲┓├╊┫└┺┛"

(*
simple/double: H or V
simple/heavy: U/D/L/R/H/V
*)
    
(* Window Styles
┌────────────┐ ╔════════════════╗ ╓───────────────┐
│   Simple   │ ║     Double     ║ ║ Bottom + Left │
└────────────┘ ╚════════════════╝ ╚═══════════════╛
╒════════════╕ ┌────────────────┐ ╒═══════════════╕
│    Top     │ │     Bottom     │ │ Top + Bottom  │
└────────────┘ ╘════════════════╛ ╘═══════════════╛
╓────────────┐ ┌────────────────╖ ╓───────────────╖
║    Left    │ │     Right      ║ ║ Left + Right  ║
╙────────────┘ └────────────────╜ ╙───────────────╜
╔════════════╕ ┌────────────────╖ ╒═══════════════╗
║ Top + Left │ │ Bottom + Right ║ │  Top + Right  ║
╙────────────┘ ╘════════════════╝ └───────────────╜

               ┏━━━━━━━━━━━━━━━━┓ ┎───────────────┐
               ┃     Heavy      ┃ ┃ Bottom + Left │
               ┗━━━━━━━━━━━━━━━━┛ ┗━━━━━━━━━━━━━━━┙
┍━━━━━━━━━━━━┑ ┌────────────────┐ ┍━━━━━━━━━━━━━━━┑
│    Top     │ │     Bottom     │ │ Top + Bottom  │
└────────────┘ ┕━━━━━━━━━━━━━━━━┙ ┕━━━━━━━━━━━━━━━┙
┎────────────┐ ┌────────────────┒ ┎───────────────┒
┃    Left    │ │     Right      ┃ ┃ Left + Right  ┃
┖────────────┘ └────────────────┚ ┖───────────────┚
┏━━━━━━━━━━━━┑ ┌────────────────┒ ┍━━━━━━━━━━━━━━━┓
┃ Top + Left │ │ Bottom + Right ┃ │  Top + Right  ┃
┖────────────┘ ┕━━━━━━━━━━━━━━━━┛ └───────────────┚
*)
    type Box (text, style:BoxStyle) =
        let style = style
        let text = text

        let height = 1;
        let paddingLeft = 1;
        let paddingRight = 1;

        member private My.RawValue =
            let rx = Regex(@"(\x9B|\x1B\[)[0-?]*[ -\/]*[@-~]", RegexOptions.Compiled)
            rx.Replace (text, "")
        
        member private My.Width = My.RawValue |> String.length
        member private _.PaddingHorizontal = paddingLeft + paddingRight
        member private _.PaddingLeft = " " |> String.replicate paddingLeft
        member private _.PaddingRight = " " |> String.replicate paddingRight
        
        member private My.HorizontalStyle style =
            let s =
                match style with
                | Double s -> ("═", s)
                | Heavy s -> ("━", s)
                | Default s -> ("─", s)

            let ss = 
                fst s
                |> String.replicate (My.Width + My.PaddingHorizontal)

            ss.Color(snd s)

        member private My.VerticalStyle style =
            match style with
            | Double s -> "║".Color(s)
            | Heavy s -> "┃".Color(s)
            | Default s -> "│".Color(s)
        
        member private _.Content = $"{text}".Color(style.Text.Color)
        
        member private My.Top      = My.HorizontalStyle style.Top
        
        member private _.TopRight  = 
            match (style.Top, style.Right) with
            | Default _, Double _ -> "╖"
            | Double _, Default _ -> "╕"
            | _, Double _ -> "╗"
            | Default _, Heavy _ -> "┒"
            | Heavy _, Default _ -> "┑"
            | _, Heavy _ -> "┓"
            | _, _ -> "┐"
            // | _, _ -> "╮"
        
        member private My.Right     = My.VerticalStyle style.Right
            
        member private _.DownRight = 
            match (style.Bottom, style.Right) with
            | Default _, Double _ -> "╜"
            | Double _, Default _ -> "╛"
            | _, Double _ -> "╝"
            | Default _, Heavy _ -> "┚"
            | Heavy _, Default _ -> "┙"
            | _, Heavy _ -> "┛"
            | _, _ -> "┘"
            // | _, _ -> "╮"
        
        member private My.Down     = My.HorizontalStyle style.Bottom
        
        member private _.DownLeft  = 
            match (style.Bottom, style.Left) with
            | Default _, Double _ -> "╙"
            | Double _, Default _ -> "╘"
            | _, Double _ -> "╚"
            | Default _, Heavy _ -> "┖"
            | Heavy _, Default _ -> "┕"
            | _, Heavy _ -> "┗"
            | _, _ -> "└"
            // | _, _ -> "╮"
        
        member private My.Left      = My.VerticalStyle style.Left
        
        member private _.TopLeft   = 
            match (style.Top, style.Left) with
            | Default _, Double _ -> "╓"
            | Double _, Default _ -> "╒"
            | _, Double _ -> "╔"
            | Default _, Heavy _ -> "┎"
            | Heavy _, Default _ -> "┍"
            | _, Heavy _ -> "┏"
            | _, _ -> "┌"
            // | _, _ -> "╮"

        member private My.Header = $"{My.TopLeft}{My.Top}{My.TopRight}\n"
        member private My.Body   = $"{My.Left}{My.PaddingLeft}{My.Content}{My.PaddingRight}{My.Right}\n" |> String.replicate height
        member private My.Footer = $"{My.DownLeft}{My.Down}{My.DownRight}"
        
        override My.ToString() = $"{My.Header}{My.Body}{My.Footer}"

(*
┌─┬─┐╒═╤═╕╓─╥─╖╔═╦═╗ ┌─┐╒═╕╓─╖╔═╗
├─┼─┤╞═╪═╡╟─╫─╢╠═╬═╣ └─┘╘═╛╙─╜╚═╝
└─┴─┘╘═╧═╛╙─╨─╜╚═╩═╝ ┌─┐┌─┐┌─┐┌─┐
┌─┬─┐┌─┬─┐┌─┬─┐┌─┬─┐ └╼┛┗━┛┗╾┘┗━┛
├─╆━┪┢━╈━┪┢━╅─┤┟─╁─┧ ┌╼┓┏━┓┏╾┐┍━┑
└─┺━┛┗━┻━┛┗━┹─┘┗━┻━┛ └╼┛┗━┛┗╾┘┕━┙
┌─┲━┓┏━┳━┓┏━┱─┐┍━┯━┑ ┌╼┓┏━┓┏╾┐┏━┓
├─╊━┫┣━╋━┫┣━╉─┤┝━┿━┥ └─┘└─┘└─┘└─┘
└─┺━┛┗━┻━┛┗━┹─┘┕━┷━┙ ┏━┓┏━┓┏━┓┌╼┓
┌─┲━┓┏━┳━┓┏━┱─┐┏━┳━┓ ┗╾┘└─┘└╼┛└╼┛
├─╄━┩┡━╇━┩┡━╃─┤┞─╀─┦ ┏╾┐┌─┐┌╼┓┎─┒
└─┴─┘└─┴─┘└─┴─┘└─┴─┘ ┗╾┘└─┘└╼┛┖─┚
┌─┮━┓┎─┰─┒┏━┭─┐─│╭─╮ ┏╾┐┌─┐┌╼┓┏╾┐
├─┾━┫┠─╂─┨┣━┽─┤═║╰─╯ ┗━┛┗━┛┗━┛┗╾┘
└─┶━┛┖─┸─┚┗━┵─┘━┃╾╼╿╽
*)
        
(*       ▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚▚
 ╌ ┄ ┈   ┌─────┐╭─────╮┌╌╌╌╌╌┐┌┄┄┄┄┄┐┌┈┈┈┈┈┐┌╴───╶┐ ▁▁▁▁▁
 ╍ ┅ ┉   │ Box ││ Box │╎ Box ╎┆ Box ┆┊ Box ┊╵ Box ╷ ▏▓▒░▕
 ╎ ┆ ┊   └─────┘╰─────╯└╌╌╌╌╌┘└┄┄┄┄┄┘└┈┈┈┈┈┘└╴───╶┘ ▔▔▔▔▔
 ╏ ┇ ┋   ┏━━━━━┓┏━━━━━┓┏╍╍╍╍╍┓┏┅┅┅┅┅┓┏┉┉┉┉┉┓┏╸━━━╺┓ ▄▄▄▄▄
 ╴ ╵ ╶ ╷ ┃ Box ┃┃ Box ┃╏ Box ╏┇ Box ┇┋ Box ┋╹ Box ╻ ▌▓▒░▐
 ╸ ╹ ╺ ╻ ┗━━━━━┛┗━━━━━┛┗╍╍╍╍╍┛┗┅┅┅┅┅┛┗┉┉┉┉┉┛┗╸━━━╺┛ ▀▀▀▀▀
 ╭─╮     ▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞
 ╰─╯     ▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞▞
 ╳ ╱ ╲   
 ▗▄▄▄▖
 ▐ A ▌
 ▝▀▀▀▘
*)

    type Block =
        static member Full = '█'
        static member BottomHalf = '▄'
        static member LeftSide = '▌'
        static member RigthSide = '▐'
        static member TopHalf = '▀'
        static member Square = '■'
        
        static member Empty = ' '

    /// Block Elements<br/>
    /// <code>▀▁▂▃▄▅▆▇█▉▊▋▌▍▎</code><br/>
    /// <code>▐░▒▓▔▕▖▗▘▙▚▛▜▝▞▟</code>
    type BlockElements =
        /// Upper Half BLock - <code>▀ (0x2580)</code>
        static member UpperHalf = '▀'
        
        /// Lower 1/8 Block - <code>▁ (0x2581)</code>
        static member LowerEighth = '▁'
        
        /// Lower 2/8 (1/4) Block - <code>▂ (0x2582)</code>
        static member LowerQuarter = '▂'
        
        /// Lower 3/8 Block - <code>▃ (0x2583)</code>
        static member LowerThreeEighths = '▃'
        
        /// Lower 4/8 (1/2) Block - <code>▄ (0x2584)</code>
        static member LowerHalf = '▄' // Lower 4/8 | 2/4 | 1/2 (0b1100)
        
        /// Upper Left Quadrant - <code>▅ (0x2585)</code>
        static member LowerFiveEighths = '▅' // Lower 5/8
        
        /// Upper Left Quadrant - <code>▆ (0x2586)</code>
        static member LowerThreeQuarters = '▆' // Lower 6/8 | 3/4
        
        /// Upper Left Quadrant - <code>▇ (0x2587)</code>
        static member LowerSevenEighths = '▇' // Lower 7/8
        
        /// Upper Left Quadrant - <code>█ (0x2588)</code>
        static member Full              = '█' // Full (0b1111)
        
        /// Upper Left Quadrant - <code>▉ (0x2589)</code>
        static member LeftSevenEighths  = '▉' // Left 7/8
        
        /// Upper Left Quadrant - <code>▊ (0x258A)</code>
        static member LeftThreeQuarters = '▊' // Left 6/8 | 3/4
        
        /// Upper Left Quadrant - <code>▋ (0x258B)</code>
        static member LeftFiveEighths   = '▋' // Left 5/8
        
        /// Upper Left Quadrant - <code>▌ (0x258C)</code>
        static member LeftHalf          = '▌' // Left 4/8 | 2/4 | 1/2 (0b0101)
        
        /// Upper Left Quadrant - <code>▍ (0x258D)</code>
        static member LeftThreeEighths = '▍' // Left 3/8
        
        /// Upper Left Quadrant - <code>▎ (0x258E)</code>
        static member LeftQuarter       = '▎' // Left 2/8 | 1/4
        
        /// Upper Left Quadrant - <code>▏ (0x258F)</code>
        static member LeftEighth        = '▏' // Left 1/8
        
        /// Upper Left Quadrant - <code>▐ (0x2590)</code>
        static member RightHalf         = '▐' // Right 1/2 (0b1010)
        
        
        /// Light Shade - <code>░ (0x2591)</code>
        static member ShadeLight = '░' // Light Shade
        
        /// Medium Shade - <code>▒ (0x2592)</code>
        static member ShadeMedium = '▒' // Medium Shade
        
        /// Dark Shade - <code>▓ (0x2593)</code>
        static member ShadeDark = '▓' // Dark Shade
        
        
        /// Upper Left Quadrant - <code>▔ (0x2594)</code>
        static member UpperEighth = '▔' // Upper 1/8
        
        /// Upper Left Quadrant - <code>▕ (0x2595)</code>
        static member RightEighth = '▕' // Right 1/8
        
        
        /// Upper Left Quadrant - <code>0b0001: ▘ (0x2598)</code>
        static member QuadrantUpperLeft             = '▘' // 0b0001 | Quadrant Upper Left
        
        /// Upper Right Quadrant - <code>0b0001: ▝ (0x259D)</code>
        static member QuadrantUpperRight            = '▝' // 0b0010 | Quadrant Upper Right
        
        /// Upper Quadrant (Upper Left + Upper Right) - <code>0b0001: ▀ (0x2580)</code>
        static member QuadrantUpper                 = '▀' // 0b0011
        
        /// Lower Left Quadrant - <code>0b0001: ▖ (0x2596)</code>
        static member QuadrantLowerLeft             = '▖' // 0b0100 | Quadrant Lower Left
        
        /// Left Quadrant (Upper Left + Lower Left) - <code>0b0001: ▌ (0x258C)</code>
        static member QuadrantLeft                  = '▌' // 0b0101
        
        /// Upper Right + Lower Left Quadrant - <code>0b0001: ▞ (0x259E)</code>
        static member QuadrantUpperRightLowerLeft   = '▞' // 0b0110 | Quadrant Upper Right + Lower Left
        
        /// Upper (Left & Right) + Lower Left Quadrant - <code>0b0001: ▛ (0x259B)</code>
        static member QuadrantUpperLowerLeft        = '▛' // 0b0111 | Quadrant Upper + Lower Left
        
        /// Lower Right Quadrant - <code>0b0001: ▗ (0x2597)</code>
        static member QuadrantLowerRight            = '▗' // 0b1000 | Quadrant Lower Right
        
        /// Upper Left + Lower Right Quadrant - <code>0b0001: ▚ (0x259A)</code>
        static member QuadrantUpperLeftLowerRight   = '▚' // 0b1001 | Quadrant Upper Left + Lower Right
        
        /// Right (Upper Right + Lower Right) Quadrant - <code>0b0001: ▐ (0x2590)</code>
        static member QuadrantRight                 = '▐' // 0b1010
        
        /// Upper (Left & Right) + Lower Right Quadrant - <code>0b0001: ▜ (0x259C)</code>
        static member QuadrantUpperLowerRight       = '▜' // 0b1011 | Quadrant Upper + Lower Right
        
        /// Lower (Lower Left + Lower Right) Quadrant - <code>0b0001: ▄ (0x2584)</code>
        static member QuadrantLower                 = '▄' // 0b1100
        
        /// Upper Left + Lower (Left & Right) Quadrant - <code>0b0001: ▙ (0x2599)</code>
        static member QuadrantUpperLeftLower        = '▙' // 0b1101 | Quadrant Upper Left + Lower
        
        /// Upper Right + Lower (Left & Right) Quadrant - <code>0b0001: ▟ (0x259F)</code>
        static member QuadrantUpperRightLower       = '▟' // 0b1110 | Quadrant Upper Right + Lower
        
        /// Full Quadrant - <code>0b0001: █ (0x2588)</code>
        /// <remarks>Same character as `BlockElements.Full`</remarks>
        static member QuadrantFull                  = '█' // 0b1111

        /// Empty Block - <code>0b0000:   (0x00A0)</code><br/>
        /// <remarks>Note: Not a whitespace</remarks>
        static member Empty = ' '
        
        /// Returns a quadrant from 4 bits (0bBR_BL_UR_UL)
        static member GetQuadrant (n:int) =
            let quadrants = " ▘▝▀▖▌▞▛▗▚▐▜▄▙▟█"
            let index = 
                if n < 0 then 0
                elif n > 15 then 15
                else n

            quadrants[index]
(*
/// Geometric Shapes
■□▢▣▤▥▦▧▨▩▪▫▬▭▮▯
▰▱▲△▴▵▶▷▸▹►▻▼▽▾▿
◀◁◂◃◄◅◆◇◈◉◊○◌◍◎●
◐◑◒◓◔◕◖◗◘◙◚◛◜◝◞◟
◠◡◢◣◤◥◦◧◨◩◪◫◬◭◮◯
◰◱◲◳◴◵◶◷◸◹◺◻◼◽◾◿

 🞀 🞐 🞠 🞰 🟀 🟐 🟠 🟰
 🞁 🞑 🞡 🞱 🟁 🟑 🟡
 🞂 🞒 🞢 🞲 🟂 🟒 🟢
 🞃 🞓 🞣 🞳 🟃 🟓 🟣
 🞄 🞔 🞤 🞴 🟄 🟔 🟤
 🞅 🞕 🞥 🞵 🟅 🟕 🟥
 🞆 🞖 🞦 🞶 🟆 🟖 🟦
 🞇 🞗 🞧 🞷 🟇 🟗 🟧
 🞈 🞘 🞨 🞸 🟈 🟘 🟨
 🞉 🞙 🞩 🞹 🟉 🟙 🟩
 🞊 🞚 🞪 🞺 🟊   🟪
 🞋 🞛 🞫 🞻 🟋   🟫
 🞌 🞜 🞬 🞼 🟌
 🞍 🞝 🞭 🞽 🟍
 🞎 🞞 🞮 🞾 🟎
 🞏 🞟 🞯 🞿 🟏

/// Braille: can be coded as a uint8 (0x00-0xFF)
⠀⠁⠂⠃⠄⠅⠆⠇⠈⠉⠊⠋⠌⠍⠎⠏
⠐⠑⠒⠓⠔⠕⠖⠗⠘⠙⠚⠛⠜⠝⠞⠟
⠠⠡⠢⠣⠤⠥⠦⠧⠨⠩⠪⠫⠬⠭⠮⠯
⠰⠱⠲⠳⠴⠵⠶⠷⠸⠹⠺⠻⠼⠽⠾⠿
⡀⡁⡂⡃⡄⡅⡆⡇⡈⡉⡊⡋⡌⡍⡎⡏
⡐⡑⡒⡓⡔⡕⡖⡗⡘⡙⡚⡛⡜⡝⡞⡟
⡠⡡⡢⡣⡤⡥⡦⡧⡨⡩⡪⡫⡬⡭⡮⡯
⡰⡱⡲⡳⡴⡵⡶⡷⡸⡹⡺⡻⡼⡽⡾⡿
⢀⢁⢂⢃⢄⢅⢆⢇⢈⢉⢊⢋⢌⢍⢎⢏
⢐⢑⢒⢓⢔⢕⢖⢗⢘⢙⢚⢛⢜⢝⢞⢟
⢠⢡⢢⢣⢤⢥⢦⢧⢨⢩⢪⢫⢬⢭⢮⢯
⢰⢱⢲⢳⢴⢵⢶⢷⢸⢹⢺⢻⢼⢽⢾⢿
⣀⣁⣂⣃⣄⣅⣆⣇⣈⣉⣊⣋⣌⣍⣎⣏
⣐⣑⣒⣓⣔⣕⣖⣗⣘⣙⣚⣛⣜⣝⣞⣟
⣠⣡⣢⣣⣤⣥⣦⣧⣨⣩⣪⣫⣬⣭⣮⣯
⣰⣱⣲⣳⣴⣵⣶⣷⣸⣹⣺⣻⣼⣽⣾⣿

/// Misc Symbols/Arrows
⬀ ⬁ ⬂ ⬃ ⬄ ⬅ ⬆ ⬇ ⬈ ⬉ ⬊ ⬋ ⬌ ⬍ ⬎ ⬏
⬐ ⬑ ⬒ ⬓ ⬔ ⬕ ⬖ ⬗ ⬘ ⬙ ⬚ ⬛ ⬜ ⬝ ⬞ ⬟
⬠ ⬡ ⬢ ⬣ ⬤ ⬥ ⬦ ⬧ ⬨ ⬩ ⬪ ⬫ ⬬ ⬭ ⬮ ⬯
⬰ ⬱ ⬲ ⬳ ⬴ ⬵ ⬶ ⬷ ⬸ ⬹ ⬺ ⬻ ⬼ ⬽ ⬾ ⬿
⭀ ⭁ ⭂ ⭃ ⭄ ⭅ ⭆ ⭇ ⭈ ⭉ ⭊ ⭋ ⭌ ⭍ ⭎ ⭏
⭐ ⭑ ⭒ ⭓ ⭔ ⭕ ⭖ ⭗ ⭘ ⭙ ⭚ ⭛ ⭜ ⭝ ⭞ ⭟
⭠ ⭡ ⭢ ⭣ ⭤ ⭥ ⭦ ⭧ ⭨ ⭩ ⭪ ⭫ ⭬ ⭭ ⭮ ⭯
⭰ ⭱ ⭲ ⭳     ⭶ ⭷ ⭸ ⭹ ⭺ ⭻ ⭼ ⭽ ⭾ ⭿
⮀ ⮁ ⮂ ⮃ ⮄ ⮅ ⮆ ⮇ ⮈ ⮉ ⮊ ⮋ ⮌ ⮍ ⮎ ⮏
⮐ ⮑ ⮒ ⮓ ⮔ ⮕   ⮗ ⮘ ⮙ ⮚ ⮛ ⮜ ⮝ ⮞ ⮟
⮠ ⮡ ⮢ ⮣ ⮤ ⮥ ⮦ ⮧ ⮨ ⮩ ↖ ⮫ ⮬ ⮭ ⮮ ⮯
⮰ ⮱ ⮲ ⮳ ⮴ ⮵ ⮶ ⮷ ⇪ ⮹ ⮺ ⮻ ⮼ ⮽ ⮾ ⮿
⯀ ⯁ ⯂ ⯃ ⯄ ⯅ ⯆ ⯇ ⯈ ⯉ ⯊ ⯋ ⯌ ⯍ ⯎ ⯏
⯐ ⯑ ⯒ ⯓ ⯔ ⯕ ⯖ ⯗ ⯘ ⯙ ⯚ ⯛ ⯜ ⯝ ⯞ ⯟
⯠ ⯡ ⯢ ⯣ ⯤ ⯥ ⯦ ⯧ ⯨ ⯩ ⯪ ⯫ ⯬ ⯭ ⯮ ⯯
⯰ ⯱ ⯲ Í Ê Ã Ë Ì È ⯹ ⯺ ⯻ ⯼ ⯽ ⯾ ⯿

/// Emojis
😀😁😂😃😄😅😆😇😈😉😊😋😌😍😎😏
😐😑😒😓😔😕😖😗😘😙😚😛😜😝😞😟
😠😡😢😣😤😥😦😧😨😩😪😫😬😭😮😯
😰😱😲😳😴😵😶😷😸😹😺😻😼😽😾😿
🙀🙁🙂🙃🙄🙅🙆🙇🙈🙉🙊🙋🙌🙍🙎�
*)

    type Symbols =
        static member Smiley = '☺'
        static member SmileyFull = '☻'
        static member Heart = '♥'
        static member Diamond = '♦'
        static member Clover = '♣'
        static member Pike = '♠'
        static member Dot = '•'
        static member DotFull = '◘'
        static member Circle = '○'
        static member CircleFull = '◙'
        static member Male = '♂'
        static member Female = '♀'
        static member NoteSingle = '♪'
        static member NoteDouble = '♫'
        static member Sun = '☼'
        static member Right = '►'
        static member Left = '◄'
        static member ArrowDoubleVertical = '↕'
        static member DoubleExclamation = '‼'
        static member LineBreak = '¶'
        static member Paragraph = '§'
        static member Pipe = '▬'
        static member AnotherDoubleArrow = '↨'
        static member ArrowUp = '↑'
        static member ArrowDown = '↓'
        static member ArrowRight = '→'
        static member ArrowLeft = '←'
        static member Corner = '∟'
        static member ArrowDoubleHorizontal = '↔'
        static member Up = '▲'
        static member Down = '▼'
        static member Home = '⌂'
    
module HSL =
    open type System.Math

    type HSL =
        static member toRgb (h:int, ?s:int, ?l:int) =
            let epsilon = 1./1000.
            
            let h = float h
            let s = float <| defaultArg s 100
            let l = float <| defaultArg l 50
            
            let h = (HSL.NormalizeHue h) / 360.
            let s = Clamp(s, 0., 100.) / 100.
            let l = Clamp(l, 0., 100.) / 100.

            let hue2rgb p q t =
                let t = if   t < 0. then t + 1.
                        elif t > 1. then t - 1.
                        else t

                if   t < 1./6. then (p + (q-p) * 6. * t)
                elif t < 1./2. then q
                elif t < 2./3. then (p + (q-p) * (2./3. - t) * 6.)
                else p
 
            let q = if l < 0.5 then l * (1. + s) else l + s - l * s
            let p = 2. * l - q
 
            let r = if s < epsilon then l else hue2rgb p q (h + 1./3.)
            let g = if s < epsilon then l else hue2rgb p q h
            let b = if s < epsilon then l else hue2rgb p q (h - 1./3.)
            
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
            
            let r = r * 255. |> byte
            let g = g * 255. |> byte
            let b = b * 255. |> byte

            (r, g, b)

        static member private NormalizeHue hue =
            if hue < 0. then hue + 360. * (truncate(hue / 360.) + 1.)
            else hue % 360.

    
// module App =
open System
open type Console
open ASCIIHelper
open Style
// open System.Drawing

let k = 8
let light = String(BlockElements.ShadeLight, k)
let medium = String(BlockElements.ShadeMedium, k)
let dark = String(BlockElements.ShadeDark, k)
let full = String(BlockElements.Full, k)
let lightSquare = String(BlockElements.ShadeLight, 2)
let mediumSquare = String(BlockElements.ShadeMedium, 2)
let darkSquare = String(BlockElements.ShadeDark, 2)
let fullSquare = String(BlockElements.Full, 2)

// for b in n do
//     for g in n do
//         for r in n do
//             let color = $"{r:X2}{g:X2}{b:X2}"
//             let bgColor = $"{(0xFF-r):X2}{(0xFF-g):X2}{(0xFF-b):X2}"
//             let str = lightSquare + mediumSquare + darkSquare + fullSquare
//             Write("⣿⣿".Pastel(color))
//         ResetColor()
//         WriteLine()

let hexcolor = LoremNET.Lorem.HexNumber(6)

let colors = [|
    (Color.DarkGray, Color.LightGray)
    (Color.DarkestRed, Color.DarkRed)
    (Color.DarkestGreen, Color.DarkGreen)
    (Color.DarkestBlue, Color.DarkBlue)
    (Color.DarkestCyan, Color.DarkCyan)
    (Color.DarkestMagenta, Color.DarkMagenta)
    (Color.DarkestYellow, Color.DarkYellow)
|]

let genText (min:int) (max:int) (text:Style.Color) (accent:Style.Color) = 
    let str = LoremNET.Lorem.Sentence(min, max).Split ' '
    let accentIndex = LoremNET.Lorem.Integer(0, str |> Array.length)
    let nstr =
        str 
        |> Array.mapi (fun i s -> if i = accentIndex then s.Color(accent) else s)
        |> String.concat " "
    nstr.Color(text)

let genText' min max =
    let baseColor = Literal (LoremNET.Lorem.HexNumber 6)
    let accentColor = Literal (LoremNET.Lorem.HexNumber 6)
    // let theme = (baseColor, accentColor)
    genText min max baseColor accentColor
    
let style = { DefaultStyle with Text = { Color = Color.DarkGray }}

let s = genText 2 5 Color.DarkCyan Color.Cyan

WriteLine(Box(genText' 3 5, style))
WriteLine(Box(genText' 3 5, style.Borders(BorderStyle.DefaultDouble)))
WriteLine(Box(genText' 3 5, style.Borders(BorderStyle.DefaultHeavy)))
WriteLine(Box(genText' 3 5, style.Horizontal(BorderStyle.DefaultDouble)))
WriteLine(Box(genText' 3 5, style.Vertical(BorderStyle.DefaultDouble)))
WriteLine(Box(genText' 3 5, style.Horizontal(BorderStyle.DefaultHeavy)))
WriteLine(Box(genText' 3 5, style.Vertical(BorderStyle.DefaultHeavy)))
WriteLine(Box(genText' 3 5, style.Horizontal(BorderStyle.DefaultDouble).Vertical(BorderStyle.DefaultHeavy)))
WriteLine(Box(genText' 3 5, style.Vertical(BorderStyle.DefaultDouble).Horizontal(BorderStyle.DefaultHeavy)))

// CursorVisible <- false

// let mutable n = 0

// let rand = Random()

// let ss = seq {
//     for h in [0..399] do
//         rand.Next() % 360
// }
// let s = ss |> Seq.toArray

// while true do
//     // SetCursorPosition(0,0)
//     Clear()
//     for h in s do
//         let (r, g, b) = HSL.HSL.toRgb (h-n)
//         let c = $"{r:X2}{g:X2}{b:X2}"
//         Write("⣿⣿".Pastel(c))

//     n <- (n+1)%360

//     Threading.Thread.Sleep(1000/60)

// let gba = [
//         "081820";
//         "346856";
//         "88C070";
//         "E0F8D0"
//     ]

// Write("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿".Pastel(gba[0]))
// Write("                        ".PastelBg(gba[3]))
// WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿".Pastel(gba[0]).PastelBg(gba[3]))
// Write("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿".Pastel(gba[1]))
// Write("                        ".PastelBg(gba[2]))
// WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿".Pastel(gba[1]).PastelBg(gba[2]))
// Write("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿".Pastel(gba[2]))
// Write("                        ".PastelBg(gba[1]))
// WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿".Pastel(gba[2]).PastelBg(gba[1]))
// Write("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿".Pastel(gba[3]))
// Write("                        ".PastelBg(gba[0]))
// WriteLine("⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿".Pastel(gba[3]).PastelBg(gba[0]))