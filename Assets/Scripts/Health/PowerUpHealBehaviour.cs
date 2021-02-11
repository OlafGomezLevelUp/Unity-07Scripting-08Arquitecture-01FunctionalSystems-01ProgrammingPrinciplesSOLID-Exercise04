using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpHealBehaviour : MonoBehaviour, IHeal
{
    [SerializeField]
    float healingQuantity;
    public void Heal(HealthBehaviour health)
    {
        health.Heal(healingQuantity);
    }
}
