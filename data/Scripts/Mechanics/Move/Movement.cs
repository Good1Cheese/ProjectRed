using System;
using Unigine;

namespace ProjectRed.Mechanics.Move;

[Serializable]
public struct Movement
{
    [ShowInEditor]
    private float _speed;

    public float Speed => _speed;
    public vec2 Input { get; set; }
}
