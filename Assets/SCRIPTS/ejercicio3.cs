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
        if (Input.GetKeyDown(KeyCode.A))
        {
            addOneToCounter();
        }
        else if (Num > 10)
        {
            Debug.Log("yasta");
        }
    }

    private void addOneToCounter()
    {
        Num++;
    }
}
