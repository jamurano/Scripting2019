using UnityEngine;

[CreateAssetMenu]
public class PlayerHealth : ScriptableObject, IRun
{
    public void Run()
    {
        Debugger.Long(message: "PlayerHealth");
    }
}
