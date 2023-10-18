using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetermineChildren : MonoBehaviour
{

    public GameObject attackRangeNorthWest;
    public GameObject attackScanNorthWest;

    public GameObject attackRangeNorthEast;
    public GameObject attackScanNorthEast;

    public GameObject attackRangeNorth;
    public GameObject attackScanNorth;

    public GameObject attackRangeSouthWest;
    public GameObject attackScanSouthWest;

    public GameObject attackRangeSouthEast;
    public GameObject attackScanSouthEast;

    public GameObject attackRangeSouth;
    public GameObject attackScanSouth;

    public GameObject attackRangeWest;
    public GameObject attackScanWest;

    public GameObject attackRangeEast;
    public GameObject attackScanEast;


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
