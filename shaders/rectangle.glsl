#version 300 es

// #pragma glslify: checker = require('glsl-checker')

// fragment shaders don't have a default precision so we need
// to pick one. highp is a good default. It means "high precision"
precision highp float;

//#pragma glslify: import('/shaders/shared.glsl') 

uniform vec2 u_resolution;

uniform vec2 u_position;
uniform vec2 u_size;
uniform vec4 u_color;

// we need to declare an output for the fragment shader
out vec4 outColor;

float sdRoundedBox( in vec2 p, in vec2 b, in vec4 r )
{
	r.xy = (p.x > 0.0) ? r.xy : r.zw;
	r.x  = (p.y > 0.0) ? r.x  : r.y;
	vec2 q = abs(p) - b + r.x;

	return min(max(q.x, q.y), 0.0) + length(max(q, 0.0)) - r.x;
}
float sdBox( in vec2 p, in vec2 b )
{
	vec2 d = abs(p) - b;
	return length(max(d, 0.0)) + min(max(d.x, d.y), 0.0);
}

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

vec4 drawRect() 
{
	vec2 p = pos2clip(gl_FragCoord.xy);

	vec2 pos = pos2clip(u_position);//pix2clip(rect.pos) * vec2(1, -1); // invert y
	vec2 size = size2clip(u_size); //pix2clip(rect.size);

	float d = sdBox(p - pos, size);

	return sdBox(p - pos, size) > 0.0 ? vec4(0) : u_color;
}

void main() {
	// Just set the output to a constant reddish-purple
	outColor = drawRect();
}
