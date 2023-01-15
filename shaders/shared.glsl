uniform vec2 u_resolution;

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