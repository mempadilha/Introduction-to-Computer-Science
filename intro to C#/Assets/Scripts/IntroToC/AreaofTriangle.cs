using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AreaofTriangle : MonoBehaviour
{

    public TextMeshProUGUI output;
    public TMP_InputField theight;
    public TMP_InputField tbase;
    public Button button;
    public GameObject buttonObj;

    private float _height;
    private float _base;
    private float _area;

    private void Update()
    {
        /***** using Button enabled *****
        if (theight.text == "" || tbase.text == "")
        {
            button.enabled = false;
           // Debug.Log("button off");
        }
        else
        {
            button.enabled = true;
           // Debug.Log("button on");
        }
        */

        if (theight.text == "" || tbase.text == "")
        {
            buttonObj.SetActive(false);
        }
        else
        {
            buttonObj.SetActive(true);
        }

    }

    public void Calculate()
    {
        // if(_height!=null && _base != null) { 
        if (theight.text != "" && tbase.text != "")
        {
        _height =float.Parse(theight.text);
        _base = float.Parse(tbase.text);
        _area = (_height * _base / 2);

        output.text = _area.ToString();
        }
    }

}
