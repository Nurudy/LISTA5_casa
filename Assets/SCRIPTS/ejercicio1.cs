using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    public float X;
    public float Y;
    public float Z;

    private void Start()
    {
        Mult(X, Y, Z);
    }

    private float Mult(float NumX, float NumY, float NumZ)
    {

        float result = (X + Y + Z) / 3;
        return result;

    }

}
