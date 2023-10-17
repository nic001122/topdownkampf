using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSouthEast : MonoBehaviour
{
    public GameObject attackSouthEastScan = default;


    public GameObject attackRangeSouthEast = default;

    // Start is called before the first frame update
    void Start()
    {
        attackSouthEastScan = transform.GetChild(3).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            attackRangeSouthEast.SetActive(true);
        }
    }
}
