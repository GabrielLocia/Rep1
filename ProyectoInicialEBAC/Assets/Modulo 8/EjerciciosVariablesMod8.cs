using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PrefabCubo;
    public GameObject PrefabEsfera;

    int intFrame = 0;
    float floatFixed = 1;
    float a = 5, b = 2;
    float floatString = 37.3333f;
    int cint;
    string colorCubo = "rojo";
    string stringFloat = "";

    string nombre = "Gabriel Antaño Locia";

    private void Awake()
    {
        stringFloat = floatString.ToString();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        intFrame++;
        Debug.Log("intFrame ====> " + intFrame);
        Debug.Log("stringFloat ====> " + stringFloat);
    }

    private void FixedUpdate()
    {
        floatFixed *= 2;
        Debug.Log("floatFixed ====>" + floatFixed);

        Debug.Log("===========================>");

        cint = (int)(a / b);

        Debug.Log("Resultado Int =====>  " + cint);


        Debug.Log("===========================>");

        if (intFrame % 2 == 0)
        {
            Color c = new Color(0, 1, 1, 1);
            PrefabCubo.GetComponent<MeshRenderer>().material.color = c;
        }
        else
        {
            Color c = new Color(1, 0, 0, 1);
            PrefabCubo.GetComponent<MeshRenderer>().material.color = c;
        }


        Debug.Log("===========================>");
        switch (colorCubo)
        {
            case "verde":
                Color cv = new Color(0, 1, 0, 1);
                PrefabEsfera.GetComponent<MeshRenderer>().material.color = cv;
                break;
            case "azul":
                Color ca = new Color(0, 0, 1, 1);
                PrefabEsfera.GetComponent<MeshRenderer>().material.color = ca;
                break;
            case "rojo":
                Color cr = new Color(1, 0, 0, 1);
                PrefabEsfera.GetComponent<MeshRenderer>().material.color = cr;
                break;
            case "cyan":
                Color cc = new Color(0, 1, 1, 1);
                PrefabEsfera.GetComponent<MeshRenderer>().material.color = cc;
                break;

        }


        Debug.Log("===========================>");

        string nom = nombre.Substring(0, 7);
        string ap1 = nombre.Substring(8, 6);
        string ap2 = nombre.Substring(15);



        Debug.Log($"Substring========>{nom} {ap1} {ap2}");

        string[] split = nombre.Split(' ');

        foreach (var sub in split)
        {
            Debug.Log($"split: {sub}");
        }


        Debug.Log("===========================>");
        string str1 = "2022";
        string str2 = "2023";

        int uno, dos;
        int.TryParse(str1, out uno);
        int.TryParse(str2, out dos);

        int total = uno + dos;
        Debug.Log("Resultado==========>" + total);


        Debug.Log("===========================>");
        for (int i = 0; i < nombre.Length; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log("Resultado==========>" + nombre[i]);
            }
        }



        Debug.Log("===========================>"); 

        string strU = "Eliminar los pimeros 5 caracteres" ;

        Debug.Log("strUAntes========>" +strU ); 
        strU = strU.Substring(5);
        Debug.Log("strUDespues========>" +strU ); 



    }
}
