using UnityEngine;
using UnityEngine.UI;

public class CoinData : MonoBehaviour
{
    public int currentCoins;
    public SO_Tower cost;
    public Text coinText;

    public void Start()
    {
        UpdateText();
    }

    public void AddCoin()
   {
       currentCoins += 1;
       UpdateText();
   }

   public void SubtractCoin(int amount)
   {
       currentCoins -= amount;
       UpdateText();
   }

   public void UpdateText()
   {
       print(coinText);
       coinText.text = currentCoins.ToString();
   }
    
}
