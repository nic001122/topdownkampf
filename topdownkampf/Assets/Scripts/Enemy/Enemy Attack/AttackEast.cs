using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEast : MonoBehaviour
{
    public EnemyDetermineChildren enemyDetermineChildren;

    [SerializeField] bool playerIsInRange = false;

    [SerializeField] float timeBtwAttack = 1f;
    [SerializeField] float btwAttackTimer = 0f;
    [SerializeField] float timeBeforeFirstAttack = 0f;


    public NewEnemy newEnemy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(newEnemy.playerLantern.intensity > 0)
        {
            return;
        }

        if
        (
            enemyDetermineChildren.isAttackingNorthWest == false &&
            enemyDetermineChildren.isAttackingNorthEast == false &&
            
            enemyDetermineChildren.isAttackingSouthWest == false &&
            enemyDetermineChildren.isAttackingSouthEast == false &&

            enemyDetermineChildren.isAttackingNorth == false &&
            enemyDetermineChildren.isAttackingSouth == false &&

            enemyDetermineChildren.isAttackingWest == false &&


            timeBeforeFirstAttack >= 0f
        )
        
        {
            if(playerIsInRange)
            {
                timeBeforeFirstAttack += Time.deltaTime;
                if(timeBeforeFirstAttack >= 1)
                {
                    enemyDetermineChildren.attackRangeEast.SetActive(true);
                    enemyDetermineChildren.isAttackingEast = true;

                    if(btwAttackTimer >= timeBtwAttack)
                    {
                        enemyDetermineChildren.attackRangeEast.SetActive(false);
                    }
                }
            }

            if(enemyDetermineChildren.isAttackingEast)
            {
                btwAttackTimer += Time.deltaTime;
            }

            if(btwAttackTimer >= timeBtwAttack)
            {
                enemyDetermineChildren.attackRangeEast.SetActive(false);
                enemyDetermineChildren.isAttackingEast = false;

                btwAttackTimer = 0f;
            }

            if(btwAttackTimer > 0)
            {
                btwAttackTimer = 0f;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(newEnemy.playerLantern.intensity > 0)
        {
            return;
        }

        if(collision.CompareTag("Player"))
        {
            playerIsInRange = true;
        }
    }

    void OnTriggerExit2D()
    {
        playerIsInRange = false;

        btwAttackTimer = 0f;

        timeBeforeFirstAttack = 1f;
    }
}
