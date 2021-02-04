using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineParticlesBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject engine;

    public void ActivateParticles(bool active)
    {
        engine.SetActive(active);
    }
}