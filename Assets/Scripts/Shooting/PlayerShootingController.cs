using UnityEngine;

public class PlayerShootingController : MonoBehaviour
{
    WeaponBaseBehaviour weapon;

    [SerializeField]
    Transform gun;
    

    private void Awake()
    {
        weapon = GetComponent<WeaponBaseBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetButton("Jump") && weapon.CanFire())
         {
            weapon.Fire(gun.position);
         }
    }
}
