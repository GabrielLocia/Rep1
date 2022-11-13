using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PrefabCubo;
    private void Awake()
    {
    
        // GameObject temGameObject = Instantiate<GameObject>(PrefabCubo);
        Color c = new Color(Random.value, Random.value, Random.value);
        PrefabCubo.GetComponent<MeshRenderer>().material.color = c;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
