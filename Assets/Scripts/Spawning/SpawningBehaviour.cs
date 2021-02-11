using UnityEngine;

public class SpawningBehaviour : MonoBehaviour
{
    BoxCollider boxCollider;
 
 
     private void Awake()
     {
        boxCollider = GetComponent<BoxCollider>();
     }
 
 
     
    public GameObject SpawnObject(GameObject prefab)
    {
        var scale = transform.parent.localScale;
        Vector2 _posA = new Vector2(boxCollider.bounds.min.x, boxCollider.bounds.center.y);
        Vector2 _posB = new Vector2(boxCollider.bounds.max.x, boxCollider.bounds.center.y);
        return GameObject.Instantiate(prefab, GetRandomPosition(_posA, _posB), Quaternion.identity);
    }
 
      private Vector2 GetRandomPosition(Vector2 positionA, Vector2 positionB)
    {
               var _rndPosition = new Vector2(Random.Range(positionA.x, positionB.x),Random.Range(positionA.y, positionB.y));

        return _rndPosition;
    }

    public GameObject SpawnObject(GameObject prefab, Vector3 position, Quaternion rotation)
    {
       return GameObject.Instantiate(prefab, position, rotation);
    }
}
