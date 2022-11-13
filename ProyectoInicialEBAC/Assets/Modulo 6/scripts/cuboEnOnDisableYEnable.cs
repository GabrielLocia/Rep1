using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboEnOnDisableYEnable : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PrefabCubo;
    public int numCubos = 0;
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    void Start()
    {
        listaDeCubos = new List<GameObject>();
    }


    private void OnDisable() {
        numCubos++;
        GameObject temGameObject = Instantiate<GameObject>(PrefabCubo);
        temGameObject.name = "CuboNumero " + numCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        temGameObject.GetComponent<MeshRenderer>().material.color = c;
        Debug.Log("OnDisable");
    }
    private void OnEnable() {
        numCubos++;
        GameObject temGameObject = Instantiate<GameObject>(PrefabCubo);
        temGameObject.name = "CuboNumero " + numCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        temGameObject.GetComponent<MeshRenderer>().material.color = c;
        temGameObject.transform.position = Random.insideUnitSphere;
        Debug.Log("OnEnable");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
