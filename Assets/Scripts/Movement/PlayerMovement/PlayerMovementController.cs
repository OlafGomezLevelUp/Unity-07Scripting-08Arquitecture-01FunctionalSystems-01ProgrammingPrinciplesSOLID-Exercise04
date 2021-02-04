using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    MovementBehaviour movementBehaviour;
    EngineParticlesBehaviour engineParticlesBehaviour;

    void Awake()
    {
        movementBehaviour = GetComponent<MovementBehaviour>();
        engineParticlesBehaviour = GetComponent<EngineParticlesBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        movementBehaviour.HorizontalMovement(Input.GetAxis("Horizontal"));
        engineParticlesBehaviour.ActivateParticles(Input.GetAxis("Horizontal") != 0);
    }
}
