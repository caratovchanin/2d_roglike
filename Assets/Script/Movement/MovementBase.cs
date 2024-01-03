using UnityEngine;

public abstract class MovementBase
{
    public delegate void Moving(Vector2 pos);
    public delegate void Rotate(Quaternion angle);
}
