
using UnityEngine;
using Unity.Entities;

[GenerateAuthoringComponent]
struct PaddleMovementData : IComponentData
{
    public int direction;
    public float speed;
}
