using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Joybutton joybutton;
    public Weapon currentWeapon;

    // Update is called once per frame
    void Update()
    {
        // Keyboard
        // The is a current Weapon
        //if (currentWeapon)
        //{
            // Is the fire button down?
        //    if (Input.GetButtonDown("Fire1"))
        //    {
        //        if (currentWeapon.canShoot)
        //        {
        //            currentWeapon.Shoot();
        //        }
        //    }
        //}

        // Joystick Shoot
        if (currentWeapon)
        {
            if (joybutton.Pressed)
            {
                if (currentWeapon.canShoot)
                {
                    currentWeapon.Shoot();
                }
            }
        }
    }
}