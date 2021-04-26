using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CustomArrayList : ScriptableObject, ISerializationCallbackReceiver
{
    public ArrayList arList = new ArrayList();

    public void OnAfterDeserialize() {
        arList.Clear();
    }

    public void OnBeforeSerialize() { }

    public void resetVectorValue()
    {
        arList.Clear();
    }
}
