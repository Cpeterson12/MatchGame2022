using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
//all code in this file is based off of the youtube video, "how to make an enemy spawner with scriptable objects?!" by Droei.
public class SpawnData : ScriptableObject
{
  public GameObject enemy;
  public int spawnAmount = 5;
  public float spawnDelay = 0.5f;
  
}
