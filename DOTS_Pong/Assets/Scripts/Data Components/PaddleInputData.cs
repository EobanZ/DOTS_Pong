using Unity.Entities;
using UnityEngine;

[GenerateAuthoringComponent]
public struct PaddleInputdata : IComponentData
{
    public KeyCode upKey;
    public KeyCode downKey;
}
