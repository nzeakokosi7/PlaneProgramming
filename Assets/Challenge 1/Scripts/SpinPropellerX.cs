using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float rotationSpeed = 25f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Make the propeller rotate on the Z-axis every frame,
        // thereby creating a spinning effect
        transform.Rotate(Vector3.forward * rotationSpeed);
        
    }
}
