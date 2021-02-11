using UnityEngine;

public class EnemyDieBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject dieFX;
    public void Die(SpawningBehaviour spawning)
    {
        spawning.SpawnObject(dieFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
