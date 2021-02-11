using UnityEngine;

public class PlayerHealthBehaviour : HealthBehaviour
{
    [SerializeField]
    GameObject damageFX;
    protected override void ApplyDamage(float value)
    {
        base.ApplyDamage(value);
        var _dmgFX = GameObject.Instantiate(damageFX, transform.position, Quaternion.identity);

    }
}
