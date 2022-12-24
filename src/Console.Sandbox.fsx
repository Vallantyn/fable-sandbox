#r "nuget: Pastel"

open System;
open type Console;

module ASCIIHelper =
    
    type Graphic =
        static member Light = '░'
        static member Medium = '▒'
        static member Dark = '▓'

    /// Simple Box         <br/>
    /// <code> ─ │ </code><br/>
    /// <code> ┌┬┐ </code><br/>
    /// <code> ├┼┤ </code><br/>
    /// <code> └┴┘ </code>
    type Box_Single =
            static member simple = "─│┌┬┐├┼┤└┴┘"
            static member Vertical = '│'
            static member Horizontal = '─'
            static member TopRight = '┐'
            static member BottomRight = '┘'
            static member BottomLeft = '└'
            static member TopLeft = '┌'
            static member Bottom = '┴'
            static member Top = '┬'
            static member Left = '├'
            static member Right = '┤'
            static member Center = '┼'

    /// Double Box        <br/>
    /// <code> ═ ║ </code><br/>
    /// <code> ╔╦╗ </code><br/>
    /// <code> ╠╬╣ </code><br/>
    /// <code> ╚╩╝ </code>
    type Box_Double =
        static member double = "═║╔╦╗╠╬╣╚╩╝"
        static member Vertical = '║'
        static member Horizontal = '═'
        static member TopRight = '╗'
        static member BottomRight = '╝'
        static member BottomLeft = '╚'
        static member TopLeft = '╔'
        
        static member Top = '╦'
        static member Right = '╣'
        static member Bottom = '╩'
        static member Left = '╠'
        static member Center = '╬'
        
    /// Double / Single Box<br/>
    /// <code> ╓╥╖ </code><br/>
    /// <code> ╟╫╢ </code><br/>
    /// <code> ╙╨╜ </code>
    type Box_DoubleSingle =
        static member doubleSingle = "─║╓╥╖╟╫╢╙╨╜"
        static member TopRight = '╖'
        static member BottomRight = '╜'
        static member BottomLeft = '╙'
        static member TopLeft = '╓'
        static member Top = '╥'
        static member Right = '╢'
        static member Bottom = '╨'
        static member Left = '╟'
        static member Center = '╫'
        
    /// Single / Double Box<br/>
    /// <code> ╒╤╕ </code><br/>
    /// <code> ╞╪╡ </code><br/>
    /// <code> ╘╧╛ </code>
    type Box_SingleDouble =
        static member singelDouble = "═│╒╤╕╞╪╡╘╧╛"
        static member TopRight = '╕'
        
        static member BottomRight = '╛'
        static member BottomLeft = '╘'
        static member TopLeft = '╒'
        static member Top = '╤'
        static member Right = '╡'
        static member Bottom = '╧'
        static member Left = '╞'
        static member Center = '╪'
    
    /// Heavy Box         <br/>
    /// <code> ━ ┃ </code><br/>
    /// <code> ┏┳┓ </code><br/>
    /// <code> ┣╋┫ </code><br/>
    /// <code> ┗┻┛ </code>
    type Box_Heavy =
        static member Horizontal = '━'
        static member Vertical = '┃'
        static member TopLeft = '┏'
        static member TopRight = '┓'
        static member BottomLeft = '┗'
        static member BottomRight = '┛'
        static member Left = '┣'
        static member Right = '┫'
        static member Top = '┳'
        static member Bottom = '┻'
        static member Center = '╋'
        
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
┌─┮━┓┎─┰─┒┏━┭─┐  ╭─╮ ┏╾┐┌─┐┌╼┓┏╾┐
├─┾━┫┠─╂─┨┣━┽─┤  ╰─╯ ┗━┛┗━┛┗━┛┗╾┘
└─┶━┛┖─┸─┚┗━┵─┘ 
*)
        
(*
 ╌ ╎
 ╍ ╏
 ┄ ┆
 ┅ ┇
 ┈ ┊
 ┉ ┋
 ╾               ┭ ┵ ┽ // L
 
 ╼               ┮ ┶ ┾ // R
 
     ┍ ┑ ┕ ┙ ┝ ┥ ┯ ┷ ┿ // H
 
   ╿         ┞ ┦     ╀ // U
 
   ╽         ┟ ┧     ╁ // D
 
     ┎ ┒ ┖ ┚ ┠ ┨ ┰ ┸ ╂ // V
 
               ┩   ┹ ╃ // U+L
             ┡     ┺ ╄ // U+R
               ┪ ┱   ╅ // D+L
             ┢   ┲   ╆ // D+R
                     ╇ // H+U
                     ╈ // H+D
                     ╉ // V+L
                     ╊ // V+R
 ╴ ╵ ╶ ╷
 ╸ ╹ ╺ ╻
 ╭─╮
 ╰─╯
 ╱ ╲
 ╳

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
open ASCIIHelper
open Pastel
open System.Drawing

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

CursorVisible <- false

let mutable n = 0

let rand = Random()

let ss = seq {
    for h in [0..399] do
        rand.Next() % 360
}
let s = ss |> Seq.toArray

while true do
    // SetCursorPosition(0,0)
    Clear()
    for h in s do
        let (r, g, b) = HSL.HSL.toRgb (h-n)
        let c = $"{r:X2}{g:X2}{b:X2}"
        Write("⣿⣿".Pastel(c))

    n <- (n+1)%360

    Threading.Thread.Sleep(1000/60)

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