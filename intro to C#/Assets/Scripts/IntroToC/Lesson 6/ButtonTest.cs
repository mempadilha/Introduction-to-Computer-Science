using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonTest : MonoBehaviour
{
   public TextMeshProUGUI uitext;
    private void Start()
    {
        uitext.SetText("Hallo, Welt");

    }


  public void Click()
    {
        Debug.Log("Ouch! you clicked me");
        uitext.SetText("Ouch! you clicked me");
    }


}
