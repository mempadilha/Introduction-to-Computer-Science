using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{

    private int number1 = 5;
    private int number2 = 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Multiplication: " + number1 + " * " + number2 + " = " + (number1 * number2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
