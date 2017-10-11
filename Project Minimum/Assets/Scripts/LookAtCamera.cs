using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour {

    public Transform targetCamera;
    public float rotateText;

    // Update is called once per frame
	void Update () {

        transform.LookAt(targetCamera);
        transform.Rotate(0, rotateText, 0);
    }
}
