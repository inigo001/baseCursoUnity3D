using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _4_TransformDeltaTime : MonoBehaviour {

    // Update is called once per frame
    void Update () 
    {
        this.transform.Translate(new Vector3(-0.5f, 0, 0) * Time.deltaTime, Space.World);

        this.transform.Rotate(new Vector3(0, 0, 30) * Time.deltaTime);
    }
        
}
