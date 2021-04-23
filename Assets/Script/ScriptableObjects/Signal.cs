using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "Signal", menuName = "~/Desktop/ONS/BarScene/Assets/Scriptable/Signal.cs/Signal", order = 0)]
[CreateAssetMenu]
public class Signal : ScriptableObject {
    public List <SignalListener> listerners = new List <SignalListener> ();

    public void Raise(){
        for (int i = listerners.Count - 1; i >=0; i--){
            listerners[i].OnSignalRaised();
        }
    }

    public void RegisterListener(SignalListener listener){
        listerners.Add(listener);
    }

    public void DeRegisterListener(SignalListener listener){
        listerners.Remove(listener);
    }
    
}
