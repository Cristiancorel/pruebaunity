using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
  
    public string variablename;
    public Button botoningreso;
    public Text nombre;
    public InputField inputvalue;
    public GameObject objetoDestruir;

    // logica de ingreso
    public void VerificarValor()
    {
        string userID = inputvalue.text;


        if (userID == "Cristian")
        {
            botoningreso.gameObject.SetActive(true);
        }
    }
    // terminar con nivel 1
    public void destruir()
    {
        Destroy(objetoDestruir);
    }

    // Variables de Nivel 1

    public GameObject numeroimpar1;
    public GameObject numeroimpar2;
    public Button boton;

    // Variables de Nivel 2

    public GameObject numeropar1;
    public GameObject numeropar2;
    public GameObject numeropar3;
    public Button botonganaste;

    // Update is called once per frame
    void Update()
    {
        // Logica de nivel 1

        if (numeroimpar1.activeSelf && numeroimpar2.activeSelf)
        {
            boton.gameObject.SetActive(true);

        }
        else
        {
            boton.gameObject.SetActive(false);
        }

        // Logica de ganar

        if (numeropar1.activeSelf && numeropar2.activeSelf && numeropar3.activeSelf)
        {
            botonganaste.gameObject.SetActive(true);
        }
        
}
}
