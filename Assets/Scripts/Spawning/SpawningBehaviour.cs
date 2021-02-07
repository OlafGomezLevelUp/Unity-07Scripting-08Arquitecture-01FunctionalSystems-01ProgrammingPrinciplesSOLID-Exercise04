using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningBehaviour : MonoBehaviour
{
    BoxCollider boxCollider;
 
 
     private void Awake()
     {
        boxCollider = GetComponent<BoxCollider>();
     }
 
 
     
    public GameObject SpawnEnemy(GameObject enemy)
    {
        var scale = transform.parent.localScale;
        Vector2 _posA = new Vector2(boxCollider.bounds.min.x, boxCollider.bounds.center.y);
        Vector2 _posB = new Vector2(boxCollider.bounds.max.x, boxCollider.bounds.center.y);
        return GameObject.Instantiate(enemy, GetRandomPosition(_posA, _posB), Quaternion.identity);
    }
 
      private Vector2 GetRandomPosition(Vector2 positionA, Vector2 positionB)
    {
        // Vector2 cubeSize;
        // Vector2 cubeCenter = collider.transform.position;

        // cubeSize.x = localScale.x * collider.size.x;
        // cubeSize.y = localScale.y * collider.size.y;

        //  Vector2 randomPosition = new Vector2(Random.Range(-cubeSize.x / 2, cubeSize.x / 2), Random.Range(-cubeSize.y / 2, cubeSize.y / 2));
 
        //  return cubeCenter + randomPosition;

        var _rndPosition = new Vector2(Random.Range(positionA.x, positionB.x),Random.Range(positionA.y, positionB.y));

        return _rndPosition;
    }
}
