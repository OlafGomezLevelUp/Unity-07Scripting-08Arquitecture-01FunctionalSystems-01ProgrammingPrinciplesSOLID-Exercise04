using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovmentController : MonoBehaviour
{
    MovementBehaviour movementBehaviour;
    EngineParticlesBehaviour engineParticlesBehaviour;

    void Awake()
    {
        movementBehaviour = GetComponent<MovementBehaviour>();
        engineParticlesBehaviour = GetComponent<EngineParticlesBehaviour>();
        engineParticlesBehaviour.ActivateParticles(true);
    }

    // Update is called once per frame
    void Update()
    {
        movementBehaviour.VerticalMovement();
        
    }
}
