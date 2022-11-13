using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PrefabEsfera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        Color c = new Color(Random.value, Random.value, Random.value);
        PrefabEsfera.GetComponent<MeshRenderer>().material.color = c;
    }
}
