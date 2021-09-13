using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{

    public List<string> theBeatles = new List<string>();

    private string output = "";
    // Start is called before the first frame update
    void Start()
    {
        theBeatles.Add("Paul");
        theBeatles.Add("John");
        theBeatles.Add("George");
        theBeatles.Add("Ringo");

        Debug.Log(theBeatles);
        Debug.Log(theBeatles[0]);
        theBeatles.Remove("George");
        theBeatles.Insert(1, "George");


        for (int i= 0; i< theBeatles.Count; i++)
        {
            output += " " + theBeatles[i];
        }
        Debug.Log(output);
        int a = 0;
        int b = 5;
    }

 
}
