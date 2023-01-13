#version 300 es

// #pragma glslify: checker = require('glsl-checker') 

// fragment shaders don't have a default precision so we need
// to pick one. highp is a good default. It means "high precision"
precision highp float;

// we need to declare an output for the fragment shader
out vec4 outColor;

void main() {
  // float gray = mix(0.8, 1.0, checker(gl_FragCoord.xy, 18.0));

  // Just set the output to a constant reddish-purple
  outColor = vec4(1, 0, 0.5, 1);
}