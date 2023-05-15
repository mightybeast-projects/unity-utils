using UnityEngine;

[CreateAssetMenu(fileName = "Vector3Variable", menuName = "Utils/Variables/Vector3Variable")]
public class Vector3Variable : Variable
{
    public Vector3 value;

    public override string ToString()
    {
        return value.ToString();
    }
}