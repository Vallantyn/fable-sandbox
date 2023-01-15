#version 300 es

// #pragma glslify: checker = require('glsl-checker') 

// fragment shaders don't have a default precision so we need
// to pick one. highp is a good default. It means "high precision"
precision highp float;

uniform vec2 u_resolution;

// we need to declare an output for the fragment shader
out vec4 outColor;

float sdCircle ( vec2 p, float r ) { return length(p) - r; }
//float sdRoundedBox( in vec2 p, in vec2 b, in vec4 r )
//{
//	r.xy = (p.x > 0.0) ? r.xy : r.zw;
//	r.x  = (p.y > 0.0) ? r.x  : r.y;
//	vec2 q = abs(p) - b + r.x;
//
//	return min(max(q.x, q.y), 0.0) + length(max(q, 0.0)) - r.x;
//}
//float sdBox( in vec2 p, in vec2 b )
//{
//	vec2 d = abs(p) - b;
//	return length(max(d, 0.0)) + min(max(d.x, d.y), 0.0);
//}

vec2 pix2clip(vec2 p)
{
	return ((2.0 * p - u_resolution) / u_resolution.y);
}

void main() {
	vec2 c = gl_FragCoord.xy;
	// normalize fragCoord
	vec2 p0 = pix2clip(c);
	vec2 p1 = pix2clip(vec2(10, 10)) * vec2(1, -1);
	vec2 p = p0 - p1;

	// float gray = mix(0.8, 1.0, checker(gl_FragCoord.xy, 18.0));
	//	vec2 p = vec2(0.5, 0.5);
	float r = sdCircle(p, 0.5);

	// Just set the output to a constant reddish-purple
	outColor = vec4(1, 0, r > 0.0 ? 1.0 : 0.5, 1);
}
