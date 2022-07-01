using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    public int mp = 53;

    public void mahoukougeki()
    {
        if (mp>=5)
        {
            mp -=5;
            Debug.Log("魔法攻撃をした。残りMP" + mp + "!");

        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない!");
        }
    }


}




public class Hairetu
{

    public int[] array = { 10, 20, 30, 40, 50, 60, 70 };

    public void hidarikara()
    {


        for (int i = 0; i < array.Length; i++)
            
        {
            Debug.Log(array[i]);
        }
    }

    public void migikara()
    {
        for (int i = 6; i >-1 ; i--)
        {
            Debug.Log(array[i]);
        }
    }

    

    

}

public class ScriptTest : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        Hairetu hairetu = new Hairetu();

        hairetu.hidarikara();
        hairetu.migikara();

        Boss boss = new Boss();

        for (int i = 0; i < 11; i++)
        {
            boss.mahoukougeki();
        }


    }

    // Update is called once per frame

}
