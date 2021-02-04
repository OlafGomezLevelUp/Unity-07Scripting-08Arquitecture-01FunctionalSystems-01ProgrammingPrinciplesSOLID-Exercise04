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
        return GameObject.Instantiate(enemy, GetRandomPosition(scale, boxCollider), Quaternion.identity);
    }
 
      private Vector2 GetRandomPosition(Vector2 localScale, BoxCollider collider)
    {
        Vector2 cubeSize;
        Vector2 cubeCenter = collider.transform.position;

        cubeSize.x = localScale.x * collider.size.x;
        cubeSize.y = localScale.y * collider.size.y;

         Vector2 randomPosition = new Vector2(Random.Range(-cubeSize.x / 2, cubeSize.x / 2), Random.Range(-cubeSize.y / 2, cubeSize.y / 2));
 
         return cubeCenter + randomPosition;
    }
}
