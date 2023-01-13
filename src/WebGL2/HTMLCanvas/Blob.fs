// ts2fable 0.7.1
namespace HTML.Types

open System
open Fable.Core
open Fable.Core.JS
// let [<Import("BlobType","html-canvas/blob")>] BlobType: BlobType = jsNative

/// A file-like object of immutable, raw data.  
/// Blobs represent data that isn't necessarily in a JavaScript-native format.  
/// The File interface is based on Blob, inheriting blob functionality and expanding it to support files on the user's system.
type [<AllowNullLiteral>] Blob =
    abstract size: float
    abstract ``type``: string
    abstract arrayBuffer: unit -> Promise<ArrayBuffer>
    abstract slice: ?start: float * ?``end``: float * ?contentType: string -> Blob
    // abstract stream: unit -> ReadableStream<Uint8Array> TODO: ReadableStream
    abstract text: unit -> Promise<string>

type [<StringEnum; RequireQualifiedAccess>] EndingType =
    /// Line ending characters are changed to match host OS filesystem convention
    | [<CompiledName("native")>]        Native
    /// Endings are stored in the blob without change
    | [<CompiledName("transparent")>]   Transparent

type [<AllowNullLiteral>] BlobPropertyBag =
    abstract endings: EndingType option with get, set
    abstract ``type``: string option with get, set

type BufferSource =
    U2<ArrayBufferView, ArrayBuffer>

type BlobPart =
    U3<BufferSource, Blob, string>

type [<AllowNullLiteral>] BlobCallback =
    [<Emit "$0($1...)">] abstract Invoke: blob: Blob option -> unit

type [<AllowNullLiteral>] BlobType =
    abstract prototype: Blob with get, set
    [<Emit "new $0($1...)">] abstract Create: ?blobParts: ResizeArray<BlobPart> * ?options: BlobPropertyBag -> obj

namespace HTML

open Fable.Core
open HTML.Types

[<AutoOpen>]
module Blob =
    let [<Global>] Blob: BlobType = jsNative