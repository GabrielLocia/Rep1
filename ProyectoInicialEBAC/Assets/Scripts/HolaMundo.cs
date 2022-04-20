using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update

    public static GameObject  myobject;
    private int count;
    private void Awake() {
        myobject = this.gameObject;
        count = 0;
        Debug.Log("Inicializando mi objeto: " + myobject.name);
    }

    void Start()
    {
        Debug.LogWarning("El valor inicial de count es igual a = " + count);
    }

    // Update is called once per frame
    void Update()
    {

      Debug.LogError("El valor de count incrementa: " + count++ );
    }
}
