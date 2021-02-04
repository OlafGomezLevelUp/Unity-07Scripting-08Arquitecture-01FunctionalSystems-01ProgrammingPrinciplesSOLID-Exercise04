using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBehaviour : MonoBehaviour
{
    private void OnTriggerEnter() {
       Destroy(this.gameObject);
       
   }
}
