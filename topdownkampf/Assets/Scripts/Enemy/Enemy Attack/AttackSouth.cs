using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSouth : MonoBehaviour
{
    public GameObject attackSouthScan = default;


    public GameObject attackRangeSouth = default;

    // Start is called before the first frame update
    void Start()
    {
        attackSouthScan = transform.GetChild(5).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            attackRangeSouth.SetActive(true);
        }
    }
}
