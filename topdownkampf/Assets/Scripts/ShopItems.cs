using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItems : MonoBehaviour
{

    public Money moneyScript;
    public int price50 = 50;
    public int price250 = 250;
    public int price500 = 500;
    public GameObject tooExpensiveText;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void fiftyPriceButton()
    {
        if (moneyScript.moneyCount >= price50)
        {
            moneyScript.moneyCount -= price50;
            string moneyString = moneyScript.moneyCount.ToString();
            moneyScript.moneyText.text = moneyString;
        }
        else
        {
            tooExpensiveText.SetActive(true);
        }
    }
    public void twohundredfiftyPriceButton()
    {
        if (moneyScript.moneyCount >= price250)
        {
            moneyScript.moneyCount -= price250;
            string moneyString = moneyScript.moneyCount.ToString();
            moneyScript.moneyText.text = moneyString;
        }
        else
        {
            tooExpensiveText.SetActive(true);
        }
    }
    public void fivehundredPriceButton()
    {
        if (moneyScript.moneyCount >= price500)
        {
            moneyScript.moneyCount -= price500;
            string moneyString = moneyScript.moneyCount.ToString();
            moneyScript.moneyText.text = moneyString;
        }
        else
        {
            tooExpensiveText.SetActive(true);
        }
    }
}
