using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnDisableEventBehavior : MonoBehaviour
{
    public UnityEvent disableEvent;

    public void OnDisable()
    {
        disableEvent.Invoke();
    }
}
//used to give a "Game Over" text in the text box after the power up and power down are disabled.