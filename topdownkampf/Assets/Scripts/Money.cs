using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour 
{
    public int moneyCount;
    public TMP_Text moneyText;
    public int randomNumber;
    public int updatedMoney;

    private void Start()
    {
        
        int randomNumber = Random.Range(9, 19);
        Debug.Log(randomNumber);
    }
    private void Update()
    {
        string moneyString = moneyCount.ToString();
        updatedMoney = moneyCount + randomNumber;
        Debug.Log(updatedMoney);

        moneyText.text = moneyString;
    }
    public void addMoney()
    {
        moneyCount = moneyCount + randomNumber;
    }
}
