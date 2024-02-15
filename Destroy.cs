using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Delete primitive from hierarchy
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
