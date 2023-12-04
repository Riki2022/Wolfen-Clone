using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour
{
    public GameObject pistol;
    public GameObject shotgun;
    public GameObject rifle;
    public GameObject icon_Pistol;
    public GameObject icon_Rifle;
    public GameObject icon_Shotgun;
    public static int currentGun;
    void Update() {
        if (Input.GetKey(KeyCode.Alpha1) && PickupPistol.isAvailable == true)
        {
            pistol.SetActive(true);
            rifle.SetActive(false);
            shotgun.SetActive(false);
            currentGun = 0;
        } else
        if (Input.GetKey(KeyCode.Alpha2) && PickupRifle.isAvailable == true)
        {
            pistol.SetActive(false);
            rifle.SetActive(true);
            shotgun.SetActive(false);
            currentGun = 1;
        } else 
        if (Input.GetKey(KeyCode.Alpha3) && PickupShotgun.isAvailable == true)
        {
            pistol.SetActive(false);
            rifle.SetActive(false);
            shotgun.SetActive(true);
            currentGun = 2;
        }
        if(PickupPistol.isAvailable == true)
        {
            icon_Pistol.SetActive(true);
        }
        if(PickupRifle.isAvailable == true)
        {
            icon_Rifle.SetActive(true);
        }
        if(PickupShotgun.isAvailable == true)
        {
            icon_Shotgun.SetActive(true);
        }
    }
}
