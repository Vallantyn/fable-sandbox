#version 300 es

precision highp float;

#pragma glslify: import('./shared.glsl') 

uniform vec2 u_position;
uniform vec2 u_size;
uniform vec4 u_color;

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
