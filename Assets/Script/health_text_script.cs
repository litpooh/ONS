using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health_text_script : MonoBehaviour
{
    public Text status;
    public FloatValue currentStat;
    public int caseSwitch; // 1 = health, 2 = SAN, 3 = money
    // Start is called before the first frame update
    public void Start()
    {
        switch (caseSwitch)
        {
            case 1:
                status.text = "HEALTH: " + currentStat.runtimeValue.ToString();
                break;
            
            case 2:
                status.text = "SANITY: " + currentStat.runtimeValue.ToString();
                break;

            case 3: default:
                status.text = "$" + currentStat.runtimeValue.ToString();
                break;
        }
    }

    public void update()
    {
        switch (caseSwitch)
        {
            case 1:
                status.text = "HEALTH: " + currentStat.runtimeValue.ToString();
                break;
            
            case 2:
                status.text = "SANITY: " + currentStat.runtimeValue.ToString();
                break;

            case 3: default:
                status.text = "$" + currentStat.runtimeValue.ToString();
                break;
        }
    }

}
