using UnityEngine;

[CreateAssetMenu(fileName = "BoolVariable", menuName = "Utils/Variables/BoolVariable")]
public class BoolVariable : Variable
{
    public bool value;

    public override string ToString()
    {
        return value.ToString();
    }
}