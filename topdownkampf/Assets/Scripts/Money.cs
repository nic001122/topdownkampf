using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour 
{
    public int moneyCount;
    public TMP_Text moneyText;
    public int randomNumber;

    private void Start()
    {
        moneyCount = 0;
        int randomNumber = Random.Range(9, 19);
    }
    private void Update()
    {
        string moneyString = moneyCount.ToString();

        moneyText.text = (moneyString);
    }
    public void addMoney()
    {
        moneyCount = moneyCount + randomNumber;
    }
}
