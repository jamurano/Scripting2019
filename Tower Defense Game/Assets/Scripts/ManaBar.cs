using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    public float maxMana;
    public float pointIncreasedPerSecond;
    public float manaCost;
    public float updatedMana;
    public Text manaUi;

    void Start()
    {
        pointIncreasedPerSecond = 1f;
        updatedMana = 100;
        maxMana = 100;
        manaCost = 25;
    }

    void Update()
    {
        updatedMana += pointIncreasedPerSecond * Time.deltaTime;

        if (updatedMana > maxMana)
        {
            updatedMana = 100;
        }

        if (updatedMana < 0)
        {
            updatedMana = 0;
        }

        manaUi.text = (int) updatedMana + "Mana";
    }

    public void UseMana()
    {
        if (updatedMana >= manaCost)
        {
            updatedMana = updatedMana - manaCost;
        }
    }
}