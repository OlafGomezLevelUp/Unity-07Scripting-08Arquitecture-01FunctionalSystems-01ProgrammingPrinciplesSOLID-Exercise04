using UnityEngine;
using System.Collections;

public abstract class BulletBase : MonoBehaviour
{
   [SerializeField]
   protected float speed;

   public abstract void Launch();

   public abstract void Launch(Vector3 direction);
   
  protected abstract IEnumerator BulletMovement();

}
