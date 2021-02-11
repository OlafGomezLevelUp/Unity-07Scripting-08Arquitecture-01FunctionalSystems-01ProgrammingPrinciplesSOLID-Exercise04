using System;
using UnityEngine;

public class HealthBehaviour : MonoBehaviour
{
    public event Action Dead;

    [SerializeField]
    protected float maxHealth;

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
           ApplyHeal(value);
        }
    }


    protected virtual void ApplyDamage(float value)
    {
        currentHealth = Math.Max(currentHealth - value , 0);
    }

    protected virtual void ApplyHeal(float value)
    {
        currentHealth = Math.Min(currentHealth + value , maxHealth);
    }

    void OnDead() 
    {
        Dead?.Invoke();
    }

   
}
