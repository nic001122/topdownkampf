using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEast : MonoBehaviour
{
    public GameObject attackEastScan = default;

    public GameObject attackRangeEast = default;


    public Health health;

    public bool isInAttackRange = false;

    // Start is called before the first frame update
    void Start()
    {
        attackEastScan = transform.GetChild(7).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(health.enemyIsAttackingNorthWest)
        {
            
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isInAttackRange = true;
            attackRangeEast.SetActive(true);
        }
    }

    void OnTriggerExit2D()
    {
        isInAttackRange = false;
        attackRangeEast.SetActive(false);
    }
}
