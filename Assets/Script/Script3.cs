using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        tableau();
        tableau2();
    }

    void tableau()
    {
        int min = 5;
        int max = 5;
        int indexMin = 0;
        int indexMax = 0;
        int[] tab = new int[6];
        for (int i = 0; i < 6; i++)
        {
            tab[i] = Random.Range(0, 10);
            if (tab[i] < min)
            {
                min = tab[i];
                indexMin = i;
            }
            if(tab[i] > max)
            {
                max = tab[i];
                indexMax = i;
            }
        }

        print("Min : "+ min + " Rang : " + indexMin);
        print("Max : "+ max + " Rang : " + indexMax);

    }

    void tableau2()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
