using UnityEngine;

public class ShotLaserBehaviour : WeaponBaseBehaviour
{
    public override void Fire(Vector3 firePoint)
    {
       var bullet = GameObject.Instantiate(bulletPrefab, firePoint, Quaternion.identity);
       bullet.Launch();
       SetNextFireTime();
    }
}
