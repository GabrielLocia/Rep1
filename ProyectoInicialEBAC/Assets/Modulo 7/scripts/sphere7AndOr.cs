using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere7AndOr : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PrefabEsfera;
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    bool isSphereU = false;
    bool isSphere = sphere7.isSphere;
    bool isSphereFromOr = sphere7Or.isSphereFromOr;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        if ((isSphere || !isSphereFromOr) && isSphereU)
        {
            // GameObject temGameObject = Instantiate<GameObject>(PrefabEsfera);
            Color c = new Color(255, 255, 255);
            PrefabEsfera.GetComponent<MeshRenderer>().material.color = c;
            isSphereU = false ;
        }
        else
        {
            // GameObject temGameObject = Instantiate<GameObject>(PrefabEsfera);
            Color c = new Color(0, 0, 0);
            PrefabEsfera.GetComponent<MeshRenderer>().material.color = c;
            isSphereU = true;
        }
    }
}
