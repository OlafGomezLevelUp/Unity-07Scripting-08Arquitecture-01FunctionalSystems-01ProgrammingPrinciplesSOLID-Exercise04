using System;
using UnityEngine;

public class PlayerHealthBehaviour : HealthBehaviour ,IHealthStats
{
    public event Action<IHealthStats> RefreshBar;

    [SerializeField]
    GameObject damageFX;
    
    protected override void ApplyDamage(float value)
    {
        base.ApplyDamage(value);
        var _dmgFX = GameObject.Instantiate(damageFX, transform.position, Quaternion.identity);
        OnRefreshBar(this);

    }

    public float GetPlayerLifePoints()
    {
        var normalizedLife = currentHealth / maxHealth;
        return normalizedLife;
    }


    void OnRefreshBar(IHealthStats healthStats)
    {
        RefreshBar?.Invoke(healthStats);
    }
}
