using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test15 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static float Add(float num1, float num2)
    {
        return num1 + num2;
    }

    public List<float> numbers = new List<float>();

    public float Average()
    {
        numbers.Add(1);
        numbers.Add(3);

        float sum=0;
        for(int i=0; i<numbers.Count; i++)
        {
            sum += numbers[i];
        }
        return sum / numbers.Count;
    }

}
