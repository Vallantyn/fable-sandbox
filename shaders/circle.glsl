#version 300 es

precision highp float;

#pragma glslify: import('./shared.glsl') 

uniform vec2 u_position;
uniform float u_radius;
uniform vec4 u_color;

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
