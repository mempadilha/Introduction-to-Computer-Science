using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    [Header("Variables")]

    public string name1 = "marcos";
    public string name2 = "marcos";

    public bool booleanVar;
    public int intVar;

    // Start is called before the first frame update
    void Start()
    {
        Square();
        Debug.Log("\"");
       // Square();
        //SumAndAverage();
        //Practice5();
       // CozaLozaWoza();
        /*if (name1 == name2)
        {
            Debug.Log("names are equal");
        }
        else
        {
            Debug.Log("Names are different.");
        }
        */


    }

    public static void Square()
    {
        string square = "";
        for(int i=0; i<5; i++)
        {
            for(int j = 0; j < 5; j++)
            {

                if (j % 2 == 0) square += " # ";
                else square += " 0 ";

            }
            square += "\n";
        }

        Debug.Log(square);
    }

    void SumAndAverage()
    {
        float sum = 0;
        float average;
        for(int i=1;i<=100; i++)
        {
            sum += i;
        }

        Debug.Log("Sum is "+ sum);
        average = (sum / 100);
        Debug.Log("Average is" + average);

    }

    void Practice5()
    {
        if(booleanVar==true || intVar == 5)
        {
            Debug.Log(" Success");
        }
    }

    void CozaLozaWoza()
    {
        string result="";

        for(int i=1; i<=110; i++)
        {

            if (i % 11 == 0 )
            {
                result += i+ "\n";
            }
            else if(i%7==0 && i%5 == 0  && i % 3 == 0 )
            {
                result += (" CozaLozaWoza ");
            }
            else if (i % 7 == 0 && i % 5 == 0)
            {
                result += (" CozaLoza ");
            }
            else if (i % 5 == 0 && i % 3 == 0)
            {
                result += (" LozaWoza ");
            }
            else if (i % 7 == 0 && i % 3 == 0)
            {
                result += (" CozaWoza ");
            }
            else if (i % 7 == 0 )
            {
                result += (" Coza");
            }
            else if ( i % 5 == 0)
            {
                result += (" Loza ");
            }
            else if (i % 3 == 0)
            {
                result += (" Woza ");
            }
            else
            {
                result +=" " + i + " ";
            }
        }

        Debug.Log(result);
    }

    public static void Chessboard()
    {
        string output= "";
        for(int i=0; i<8; i++)
        {
            for(int j=0; j<8; j++)
            {
               /* if (i % 2 == 0)
                {
                    if(j % 2 == 0)
                    {
                        output += " # ";
                    }
                    else
                    {
                        output += " 0 ";
                    }

                }
                else
                {
                    if (j % 2 == 0)
                    {
                        output += " 0 ";
                    }
                    else
                    {
                        output += " # ";
                    }

                }*/
               if(i%2== 0 && j%2 == 0)
                {
                    output += " # ";
                }else if(i % 2 != 0 && j % 2 != 0)
                {
                    output += " # ";

                }
                else
                {
                    output += " 0 ";
                }
            }
            output += "\n";
        }
        Debug.Log(output);
    }

    void Rad()
    {

    }
}
