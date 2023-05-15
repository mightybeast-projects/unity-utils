using UnityEngine;

[CreateAssetMenu(fileName = "IntVariable", menuName = "Utils/Variables/IntVariable")]
public class IntVariable : Variable
{
    public int value;

    public override string ToString()
    {
        return value.ToString();
    }
}