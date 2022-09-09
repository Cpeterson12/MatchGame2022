using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InvisibleEventBehaviour : MonoBehaviour
{
   public UnityEvent invisibleEvent;

   public void OnBecameInvisible()
   {
      invisibleEvent.Invoke();
   }
}
//used this script to disable my health power ups and power downs when the player object is invisible.