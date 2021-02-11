using System.Collections;
using UnityEngine;

public class MissileBulletBehaviour : BulletBase
{
    [SerializeField]
    float turnSpeed = 10f;
    Transform target;
    public override void Launch()
    {
        StartCoroutine(BulletMovement());
    }

    protected override IEnumerator BulletMovement()
    {
        while(target != null)
        {
            Vector3 _vectorToTarget = target.position - transform.position;
            float _angle = Mathf.Atan2(_vectorToTarget.y, _vectorToTarget.x) * Mathf.Rad2Deg - 90;
            Quaternion _q = Quaternion.AngleAxis(_angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, _q, Time.deltaTime * speed);
            transform.position += transform.up * speed * Time.deltaTime;
            yield return null;
        }
    }

    public void SetTarget(Transform trgt)
    {
        target = trgt;
    }

    public override void Launch(Vector3 direction)
    {
       Launch();
    }
}
