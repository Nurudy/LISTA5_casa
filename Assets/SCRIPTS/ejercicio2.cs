using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2 : MonoBehaviour
{
    public string user;
    public string password;

    private void Start()
    {
        Login(user, password); //we call the function
    }

    private bool Login(string user, string password)
    {
        if(user == "amdin" && password == "abccba") //that's the true password and username
        {
            return true; //you'll enter to the count 
        }
        else
        {
            return false; //if is not, you won't enter
        }
    }
}
