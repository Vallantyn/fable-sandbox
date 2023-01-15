#version 300 es
/**
 * Shared Vertex Shader
 */

// an attribute is an input (in) to a vertex shader.
// It will receive data from a buffer
in vec2 a_position;

uniform vec2 u_resolution;

const vec2 vertices[4] = vec2[4](
    vec2(-1, -1),
    vec2( 1,  -1),
    vec2(-1,  1),
    vec2( 1,  1)
);

// all shaders have a main function
void main() {
    vec2 zeroToOne = a_position / u_resolution;
    vec2 zeroToTwo = zeroToOne * 2.0;
    vec2 clipSpace = zeroToTwo - 1.0;

    // gl_Position is a special variable a vertex shader
    // is responsible for setting
    gl_Position = vec4(vertices[gl_VertexID], 0, 1);
}