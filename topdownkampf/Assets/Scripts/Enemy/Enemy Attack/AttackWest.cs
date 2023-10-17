using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackWest : MonoBehaviour
{
    public GameObject attackWestScan = default;


    public GameObject attackRangeWest = default;

    // Start is called before the first frame update
    void Start()
    {
        attackWestScan = transform.GetChild(6).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            attackRangeWest.SetActive(true);
        }
    }
}
