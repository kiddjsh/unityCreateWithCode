using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float propellerSpeed = 1000;  // 8.1 | Added a propellerSpeed variable
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, propellerSpeed * Time.deltaTime);  // 8.1 | Added Rotate Vector3.forward to calculate the propellerSpeed variable to every frame around the Z axis
        
    }
}
