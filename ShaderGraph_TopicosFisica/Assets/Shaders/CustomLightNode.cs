using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.ShaderGraph;
using System.Reflection;


public class CustomLightNode:CodeFunctionNode
{
    public override bool hasPreview { get => false;  }


    protected override MethodInfo GetFunctionToConvert()
    {

    }
}
