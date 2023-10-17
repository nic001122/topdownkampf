using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackNorthEast : MonoBehaviour
{
    public GameObject attackNorthEastScan = default;


    public GameObject attackRangeNorthEast = default;

    // Start is called before the first frame update
    void Start()
    {
        attackNorthEastScan = transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            attackRangeNorthEast.SetActive(true);
        }
    }
}
