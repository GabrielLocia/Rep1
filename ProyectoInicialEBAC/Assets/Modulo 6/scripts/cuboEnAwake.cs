using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboEnAwake : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PrefabCubo;
    private void Awake() {
        
        Color c = new Color(Random.value, Random.value, Random.value);
        PrefabCubo.GetComponent<MeshRenderer>().material.color = c;
        PrefabCubo.transform.position = Random.insideUnitSphere;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
