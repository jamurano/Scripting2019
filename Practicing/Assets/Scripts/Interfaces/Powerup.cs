using UnityEngine;

[CreateAssetMenu
]
public class Powerup : ScriptableObject, IRun, ITest
{
    public void Run()
    {
        Debug.Log(message: "PowerUp!");
    }

    public void Run(float f)
    {

    }

    public void Test()
    {
        Debugger.Log(message: "PowerUp Test");
    }
}
