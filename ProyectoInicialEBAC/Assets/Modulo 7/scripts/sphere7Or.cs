using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere7Or : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PrefabEsfera;
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    bool isCube = cube7.isCube;
    bool isCabsule = capsule7.isCabsule;
    public static bool isSphereFromOr = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        if (isCabsule || isCube)
        {
            // GameObject temGameObject = Instantiate<GameObject>(PrefabEsfera);
            Color c = new Color(255, 255, 255);
            PrefabEsfera.GetComponent<MeshRenderer>().material.color = c;
            isCabsule = false;
            isSphereFromOr = false;

        }
        else
        {

            // GameObject temGameObject = Instantiate<GameObject>(PrefabEsfera);
            Color c = new Color(0, 0, 0);
            PrefabEsfera.GetComponent<MeshRenderer>().material.color = c;
            isSphereFromOr = true;
        }
    }
}
