using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour 
{
    public int moneyCount;
    public TMP_Text moneyText;
    public int updatedMoney;
    
    private void Start()
    {

    }
    private void Update()
    {
       
    }
    public void addMoney()
    {
        int randomNumber = Random.Range(9, 19);
        moneyCount = moneyCount + randomNumber;
        string moneyString = moneyCount.ToString();
        moneyText.text = moneyString;
    }
}
