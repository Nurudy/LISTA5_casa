using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio5 : MonoBehaviour
{
    public int[] array;

    private void Start()
    {
        if(array.Length >= 5)
        {
            Debug.Log(message: $"Element1 = {array[0]}");
            Debug.Log(message: $"Element3 = {array[2]}");
            Debug.Log(message: $"Element5 = {array[4]}");
        }
        else
        {
            Debug.Log(message: $"Missing arguments");
        }
    }


}
