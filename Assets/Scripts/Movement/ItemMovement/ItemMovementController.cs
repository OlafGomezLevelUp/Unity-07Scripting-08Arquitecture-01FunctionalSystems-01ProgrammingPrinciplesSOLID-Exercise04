using UnityEngine;

public class ItemMovementController : MonoBehaviour
{
    MovementBehaviour movementBehaviour;
   
    void Awake()
    {
        movementBehaviour = GetComponent<MovementBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        movementBehaviour.VerticalMovementVector();
        
    }
}
