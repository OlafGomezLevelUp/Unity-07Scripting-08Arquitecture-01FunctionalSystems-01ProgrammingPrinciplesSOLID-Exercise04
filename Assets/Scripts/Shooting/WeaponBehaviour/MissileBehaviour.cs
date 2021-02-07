using System.Linq;
using UnityEngine;

public class MissileBehaviour : WeaponBaseBehaviour
{
    public override void Fire(Vector3 firePoint)
    {
        GameObject _enemy = GetNearEnemy();
        if(_enemy != null)
        {
            var _missile = GameObject.Instantiate(bulletPrefab, transform.position, Quaternion.identity).GetComponent<MissileBulletBehaviour>();
            _missile.SetTarget(_enemy.transform);
            _missile.Launch();
            SetNextFireTime();

        }
    }

    GameObject GetNearEnemy()
    {
        GameObject[] _enemies = FindObjectsOfType<GameObject>().Where(obj => obj.layer.Equals(LayerMask.NameToLayer("Enemy")) && obj.transform.position.y > transform.position.y)
                                .ToArray();

        GameObject _nearEnemy = null;

        float _distance = float.MaxValue;

        for (int i = 0; i < _enemies.Length; i++)
        {
            float _enemyDistance = Vector3.SqrMagnitude(transform.position - _enemies[i].transform.position);

            if(_enemyDistance < _distance)
            {
                _nearEnemy = _enemies[i];
                _distance = _enemyDistance;
            }
        }

        return _nearEnemy;
    }
}
