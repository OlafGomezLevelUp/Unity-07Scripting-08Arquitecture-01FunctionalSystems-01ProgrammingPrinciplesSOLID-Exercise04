using System;
using UnityEngine;

public class HealthBehaviour : MonoBehaviour
{
    public event Action Dead;

    [SerializeField]
    float maxHealth;

    protected float currentHealth;

    private void Awake() {
        currentHealth = maxHealth;
    }

    public virtual void Damage(float value)
    {
        ApplyDamage(value);

        if(currentHealth <= 0)
            OnDead();
    }

    public void Heal(float value)
    {
        if(currentHealth < maxHealth)
        {
            currentHealth = Math.Min(currentHealth + value , 0);
        }
    }

    protected virtual void ApplyDamage(float value)
    {
        currentHealth = Math.Max(currentHealth - value , 0);
    }

    protected virtual void ApplyHeal(float value)
    {
        currentHealth = Math.Min(currentHealth + value , 0);
    }

    void OnDead() 
    {
        Dead?.Invoke();
    }
}
