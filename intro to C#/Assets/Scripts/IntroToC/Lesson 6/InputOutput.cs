using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputOutput : MonoBehaviour
{
    public TextMeshProUGUI output;
    public TMP_InputField input;

  public void ClickMe()
    {
        output.text = input.text;
    }

}
