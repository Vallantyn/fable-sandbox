// @ts-ignore 6200

type GLbitfield = number;
type GLboolean = boolean;
type GLclampf = number;
type GLenum = number;
type GLfloat = number;
type GLint = number;
type GLint64 = number;
type GLintptr = number;
type GLsizei = number;
type GLsizeiptr = number;
type GLuint = number;
type GLuint64 = number;

type Float32List = Float32Array | GLfloat[];
type Int32List = Int32Array | GLint[];
type Uint32List = Uint32Array | GLuint[];

/** Part of the WebGL API and represents the information returned by calling the WebGLRenderingContext.getActiveAttrib() and WebGLRenderingContext.getActiveUniform() methods. */
interface WebGLActiveInfo {
    readonly name: string;
    readonly size: GLint;
    readonly type: GLenum;
}

declare var WebGLActiveInfoType: {
    prototype: WebGLActiveInfo;
    new(): WebGLActiveInfo;
};

/** Part of the WebGL API and represents an opaque buffer object storing data such as vertices or colors. */
interface WebGLBuffer {}

declare var WebGLBufferType: {
    prototype: WebGLBuffer;
    new(): WebGLBuffer;
};

/** The WebContextEvent interface is part of the WebGL API and is an interface for an event that is generated in response to a status change to the WebGL rendering context. */
interface WebGLContextEvent extends Event {
    readonly statusMessage: string;
}

declare var WebGLContextEventType: {
    prototype: WebGLContextEvent;
    new(type: string, eventInit?: WebGLContextEventInit): WebGLContextEvent;
};

/** Part of the WebGL API and represents a collection of buffers that serve as a rendering destination. */
interface WebGLFramebuffer {}

declare var WebGLFramebufferType: {
    prototype: WebGLFramebuffer;
    new(): WebGLFramebuffer;
};

/** The WebGLProgram is part of the WebGL API and is a combination of two compiled WebGLShaders consisting of a vertex shader and a fragment shader (both written in GLSL). */
interface WebGLProgram {}

declare var WebGLProgramType: {
    prototype: WebGLProgram;
    new(): WebGLProgram;
};

interface WebGLQuery {}

declare var WebGLQueryType: {
    prototype: WebGLQuery;
    new(): WebGLQuery;
};

/** Part of the WebGL API and represents a buffer that can contain an image, or can be source or target of an rendering operation. */
interface WebGLRenderbuffer {}

declare var WebGLRenderbufferType: {
    prototype: WebGLRenderbuffer;
    new(): WebGLRenderbuffer;
};

interface WebGLSampler {}

declare var WebGLSamplerType: {
    prototype: WebGLSampler;
    new(): WebGLSampler;
};

/** The WebGLShader is part of the WebGL API and can either be a vertex or a fragment shader. A WebGLProgram requires both types of shaders. */
interface WebGLShader {}

declare var WebGLShaderType: {
    prototype: WebGLShader;
    new(): WebGLShader;
};

/** Part of the WebGL API and represents the information returned by calling the WebGLRenderingContext.getShaderPrecisionFormat() method. */
interface WebGLShaderPrecisionFormat {
    readonly precision: GLint;
    readonly rangeMax: GLint;
    readonly rangeMin: GLint;
}

declare var WebGLShaderPrecisionFormatType: {
    prototype: WebGLShaderPrecisionFormat;
    new(): WebGLShaderPrecisionFormat;
};

interface WebGLSync {}

declare var WebGLSyncType: {
    prototype: WebGLSync;
    new(): WebGLSync;
};

/** Part of the WebGL API and represents an opaque texture object providing storage and state for texturing operations. */
interface WebGLTexture {}

declare var WebGLTextureType: {
    prototype: WebGLTexture;
    new(): WebGLTexture;
};

interface WebGLTransformFeedback {}

declare var WebGLTransformFeedbackType: {
    prototype: WebGLTransformFeedback;
    new(): WebGLTransformFeedback;
};

/** Part of the WebGL API and represents the location of a uniform variable in a shader program. */
interface WebGLUniformLocation {}

declare var WebGLUniformLocationType: {
    prototype: WebGLUniformLocation;
    new(): WebGLUniformLocation;
};

interface WebGLVertexArrayObject {}

declare var WebGLVertexArrayObjectType: {
    prototype: WebGLVertexArrayObject;
    new(): WebGLVertexArrayObject;
};
