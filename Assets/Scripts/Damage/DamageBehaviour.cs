using UnityEngine;

public class DamageBehaviour : MonoBehaviour
{
    [SerializeField]
    float damage;

    public void DoDamage(HealthBehaviour target)
    {
        target.Damage(damage);
    }
}
