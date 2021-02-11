using System.Collections;
using UnityEngine;

public class BulletsDeathBehaviour : MonoBehaviour
{
    [SerializeField]
   float delay = 1f;

   private void Start() 
   {
       StartCoroutine(DoDestroyOnTimeOut());
   }

   IEnumerator DoDestroyOnTimeOut()
   {
       yield return new WaitForSeconds(delay);
       Destroy(gameObject);
   }
}
