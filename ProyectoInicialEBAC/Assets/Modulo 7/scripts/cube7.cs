using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class cube7 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PrefabCubo;
    public List<GameObject> listaDeCubos;
    // int mydelay = 100;
    public static bool isCube = false;
    public float factorDeEscalamiento;
    private void Awake()
    {
    
        // GameObject temGameObject = Instantiate<GameObject>(PrefabCubo);
        // Color c = new Color(Random.value, Random.value, Random.value);
        // PrefabCubo.GetComponent<MeshRenderer>().material.color = c;
    }

    void Start()
    {
        listaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        if(isCube){
            // GameObject temGameObject = Instantiate<GameObject>(PrefabCubo);
            Color c = new Color(255, 255, 255);
            PrefabCubo.GetComponent<MeshRenderer>().material.color = c;
            isCube = false;
        }else{

            // GameObject temGameObject = Instantiate<GameObject>(PrefabCubo);
            Color c = new Color(0, 0, 0);
            PrefabCubo.GetComponent<MeshRenderer>().material.color = c;           
            isCube = true;
        }
            // Thread.Sleep(mydelay);
    }
}
