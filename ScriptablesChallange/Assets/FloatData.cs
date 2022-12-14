using UnityEngine;

[CreateAssetMenu]
//floatdata is inherited from scriptableobject
public class FloatData : ScriptableObject
{
    public float value;
    public void UpdateValue(float num)//num is the updated value
    {
        value += num;
    }
}
