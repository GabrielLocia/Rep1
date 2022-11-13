using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboEnUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PrefabCubo;
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    public int numCubos = 0;
    void Start()
    {
        listaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject temGameObject = Instantiate<GameObject>(PrefabCubo);
        temGameObject.name = "CuboNumero " + numCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        temGameObject.GetComponent<MeshRenderer>().material.color = c;
        temGameObject.transform.position = Random.insideUnitSphere;

        listaDeCubos.Add(temGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
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
    }
}
