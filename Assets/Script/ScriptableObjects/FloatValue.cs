using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
//public class NewBehaviourScript : using UnityEngine;

//[CreateAssetMenu(fileName = "FloatValue", menuName = "~/Desktop/ONS/BarScene/Assets/Script/ScriptableObjects/FloatValue.cs/FloatValue", order = 0)]
public class FloatValue : ScriptableObject, ISerializationCallbackReceiver {

    public float initValue;

    //[HideInInspector]
    public float runtimeValue;

    public void OnBeforeSerialize(){

    }

    public void OnAfterDeserialize(){
        runtimeValue = initValue;
    }
    
}
