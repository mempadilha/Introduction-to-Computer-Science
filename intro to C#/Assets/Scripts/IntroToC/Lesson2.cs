using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    public int number1 = 1;
    public int number2 = 2;
    public float speed = 1.5f;


    void Start()
    {
       

        Debug.Log(Mathf.Pow(number1, number2));
    }

   
}
