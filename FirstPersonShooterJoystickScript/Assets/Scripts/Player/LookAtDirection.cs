using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtDirection : MonoBehaviour
{
    public Transform target; // Reference to Target
    public MasterJoystick joystick; // Reference to Joystick

    // Update is called once per frame
    void LateUpdate()
    {
        // Rotate to target direction
        transform.rotation = Quaternion.LookRotation(target.forward);

        // Joystick Rotation
        transform.Rotate(joystick.Horizontal, joystick.Vertical, 0, Space.World);
    }
}
