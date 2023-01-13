interface HTMLElementEventMap
    extends ElementEventMap,
            DocumentAndElementEventHandlersEventMap,
            GlobalEventHandlersEventMap
{}

/** 
 * Provides properties and methods for manipulating the layout and presentation of `<canvas>` elements.  
 * The HTMLCanvasElement interface also inherits the properties and methods of the HTMLElement interface.
 */
interface HTMLCanvasElement
    extends HTMLElement 
{
    /** Gets or sets the height of a canvas element on a document. */
    height: number;
    /** Gets or sets the width of a canvas element on a document. */
    width: number;
    captureStream(frameRequestRate?: number): MediaStream;
    /**
     * Returns an object that provides methods and properties for drawing and manipulating images and graphics on a canvas element in a document.  
     * A context object includes information about colors, line widths, fonts, and other graphic parameters that can be drawn on a canvas.
     *
     * @param contextId The identifier (ID) of the type of canvas to create.  
     *                  Internet Explorer 9 and Internet Explorer 10 support only a 2-D context using `canvas.getContext("2d");`  
     *                  IE11 Preview also supports 3-D or WebGL context using `canvas.getContext("experimental-webgl");`
     * @param options Options
     * @returns The `RenderingContext`
     */
    getContext(contextId: "2d", options?: CanvasRenderingContext2DSettings): CanvasRenderingContext2D | null;
    /**
     * Returns an object that provides methods and properties for drawing and manipulating images and graphics on a canvas element in a document.  
     * A context object includes information about colors, line widths, fonts, and other graphic parameters that can be drawn on a canvas.
     *
     * @param contextId The identifier (ID) of the type of canvas to create.  
     *                  Internet Explorer 9 and Internet Explorer 10 support only a 2-D context using `canvas.getContext("2d");`  
     *                  IE11 Preview also supports 3-D or WebGL context using `canvas.getContext("experimental-webgl");`
     * @param options Options
     * @returns The `RenderingContext`
     */
    getContext(contextId: "bitmaprenderer", options?: ImageBitmapRenderingContextSettings): ImageBitmapRenderingContext | null;
    /**
     * Returns an object that provides methods and properties for drawing and manipulating images and graphics on a canvas element in a document.  
     * A context object includes information about colors, line widths, fonts, and other graphic parameters that can be drawn on a canvas.
     *
     * @param contextId The identifier (ID) of the type of canvas to create.  
     *                  Internet Explorer 9 and Internet Explorer 10 support only a 2-D context using `canvas.getContext("2d");`  
     *                  IE11 Preview also supports 3-D or WebGL context using `canvas.getContext("experimental-webgl");`
     * @param options Options
     * @returns The `RenderingContext`
     */
    getContext(contextId: "webgl", options?: WebGLContextAttributes): WebGLRenderingContext | null;
    /**
     * Returns an object that provides methods and properties for drawing and manipulating images and graphics on a canvas element in a document.  
     * A context object includes information about colors, line widths, fonts, and other graphic parameters that can be drawn on a canvas.
     *
     * @param contextId The identifier (ID) of the type of canvas to create.  
     *                  Internet Explorer 9 and Internet Explorer 10 support only a 2-D context using `canvas.getContext("2d");`  
     *                  IE11 Preview also supports 3-D or WebGL context using `canvas.getContext("experimental-webgl");`
     * @param options Options
     * @returns The `RenderingContext`
     */
    getContext(contextId: "webgl2", options?: WebGLContextAttributes): WebGL2RenderingContext | null;
    /**
     * Returns an object that provides methods and properties for drawing and manipulating images and graphics on a canvas element in a document.  
     * A context object includes information about colors, line widths, fonts, and other graphic parameters that can be drawn on a canvas.
     *
     * @param contextId The identifier (ID) of the type of canvas to create.  
     *                  Internet Explorer 9 and Internet Explorer 10 support only a 2-D context using `canvas.getContext("2d");`  
     *                  IE11 Preview also supports 3-D or WebGL context using `canvas.getContext("experimental-webgl");`
     * @param options Options
     * @returns The `RenderingContext`
     */
    getContext(contextId: string, options?: any): RenderingContext | null;
    toBlob(callback: BlobCallback, type?: string, quality?: any): void;
    /**
     * Returns the content of the current canvas as an image that you can use as a source for another canvas or an HTML element.
     * @param type The standard MIME type for the image format to return. If you do not specify this parameter, the default value is a PNG format image.
     */
    toDataURL(type?: string, quality?: any): string;
    transferControlToOffscreen(): OffscreenCanvas;
    addEventListener<K extends keyof HTMLElementEventMap>(type: K, listener: (this: HTMLCanvasElement, ev: HTMLElementEventMap[K]) => any, options?: boolean | AddEventListenerOptions): void;
    addEventListener(type: string, listener: EventListenerOrEventListenerObject, options?: boolean | AddEventListenerOptions): void;
    removeEventListener<K extends keyof HTMLElementEventMap>(type: K, listener: (this: HTMLCanvasElement, ev: HTMLElementEventMap[K]) => any, options?: boolean | EventListenerOptions): void;
    removeEventListener(type: string, listener: EventListenerOrEventListenerObject, options?: boolean | EventListenerOptions): void;
}

declare var HTMLCanvasElementType: {
    prototype: HTMLCanvasElement;
    new(): HTMLCanvasElement;
};