using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnExitEventBehaviour : MonoBehaviour
{
    public UnityEvent exitEvent;

    private void OnCollisionExit(Collision other)
    {
        exitEvent.Invoke();
    }
}
//used to change the sprite of the player character after colliding with health power up