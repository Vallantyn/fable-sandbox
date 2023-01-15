namespace Systems.Renderer

[<AutoOpen>]
module Buffer =
    type EBufferParameter =
    | Size  = 0x8764u
    | Usage = 0x8765u

    type EBufferTarget =
    | Array               = 0x8892u
    | ElementArray        = 0x8893u
    | CopyRead            = 0x8F36u
    | CopyWrite           = 0x8F37u
    | TransformFeedback   = 0x8C8Eu
    | Uniform             = 0x8A11u
    | PixelPack           = 0x88EBu
    | PixelUnpack         = 0x88ECu

    type EBufferUsage =
    | StaticDraw    = 0x88E4u
    | DynamicDraw   = 0x88E0u
    | StreamDraw    = 0x88E8u
    | StaticRead    = 0x88E5u
    | DynamicRead   = 0x88E9u
    | StreamRead    = 0x88E1u
    | StaticCopy    = 0x88E6u
    | DynamicCopy   = 0x88EAu
    | StreamCopy    = 0x88E2u

    type TBufferSourceData = // Choice<int array, uint array, single array, float array>
    | IntBuffer     of int array
    | UIntBuffer    of uint array
    | SingleBuffer  of single array
    | FloatBuffer   of float array

    type TBufferParameterValue = //Choice<int, EBufferUsage>
    | Size  of int
    | Usage of EBufferUsage

    type IBuffer =
        inherit IOptionWrapper

        abstract Delete: unit -> unit

        abstract bIsBuffer: bool with get
        abstract Bind: target:EBufferTarget -> unit
        abstract GetParameter: target:EBufferTarget * parameter:EBufferParameter -> TBufferParameterValue 
        abstract Data: target:EBufferTarget * usage:EBufferUsage -> unit
        abstract Data: target:EBufferTarget * usage:EBufferUsage * sourceOffset:uint -> unit
        abstract Data: target:EBufferTarget * size:int * usage:EBufferUsage -> unit
        abstract Data: target:EBufferTarget * sourceData:TBufferSourceData * usage:EBufferUsage -> unit
        abstract Data: target:EBufferTarget * sourceData:TBufferSourceData * usage:EBufferUsage * sourceOffset:uint -> unit
        abstract Data: target:EBufferTarget * sourceData:TBufferSourceData * usage:EBufferUsage * sourceOffset:uint * length:uint -> unit
        abstract SubData: target:EBufferTarget * sourceOffset:uint -> unit
        abstract SubData: target:EBufferTarget * sourceOffset:uint * sourceData:TBufferSourceData -> unit
        abstract SubData: target:EBufferTarget * byteOffset:uint * sourceOffset:uint -> unit
        abstract SubData: target:EBufferTarget * byteOffset:uint * sourceData:TBufferSourceData * sourceOffset:uint -> unit
        abstract SubData: target:EBufferTarget * byteOffset:uint * sourceData:TBufferSourceData * sourceOffset:uint * length:uint -> unit

    let inline BindBuffer target (b:IBuffer) = b.Bind target; b
    let inline BufferData (target:EBufferTarget) (usage:EBufferUsage) (b:IBuffer) = b.Data (target, usage); b
    let inline BufferDataWithSourceOffset (target:EBufferTarget) (usage:EBufferUsage) (sourceOffset:uint) (b:IBuffer) = b.Data (target, usage, sourceOffset); b
    let inline BufferDataWithSize (target:EBufferTarget) (size:int) (usage:EBufferUsage) (b:IBuffer) = b.Data (target, size, usage); b
    let inline BufferDataWithSourceData (target:EBufferTarget) (sourceData:TBufferSourceData) (usage:EBufferUsage) (b:IBuffer) = b.Data (target, sourceData, usage); b
    let inline BufferDataWithSourceDataAndOffset (target:EBufferTarget) (sourceData:TBufferSourceData) (usage:EBufferUsage) (sourceOffset:uint) (b:IBuffer) = b.Data (target, sourceData, usage, sourceOffset); b
    let inline BufferDataWithSourceDataOffsetAndLength (target:EBufferTarget) (sourceData:TBufferSourceData) (usage:EBufferUsage) (sourceOffset:uint) (length:uint) (b:IBuffer) = b.Data (target, sourceData, usage, sourceOffset, length); b
    let inline BufferSubData (target:EBufferTarget) (sourceOffset:uint) (b:IBuffer) = b.SubData (target, sourceOffset); b
    let inline BufferSubDataWithSourceData (target:EBufferTarget) (sourceOffset:uint) (sourceData:TBufferSourceData) (b:IBuffer) = b.SubData (target, sourceOffset, sourceData); b
    let inline BufferSubDataWithOffset (target:EBufferTarget) (byteOffset:uint) (sourceOffset:uint) (b:IBuffer) = b.SubData (target, byteOffset, sourceOffset); b
    let inline BufferSubDataWithOffsetAndSourceData (target:EBufferTarget) (byteOffset:uint) (sourceData:TBufferSourceData) (sourceOffset:uint) (b:IBuffer) = b.SubData (target, byteOffset, sourceData, sourceOffset); b
    let inline BufferSubDataWithOffsetSourceDataAndLength (target:EBufferTarget) (byteOffset:uint) (sourceData:TBufferSourceData) (sourceOffset:uint) (length:uint) (b:IBuffer) = b.SubData (target, byteOffset, sourceData, sourceOffset, length); b