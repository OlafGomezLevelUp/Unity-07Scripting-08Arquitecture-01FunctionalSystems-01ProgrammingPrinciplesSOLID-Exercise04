using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotShellBehaviour : WeaponBaseBehaviour
{
    [SerializeField]
    int bulletCapacity = 3;

    [SerializeField]
    float angleRange = 90;

    public override void Fire(Vector3 firePoint)
    {
        float _fraction = angleRange / bulletCapacity;
        for (int i = 0; i < bulletCapacity; i++)
        {
            float _degrees = _fraction * i - (angleRange / 2) + (_fraction / 2);
            float _radians = Mathf.Deg2Rad * _degrees;
            Vector3 _direction = transform.rotation * new Vector3(Mathf.Sin(_radians), Mathf.Cos(_radians), 0);
            var _bullet = GameObject.Instantiate(bulletPrefab, transform.position, Quaternion.Euler(_direction));
            _bullet.Launch(_direction.normalized);
        }

        SetNextFireTime();
    }
}
