using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackNorthEast : MonoBehaviour
{
    public EnemyDetermineChildren enemyDetermineChildren;

    [SerializeField] bool playerIsInRange = false;

    [SerializeField] float timeBtwAttack = 0.25f;
    [SerializeField] float btwAttackTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if
        (
            enemyDetermineChildren.isAttackingNorthWest == false &&
            
            enemyDetermineChildren.isAttackingSouthWest == false &&
            enemyDetermineChildren.isAttackingSouthEast == false &&

            enemyDetermineChildren.isAttackingNorth == false &&
            enemyDetermineChildren.isAttackingSouth == false &&

            enemyDetermineChildren.isAttackingWest == false &&
            enemyDetermineChildren.isAttackingEast == false
        )

        {
            if(playerIsInRange)
            {
                enemyDetermineChildren.attackRangeNorthEast.SetActive(true);
                enemyDetermineChildren.isAttackingNorthEast = true;
            }

            if(enemyDetermineChildren.isAttackingNorthEast)
            {
                btwAttackTimer += Time.deltaTime;
            }

            if(btwAttackTimer >= timeBtwAttack)
            {
                enemyDetermineChildren.attackRangeNorthEast.SetActive(false);
                enemyDetermineChildren.isAttackingNorthEast = false;

                btwAttackTimer = 0f;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            playerIsInRange = true;
        }
    }

    void OnTriggerExit2D()
    {
        playerIsInRange = false;
    }
}
