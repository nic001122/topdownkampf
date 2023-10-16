using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementScript : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public float forceNum = 3;

    public float horizontalMoveDirection;
    public float verticalMoveDirection;

    public bool lookingNorth;
    public bool lookingSouth;

    [SerializeField] public bool lookingEast;
    public bool lookingWest;

    public SpriteRenderer spriteRenderer;

    public Sprite movingTopRight;
    public Sprite movingLeft;
    public Sprite movingUp;
    public Sprite movingDown;
    public Sprite movingBottomRight;

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

        // Moving right
        if(steerAmount > 0)
        {
            lookingEast = true;

            lookingNorth = false;
            lookingSouth = false;
            lookingWest = false;
            
            spriteRenderer.sprite = movingLeft;
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }

        // Moving left
        else if(steerAmount < 0)
        {
            lookingWest = true;

            lookingEast = false;
            lookingSouth = false;
            lookingNorth = false;

            spriteRenderer.sprite = movingLeft;
            gameObject.transform.localScale = new Vector3(1, 1, 1);

        }

        // Moving up
        if(moveAmount > 0)
        {
            lookingNorth = true;
            
            lookingSouth = false;
            lookingEast = false;
            lookingWest = false;

            spriteRenderer.sprite = movingUp;
        }

        // Moving down
        else if(moveAmount < 0)
        {
            lookingSouth = true;

            lookingNorth = false;
            lookingEast = false;
            lookingWest = false;

            spriteRenderer.sprite = movingDown;
        }

        // Moving up & right
        if(steerAmount > 0 && moveAmount > 0)
        {   
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            spriteRenderer.sprite = movingTopRight;
        }

        // Moving up & left
        else if(steerAmount < 0 && moveAmount > 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
            spriteRenderer.sprite = movingTopRight;
        }

        // Moving down & right
        if(steerAmount > 0 && moveAmount < 0)
        {   
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            spriteRenderer.sprite = movingBottomRight;
        }

        // Moving down & left
        else if(steerAmount < 0 && moveAmount < 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
            spriteRenderer.sprite = movingBottomRight;
        }
    }
}
    
 


