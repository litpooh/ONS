using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class changeplayerstats : MonoBehaviour
{
    /*(public FloatValue currentHealth;
    public FloatValue currentSanity;
    public FloatValue currentMoney;
    public Signal healthSignal;
    public Signal sanitySignal;
    public Signal moneySignal;*/
    // Start is called before the first frame update
    //public DialogueManager.AddLuaObserver("Variable['moneyChange']", LuaWatchFrequency.EveryDialogueEntry, OnMoneyChanged);
    //DialogueManager.AddLuaObserver("Variable['sanChange']", LuaWatchFrequency.EveryDialogueEntry, OnSanityChanged);
    //DialogueManager.AddLuaObserver("Variable['healthChange']", LuaWatchFrequency.EveryDialogueEntry, OnHealthChanged);
    /*
    public void OnMoneyChanged(LuaWatchItem luaWatchItem, Lua.Result newValue) {
        Debug.Log("Money changed by: " + newValue.AsInt);
        currentMoney.runtimeValue += newValue.AsInt;
        moneySignal.Raise();
    }   

    public void OnSanityChanged(LuaWatchItem luaWatchItem, Lua.Result newValue) {
        Debug.Log("Sanity changed by: " + newValue.AsInt);
        currentSanity.runtimeValue += newValue.AsInt;
        sanitySignal.Raise();
    }   

    public void OnHealthChanged(LuaWatchItem luaWatchItem, Lua.Result newValue) {
        Debug.Log("Health changed by: " + newValue.AsInt);
        currentHealth.runtimeValue += newValue.AsInt;
        healthSignal.Raise();
    }   */
}
