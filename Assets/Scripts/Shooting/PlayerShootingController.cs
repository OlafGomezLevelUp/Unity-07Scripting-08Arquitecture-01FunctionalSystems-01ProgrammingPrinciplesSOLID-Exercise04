using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingController : MonoBehaviour
{
    WeaponBaseBehaviour weapon;

    

    private void Awake()
    {
        weapon = GetComponent<WeaponBaseBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetButton("Jump"))
         {
             weapon.Fire();
         }
    }
}
