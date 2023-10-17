using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AttackNorthWest : MonoBehaviour
{
    public GameObject attackNorthWestScan = default;


    public GameObject attackRangeNorthWest = default;

    // Start is called before the first frame update
    void Start()
    {
        attackNorthWestScan = transform.GetChild(0).gameObject;

        attackRangeNorthWest = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            attackRangeNorthWest.SetActive(true);
        }
    }
}
