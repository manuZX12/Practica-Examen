//Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
//Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej02 : MonoBehaviour {
    public int producto1;
    public int producto2;
    public int producto3;
    public int dinerodisponible;
    int resultante;
	// Use this for initialization
	void Start () {
        resultante = (producto1 + producto2 + producto3);
        if (resultante > dinerodisponible)
        {
            Debug.Log("Los productos superan el monto disponible");
            resultante = (dinerodisponible - resultante);
            Debug.Log("A usted le faltan " +resultante+"");
        }
        else
        {
            Debug.Log("Los productos no superan el monto disponible");
            resultante = (dinerodisponible - resultante);
            Debug.Log("A usted le sobran " + resultante + "");
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
