//Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej01 : MonoBehaviour {
    public int val1;
    public int val2;
	void Start () {
		if (val1 == val2)
        {
            Debug.Log("Los valores ingresados son iguales");
        }
        else
        {
            Debug.Log("Los valores ingresados no son iguales");
        }
	}
	
	void Update () {
		
	}
}
