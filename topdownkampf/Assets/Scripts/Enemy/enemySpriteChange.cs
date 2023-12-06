using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class enemySpriteChange : MonoBehaviour
{
    Vector2 currentPos;
    Vector2 lastPos;

    public SpriteRenderer sr;

    public Sprite lookingNorth;
    public Sprite lookingSouth;
    public Sprite lookingWest;
    public Sprite lookingEast;
    public Sprite lookingNorthWest;
    public Sprite lookingNorthEast;
    public Sprite lookingSouthWest;
    public Sprite lookingSouthEast;
    

    // Start is called before the first frame update
    void Start()
    {
        lastPos = currentPos;
        sr.sprite = lookingSouth;
    }

    // Update is called once per frame
    void Update()
    {
        currentPos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        CheckDirection();
        lastPos = currentPos;
    }

    void CheckDirection()
    {
        if(currentPos.x > lastPos.x && currentPos.y == lastPos.y)
        {
            sr.sprite = lookingWest;
        }

        if(currentPos.x < lastPos.x && currentPos.y == lastPos.y)
        {
            sr.sprite = lookingEast;
        }

        if(currentPos.x > lastPos.x && currentPos.y > lastPos.y)
        {
            sr.sprite = lookingNorthWest;
        }

        if(currentPos.x > lastPos.x && currentPos.y < lastPos.y)
        {
            sr.sprite = lookingSouthWest;
        }

        if(currentPos.x < lastPos.x && currentPos.y > lastPos.y)
        {
            sr.sprite = lookingNorthEast;
        }

        if(currentPos.x < lastPos.x && currentPos.y < lastPos.y)
        {
            sr.sprite = lookingSouthEast;
        }

        if(currentPos.x == lastPos.x && currentPos.y > lastPos.y)
        {
            sr.sprite = lookingNorth;
        }

        if(currentPos.x == lastPos.x && currentPos.y < lastPos.y)
        {
            sr.sprite = lookingSouth;
        }

        if(currentPos == lastPos)
        {

        }
    }
}
