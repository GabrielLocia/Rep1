using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente1 : MonoBehaviour
{
    // Start is called before the first frame update

    public static GameObject miObjeto;
    private void Awake() {
    }
    void Start()
    {
        
        miObjeto  = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
