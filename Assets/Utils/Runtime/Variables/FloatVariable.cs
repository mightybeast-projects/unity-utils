using UnityEngine;

[CreateAssetMenu(fileName = "FloatVariable", menuName = "Utils/Variables/FloatVariable")]
public class FloatVariable : Variable
{
    public float value;

    public override string ToString()
    {
        return value.ToString();
    }
}