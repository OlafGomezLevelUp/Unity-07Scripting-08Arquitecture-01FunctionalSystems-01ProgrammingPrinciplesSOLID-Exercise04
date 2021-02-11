using UnityEngine;

public class EnemyDeathController : MonoBehaviour
{
    HealthBehaviour healthBehaviour;
    SpawningBehaviour spawningBehaviour;
    EnemyDieBehaviour enemyDieBehaviour;

    private void OnEnable() {
        
        healthBehaviour.Dead += OnDead;
    }

     private void OnDisable() {
        
        healthBehaviour.Dead -= OnDead;
    }

    private void Awake() {
        healthBehaviour = GetComponent<HealthBehaviour>();
        spawningBehaviour = GetComponent<SpawningBehaviour>();
        enemyDieBehaviour = GetComponent<EnemyDieBehaviour>();
    }

    void OnDead()
    {
        enemyDieBehaviour.Die(spawningBehaviour);
    }
}
