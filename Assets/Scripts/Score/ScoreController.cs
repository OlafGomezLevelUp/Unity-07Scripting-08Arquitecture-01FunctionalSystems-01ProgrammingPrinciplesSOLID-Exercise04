using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour, ILayerChecker
{
    ScoreBehaviour scoreBehaviour;
    [SerializeField]
    LayerMask scoringLayer;

    [SerializeField]
    Text scoreUIText;

    private void OnEnable() 
    {
        DeathController.KilledGO += AddingKillingScore;
    }

    private void OnDisable() 
    {
       DeathController.KilledGO += AddingKillingScore;
    }

    private void Awake() 
    {
        scoreBehaviour = GetComponent<ScoreBehaviour>();        
    }

    private void Start() 
    {
        RefreshScoreUI();
    }

    void AddingKillingScore(GameObject killed)
    {
        if(ContainsLayer(killed.layer))
        {
            var killPoints = killed.GetComponent<EnemyValue>().GetEnemyValue();
            scoreBehaviour.AddPoints(killPoints);
        }
        RefreshScoreUI();
    }

    private void RefreshScoreUI()
    {
        
        scoreUIText.text = scoreBehaviour.GetTotalPoints().ToString();
    }

    public bool ContainsLayer(int layer) => scoringLayer == (scoringLayer | (1 << layer));
}
