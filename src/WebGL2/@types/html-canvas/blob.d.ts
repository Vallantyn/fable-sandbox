/** A file-like object of immutable, raw data. Blobs represent data that isn't necessarily in a JavaScript-native format. The File interface is based on Blob, inheriting blob functionality and expanding it to support files on the user's system. */
interface Blob {
    readonly size: number;
    readonly type: string;
    arrayBuffer(): Promise<ArrayBuffer>;
    slice(start?: number, end?: number, contentType?: string): Blob;
    stream(): ReadableStream<Uint8Array>;
    text(): Promise<string>;
}

// @ts-ignore 6200
type EndingType = "native" | "transparent";

interface BlobPropertyBag {
    endings?: EndingType;
    type?: string;
}

// @ts-ignore 6200
type BufferSource = ArrayBufferView | ArrayBuffer;

// @ts-ignore 6200
type BlobPart = BufferSource | Blob | string;

declare var BlobType: {
    prototype: Blob;
    new(blobParts?: BlobPart[], options?: BlobPropertyBag): Blob;
};

interface BlobCallback {
    (blob: Blob | null): void;
}
