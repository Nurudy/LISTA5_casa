using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio4 : MonoBehaviour
{
    public int[] array; //we call the array

    private void Start() //it will show all the array's that you call in the inspector
    {
        Debug.Log(message: $"Element1 = {array[0]}");
        Debug.Log(message: $"Element3 = {array[2]}");
        Debug.Log(message: $"Element5 = {array[4]}");
    }
}
