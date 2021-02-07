using System.Collections;
using UnityEngine;

public class LaserBulletBehaviour : BulletBase
{
    public override void Launch()
    {
        StartCoroutine(BulletMovement());
    }

    public override void Launch(Vector3 direction)
    {
      StartCoroutine(BulletMovementDirection(direction));
    }

    protected override IEnumerator BulletMovement()
    {
        while (true)
        {
            transform.position += transform.up * speed * Time.deltaTime;
            yield return null;
        }
    }


    IEnumerator BulletMovementDirection(Vector3 direction)
    {
        while (true)
        {
            transform.position += direction * speed * Time.deltaTime;
            yield return null;
        }
    }
}
