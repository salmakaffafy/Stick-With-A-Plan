using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActionHandler : MonoBehaviour
{
    [SerializeField] bool isGood = false;

    void OnTriggerEnter2D(Collider2D i_collider)
    {
        if(isGood)
        {
            handleGoodEffects();
        }
        else
        {
            handleBadEffects();
        }
    }

    void OnTriggerStay2D(Collider2D i_collider)
    {
        
    }

    void OnTriggerExit2D(Collider2D i_collider)
    {
        
    }

    protected abstract void handleGoodEffects();

    protected virtual void handleBadEffects()
    {
        // basic implementation for handling bad effects
    }


}
