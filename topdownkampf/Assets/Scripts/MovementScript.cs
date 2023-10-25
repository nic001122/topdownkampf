using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
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

    public bool lookingNorthEast;
    public bool lookingNorthWest;

    public bool lookingSouthEast;
    public bool lookingSouthWest;

    public SpriteRenderer spriteRenderer;

    public Sprite movingTopRight;
    public Sprite movingLeft;
    public Sprite movingUp;
    public Sprite movingDown;
    public Sprite movingBottomRight;

    // Dash

    public bool isDashing;
    public float dashSpeed = 20f;
    public float dashTimer;
    public float endDashTimer = .5f;
    public TrailRenderer dashTrail;

    public Stamina stamina;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Dash
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            if(!isDashing && !stamina.staminaIsRefilling && stamina.currentStamina >= 2)
            {
                isDashing = true;
                dashTrail.emitting = true;
                stamina.currentStamina -= 2;
                stamina.staminaIsBeingUsed = true;

                if(lookingEast)
                {
                    rb.velocity = new Vector2(-transform.localScale.x * dashSpeed, 0f);
                }

                if(lookingWest)
                {
                    rb.velocity = new Vector2(-transform.localScale.x * dashSpeed, 0f);
                }

                if(lookingNorth)
                {
                    rb.velocity = new Vector2(0, transform.localScale.y * dashSpeed);
                }

                if(lookingSouth)
                {
                    rb.velocity = new Vector2(0, -transform.localScale.y * dashSpeed);
                }

                if(lookingNorthWest)
                {
                    rb.velocity = new Vector2(transform.localScale.x * dashSpeed, transform.localScale.y * dashSpeed);
                }

                if(lookingNorthEast)
                {
                    rb.velocity = new Vector2(transform.localScale.x * dashSpeed, transform.localScale.y * dashSpeed);
                }

                if(lookingSouthWest)
                {
                    rb.velocity = new Vector2(transform.localScale.x * dashSpeed, -transform.localScale.y * dashSpeed);
                }

                if(lookingSouthEast)
                {
                    rb.velocity = new Vector2(transform.localScale.x * dashSpeed, -transform.localScale.y * dashSpeed);
                }
            }
        }

        if(isDashing)
        {
            dashTimer += Time.deltaTime;
            if(dashTimer >= endDashTimer)
            {
                if(stamina.tempStamina <= stamina.currentStamina)
                {
                    stamina.staminaIsBeingUsed = false;
                    dashTimer = 0f;
                    isDashing = false;
                    dashTrail.emitting = false;
                }

                rb.velocity = new Vector2(0, 0);
            }
        }

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

            lookingNorthEast = false;
            lookingNorthWest = false;
            lookingSouthEast = false;
            lookingSouthWest = false;
            
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

            lookingNorthEast = false;
            lookingNorthWest = false;
            lookingSouthEast = false;
            lookingSouthWest = false;

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

            lookingNorthEast = false;
            lookingNorthWest = false;
            lookingSouthEast = false;
            lookingSouthWest = false;

            spriteRenderer.sprite = movingUp;
        }

        // Moving down
        else if(moveAmount < 0)
        {
            lookingSouth = true;

            lookingNorth = false;
            lookingEast = false;
            lookingWest = false;

            lookingNorthEast = false;
            lookingNorthWest = false;
            lookingSouthEast = false;
            lookingSouthWest = false;

            spriteRenderer.sprite = movingDown;
        }

        // Moving up & right
        if(steerAmount > 0 && moveAmount > 0)
        {
            lookingNorthEast = true;

            lookingNorthWest = false;
            lookingSouthEast = false;
            lookingSouthWest = false;

            lookingNorth = false;
            lookingSouth = false;
            lookingEast = false;
            lookingWest = false;

            gameObject.transform.localScale = new Vector3(1, 1, 1);
            spriteRenderer.sprite = movingTopRight;
        }

        // Moving up & left
        else if(steerAmount < 0 && moveAmount > 0)
        {
            lookingNorthWest = true;

            lookingNorthEast = false;
            lookingSouthWest = false;
            lookingSouthEast = false;

            lookingNorth = false;
            lookingSouth = false;
            lookingEast = false;
            lookingWest = false;

            gameObject.transform.localScale = new Vector3(-1, 1, 1);
            spriteRenderer.sprite = movingTopRight;
        }

        // Moving down & right
        if(steerAmount > 0 && moveAmount < 0)
        {
            lookingSouthEast = true;

            lookingSouthWest = false;
            lookingNorthEast = false;
            lookingNorthWest = false;

            lookingNorth = false;
            lookingSouth = false;
            lookingEast = false;
            lookingWest = false;

            gameObject.transform.localScale = new Vector3(1, 1, 1);
            spriteRenderer.sprite = movingBottomRight;
        }

        // Moving down & left
        else if(steerAmount < 0 && moveAmount < 0)
        {
            lookingSouthWest = true;

            lookingSouthEast = false;
            lookingNorthEast = false;
            lookingNorthEast = false;

            lookingNorth = false;
            lookingSouth = false;
            lookingEast = false;
            lookingWest = false;

            gameObject.transform.localScale = new Vector3(-1, 1, 1);
            spriteRenderer.sprite = movingBottomRight;
        }
    }

    void Dash()
    {
        if(!isDashing && stamina.tempStamina >= 2)
        {
            isDashing = true;
            stamina.currentStamina -= 2;
            stamina.staminaIsBeingUsed = true;

            if(lookingEast)
            {
                rb.velocity = new Vector2(transform.localScale.x * dashSpeed, 0);
            }

            if(lookingWest)
            {
                rb.velocity = new Vector2(-transform.localScale.x * dashSpeed, 0);
            }

            if(lookingNorth)
            {
                rb.velocity = new Vector2(0, transform.localScale.y * dashSpeed);
            }

            if(lookingSouth)
            {
                rb.velocity = new Vector2(0, -transform.localScale.y * dashSpeed);
            }
        }
    }
}
    
 


