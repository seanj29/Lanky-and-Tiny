using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LankyScript : MonoBehaviour
{

    public float rotateSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
    }
}
