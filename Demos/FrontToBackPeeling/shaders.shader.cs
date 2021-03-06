﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpGL;

namespace FrontToBackPeeling
{
    public static partial class Shaders
    {
        public const string shaderVert = @"#version 330 core
  
layout(location = 0) in vec3 vVertex; //object space vertex position

//uniform
uniform mat4 MVP;  //combined modelview projection matrix

void main()
{  
	//get the clipspace vertex position
	gl_Position = MVP*vec4(vVertex.xyz,1);
}
";
        public const string shaderFrag = @"#version 330 core

layout(location = 0) out vec4 vFragColor;	//fragment shader output

void main()
{
	//return the constant white colour as shader output
	vFragColor = vec4(1,1,1,1);
}
";
    }
}
