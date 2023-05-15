using UnityEngine;

[CreateAssetMenu(menuName = "Utils/Events/VoidEvent")]
public class VoidEvent : BaseGameEvent<Void>
{
    public void Raise() => Raise(new Void());
}