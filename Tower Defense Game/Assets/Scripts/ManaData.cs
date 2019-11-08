using System;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class ManaData : MonoBehaviour
{
    public ObjectDefinition definition;
    public SO_Tower int cost;
    
    public int maxMana = 100;
    public int currentMana = 100;
    
    public Image manaBar;


    private void Start()
    {
        maxMana = definition.maxMana;
        currentMana = maxMana;
    }

    void UseMana()
    {
        currentMana = currentMana - cost;
        manaBar.fillAmount = (float) currentMana / (float) maxMana;
    }
    
}
