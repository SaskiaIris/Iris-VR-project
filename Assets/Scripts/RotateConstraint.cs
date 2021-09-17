using UnityEngine;
using System.Collections;

public class RotateConstraint : MonoBehaviour {
    void Update() {
        float rotationZ = transform.localEulerAngles.z;

        if(rotationZ < 335 && rotationZ > 180)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 335);
        }
        else if(rotationZ > 25) {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 25);
        }

		Debug.Log(rotationZ);
    }
}