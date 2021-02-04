using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotLaserBehaviour : WeaponBaseBehaviour
{
    public override void Fire(Vector3 firePoint)
    {
       var bullet = GameObject.Instantiate(bulletPrefab, firePoint, Quaternion.identity);
       bullet.Launch(transform.forward);
    }
}
