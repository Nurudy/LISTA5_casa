using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2 : MonoBehaviour
{
    public string user;
    public string password;

    private void Start()
    {
        Login(user, password);
    }

    private bool Login(string user, string password)
    {
        if(user == "amdin" && password == "abccba")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
