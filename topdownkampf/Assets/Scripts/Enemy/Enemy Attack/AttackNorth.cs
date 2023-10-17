using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackNorth : MonoBehaviour
{
    public GameObject attackNorthScan = default;


    public GameObject attackRangeNorth = default;

    // Start is called before the first frame update
    void Start()
    {
        attackNorthScan = transform.GetChild(4).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            attackRangeNorth.SetActive(true);
        }
    }
}
