using UnityEngine;
using UnityEngine.UI;

public class LifeBarBehaviour : MonoBehaviour
{
    [SerializeField]
    Image lifeBarFill;

    PlayerHealthBehaviour playerHealthBehaviour;

    private void OnEnable() 
    {
        playerHealthBehaviour.RefreshBar += RefreshLifeBarFillment;
    }

    private void OnDisable() 
    {
        playerHealthBehaviour.RefreshBar -= RefreshLifeBarFillment;
    }

    private void Awake() 
    {
       playerHealthBehaviour = GetComponent<PlayerHealthBehaviour>(); 
    }

   public void RefreshLifeBarFillment(IHealthStats healthStats)
    {
        lifeBarFill.fillAmount = healthStats.GetPlayerLifePoints();
    }
    
}
