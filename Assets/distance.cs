using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distance : MonoBehaviour
{
    
        public GameObject Cube1;
        public GameObject Cube2;

  /*  void Start()
    {

        Cube1 = GameObject.FindWithTag("Cube1").GetComponent<GameObject>();
        Cube2 = GameObject.FindWithTag("Cube2");

    } */
    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(Cube1.transform.position, Cube2.transform.position);

        Debug.Log(distance);
    }
}
