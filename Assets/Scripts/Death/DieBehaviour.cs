using UnityEngine;


public class DieBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject dieFX;
    public void Die(SpawningBehaviour spawning)
    {
        spawning.SpawnObject(dieFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
