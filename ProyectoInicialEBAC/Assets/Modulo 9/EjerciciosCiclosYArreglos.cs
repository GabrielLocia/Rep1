using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EjerciciosCiclosYArreglos : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PrefabEsfera;
    int limite = 10;

    int[] arr1;
    int[] arr2;
    int[] arr3;
    int[] arre3;
    int[,] array2D;
    int[] array1;




    private void Awake()
    {
        arr1 = new int[limite];
        arr2 = new int[limite];
        arr3 = new int[limite];
        arre3 = new int[2];
        array2D = new int[,] { { 1, 2, 3 },
                                      { 4, 5, 6 } };

        array1 = new int[] { 7, 8, 9 };
    }

    void Start()
    {
        for (int i = 0; i < limite; i++)
        {
            arr1[i] = Random.Range(0, limite);
            arr2[i] = Random.Range(0, limite);

        }

        for (int i = 1; i < limite; i++)
        {

            arr3[i - 1] = arr1[i - 1] + arr2[i];

        }

        foreach (var item in arr1)
        {
            Debug.Log($"arr1: {item}");

        }
        Debug.Log("==================================");
        foreach (var item in arr2)
        {
            Debug.Log($"arr2: {item}");

        }
        Debug.Log("==================================");
        foreach (var item in arr3)
        {
            Debug.Log($"arr3: {item}");

        }

        Debug.Log("===============STRING===================");



        string[] arr = new string[] { "Hola ", "esta es ", "una cadena ", "con elementos ", "de un array." };
        string res = "";
        foreach (var item in arr)
        {
            res = res + item;
        }

        Debug.Log($"res: {res}");

        Debug.Log("===============BIDIMENCIONAL===================");




        int axu1 = 0;
        int axu2 = 0;
        int axu3 = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {

                if (axu2 == 3)
                {

                    axu2 = 0;
                }

                axu3 = array2D[i, j] * array1[axu2];
                arre3[axu1] = axu3 + arre3[axu1];
                axu2++;
            }
            axu1++;
        }

        foreach (var item in arre3)
        {
            Debug.Log($"arre3: {item}");

        }



    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {

    }
}
