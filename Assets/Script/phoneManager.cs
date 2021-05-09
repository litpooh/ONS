using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class phoneManager : MonoBehaviour
{
    public Image Dan_icon, Lucy_icon, Samuel_icon, Molly_icon;
    public CustomArrayList characterList;
    public IDictionary<string, Image> iconDict = new Dictionary<string, Image>();
    public int counter = 0;

    private void Start()
    {
        InitPhone();
    }

    public void InitPhone()
    {
        Dan_icon.enabled = false;
        Lucy_icon.enabled = false;
        Samuel_icon.enabled = false;
        Molly_icon.enabled = false;
        iconDict.Add("Dan", Dan_icon);
        iconDict.Add("Lucy", Lucy_icon);
        iconDict.Add("Samuel", Samuel_icon);
        iconDict.Add("Molly", Molly_icon);
        UpdatePhone();
    }

    public void UpdatePhone()
    {
        var tempList = characterList.arList;
        foreach (string character in tempList)
        {
            iconDict[character].enabled = true;
            counter++;
        }
        if (counter == 4){
            SceneManager.LoadScene("congradulation");
        }
    }
}
