using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractController : MonoBehaviour
{
        public bool inRange;

        public UnityEvent interactAction;
    
    void Update()
    {
        if(inRange)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                interactAction.Invoke();
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            inRange = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            inRange = false;
        }
    }
}
