using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{

    public int max = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Lesson3.Square();
        Lesson3.Chessboard();
         //Debug.Log("The sum of the first "+ max + " integers is equal to "+ GaussSum(max));

    }




    public int GaussSum(int n)
    {
        int sum =  (n*(n + 1))/2;
        return sum;
       // Debug.Log("The sum of the first "+ n + " integers is equal to "+ sum );
    }
}
