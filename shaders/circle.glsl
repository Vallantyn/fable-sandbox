#version 300 es

// #pragma glslify: checker = require('glsl-checker') 

// fragment shaders don't have a default precision so we need
// to pick one. highp is a good default. It means "high precision"
precision highp float;

uniform vec2 u_resolution;

uniform vec2 u_position;
uniform float u_radius;
uniform vec4 u_color;

// we need to declare an output for the fragment shader
out vec4 outColor;

vec2 pos2clip(vec2 p)
{
	return (2. * p - u_resolution) / min(u_resolution.x, u_resolution.y);
}

vec2 size2clip(vec2 s)
{
	return s / min(u_resolution.x, u_resolution.y);
}

float val2clip(float v)
{
	return v / min(u_resolution.x, u_resolution.y);
}

float sdCircle ( vec2 p, float r )
{
	return length(p) - r;
}

vec4 drawCircle() 
{
	vec2 p = pos2clip(gl_FragCoord.xy);

	vec2 pos = pos2clip(u_position); // invert y
	float r = val2clip(u_radius);

	return sdCircle(p - pos, r) > 0.0 ? vec4(0) : u_color;
}

void main() {
	// Just set the output to a constant reddish-purple
	outColor = drawCircle();
}
