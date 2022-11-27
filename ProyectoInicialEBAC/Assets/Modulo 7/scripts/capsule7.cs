using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule7 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PrefabCapsula;
    public float factorDeEscalamiento;
    public List<GameObject> listaDeCubos;
    // int mydelay = 100;
    public static  bool isCabsule = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // GameObject temGameObject = Instantiate<GameObject>(PrefabCapsula);
        // Color c = new Color(Random.value, Random.value, Random.value);
        // PrefabCapsula.GetComponent<MeshRenderer>().material.color = c;
    }

    private void FixedUpdate() {
        if (isCabsule)
        {
            GameObject temGameObject = Instantiate<GameObject>(PrefabCapsula);
            Color c = new Color(255, 255, 255);
            PrefabCapsula.GetComponent<MeshRenderer>().material.color = c;

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

            GameObject temGameObject = Instantiate<GameObject>(PrefabCapsula);
            Color c = new Color(0, 0, 0);
            PrefabCapsula.GetComponent<MeshRenderer>().material.color = c;
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
