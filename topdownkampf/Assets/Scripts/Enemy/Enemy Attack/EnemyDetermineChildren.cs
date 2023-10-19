using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetermineChildren : MonoBehaviour
{
    public GameObject attackRangeNorthWest;
    public GameObject attackScanNorthWest;
    public bool isAttackingNorthWest = false;

    public GameObject attackRangeNorthEast;
    public GameObject attackScanNorthEast;
    public bool isAttackingNorthEast = false;

    public GameObject attackRangeNorth;
    public GameObject attackScanNorth;
    public bool isAttackingNorth = false;

    public GameObject attackRangeSouthWest;
    public GameObject attackScanSouthWest;
    public bool isAttackingSouthWest = false;

    public GameObject attackRangeSouthEast;
    public GameObject attackScanSouthEast;
    public bool isAttackingSouthEast = false;

    public GameObject attackRangeSouth;
    public GameObject attackScanSouth;
    public bool isAttackingSouth = false;

    public GameObject attackRangeWest;
    public GameObject attackScanWest;
    public bool isAttackingWest = false;

    public GameObject attackRangeEast;
    public GameObject attackScanEast;
    public bool isAttackingEast = false;


    public GameObject attackRangeEmpty;
    public GameObject attackScanEmpty;

    // Start is called before the first frame update
    void Start()
    {
        attackScanEmpty = transform.GetChild(1).gameObject;
        attackRangeEmpty = transform.GetChild(0).gameObject;

        attackRangeNorthWest = attackRangeEmpty.transform.GetChild(0).gameObject;
        attackScanNorthWest = attackScanEmpty.transform.GetChild(0).gameObject;

        attackRangeNorthEast = attackRangeEmpty.transform.GetChild(1).gameObject;
        attackScanNorthEast = attackScanEmpty.transform.GetChild(1).gameObject;

        attackRangeSouthWest = attackRangeEmpty.transform.GetChild(2).gameObject;
        attackScanSouthWest = attackScanEmpty.transform.GetChild(2).gameObject;

        attackRangeSouthEast = attackRangeEmpty.transform.GetChild(3).gameObject;
        attackScanSouthEast = attackScanEmpty.transform.GetChild(3).gameObject;

        attackRangeNorth = attackRangeEmpty.transform.GetChild(4).gameObject;
        attackScanNorth = attackScanEmpty.transform.GetChild(4).gameObject;

        attackRangeSouth = attackRangeEmpty.transform.GetChild(5).gameObject;
        attackScanSouth = attackScanEmpty.transform.GetChild(5).gameObject;

        attackRangeWest = attackRangeEmpty.transform.GetChild(6).gameObject;
        attackScanWest = attackScanEmpty.transform.GetChild(6).gameObject;
        
        attackRangeEast = attackRangeEmpty.transform.GetChild(7).gameObject;
        attackScanEast = attackScanEmpty.transform.GetChild(7).gameObject;
    }
}
