using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere7AndOr : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PrefabEsfera;
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    bool isCube = cube7.isCube;
    bool isCabsule = capsule7.isCabsule;
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
            GameObject temGameObject = Instantiate<GameObject>(PrefabEsfera);
            Color c = new Color(255, 255, 255);
            PrefabEsfera.GetComponent<MeshRenderer>().material.color = c;

            listaDeCubos.Add(temGameObject);
            List<GameObject> objetosParaEliminar = new List<GameObject>();
            temGameObject.transform.position = Random.insideUnitSphere;
            foreach (GameObject go in listaDeCubos)
            {
                float scale = go.transform.localScale.x;
                scale *= factorDeEscalamiento;
                go.transform.localScale = Vector3.one * scale;

                if (scale <= 0.1)
                {
                    objetosParaEliminar.Add(go);
                }
            }

            foreach (GameObject go in objetosParaEliminar)
            {
                listaDeCubos.Remove(go);
                Destroy(go);
            }
            isCabsule = false;

        }
        else
        {

            GameObject temGameObject = Instantiate<GameObject>(PrefabEsfera);
            Color c = new Color(0, 0, 0);
            PrefabEsfera.GetComponent<MeshRenderer>().material.color = c;
            listaDeCubos.Add(temGameObject);
            List<GameObject> objetosParaEliminar = new List<GameObject>();
            temGameObject.transform.position = Random.insideUnitSphere;
            foreach (GameObject go in listaDeCubos)
            {
                float scale = go.transform.localScale.x;
                scale *= factorDeEscalamiento;
                go.transform.localScale = Vector3.one * scale;

                if (scale <= 0.1)
                {
                    objetosParaEliminar.Add(go);
                }
            }

            foreach (GameObject go in objetosParaEliminar)
            {
                listaDeCubos.Remove(go);
                Destroy(go);
            }

            isCabsule = true;
        }
    }
}
