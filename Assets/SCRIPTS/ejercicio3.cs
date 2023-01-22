using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio3 : MonoBehaviour
{
    public int Num;

    private void Start()
    {
        addOneToCounter();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) //the letter A will put the number in the inspector
        {
            addOneToCounter();
        }
        else if (Num > 10) //the limit
        {
            Debug.Log("yasta");
        }
    }

    private void addOneToCounter()
    {
        Num++;
    }
}
