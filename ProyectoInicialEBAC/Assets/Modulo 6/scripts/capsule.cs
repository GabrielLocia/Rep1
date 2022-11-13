using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PrefabCapsula;
    public float factorDeEscalamiento;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // GameObject temGameObject = Instantiate<GameObject>(PrefabCubo);
        Color c = new Color(Random.value, Random.value, Random.value);
        PrefabCapsula.GetComponent<MeshRenderer>().material.color = c;
    }
}
