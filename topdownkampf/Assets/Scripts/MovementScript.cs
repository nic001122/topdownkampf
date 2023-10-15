using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public float forceNum = 3;

    public float horizontalMoveDirection;
    public float verticalMoveDirection;

    public bool lookingVertical;
    public bool lookingHorizontal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(steerAmount, moveAmount, 0);

        if(steerAmount > 0)
        {
            lookingVertical = false;
            lookingHorizontal = true;

            verticalMoveDirection = -1;
            horizontalMoveDirection = 1;
            gameObject.transform.localScale = new Vector3(horizontalMoveDirection, verticalMoveDirection, 1);
        }

        else if (steerAmount < 0)
        {
            lookingVertical = false;
            lookingHorizontal = true;

            verticalMoveDirection = 1;
            horizontalMoveDirection = -1;
            gameObject.transform.localScale = new Vector3(horizontalMoveDirection, verticalMoveDirection, 1);
        }

        if(steerAmount == 0)
        {
            verticalMoveDirection = 1;
            horizontalMoveDirection = 1;
        }

        if(moveAmount > 0)
        {
            lookingVertical = true;
            lookingHorizontal = false;

            horizontalMoveDirection = 1;
            verticalMoveDirection = 1;
            gameObject.transform.localScale = new Vector3(horizontalMoveDirection, verticalMoveDirection, 1);
        }

        else if(moveAmount < 0)
        {
            lookingVertical = true;
            lookingHorizontal = false;

            horizontalMoveDirection = -1;
            verticalMoveDirection = -1;
            gameObject.transform.localScale = new Vector3(horizontalMoveDirection, verticalMoveDirection, 1);
        }
    }
}
    
 


