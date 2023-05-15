using UnityEngine;

[CreateAssetMenu(fileName = "StringVariable", menuName = "Utils/Variables/StringVariable")]
public class StringVariable : Variable
{
    public string value;

    public override string ToString()
    {
        return value.ToString();
    }
}