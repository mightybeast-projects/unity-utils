using UnityEngine;

[CreateAssetMenu(fileName = "Vector2Variable", menuName = "Utils/Variables/Vector2Variable")]
public class Vector2Variable : Variable
{
    public Vector2 value;

    public override string ToString()
    {
        return value.ToString();
    }
}