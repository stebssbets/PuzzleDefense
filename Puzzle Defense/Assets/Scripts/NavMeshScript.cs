using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;

public class NavMeshScript : MonoBehaviour
{
    private NavMeshAgent myNavMeshAgentComponent;
    [SerializeField] GameObject agentsTargetDestinationsGameObject;
    [SerializeField] GameObject winLoseText;
    [SerializeField] GameObject winLoseTextPanel;

    private void Awake()
    {
        myNavMeshAgentComponent = gameObject.transform.GetComponent<NavMeshAgent>();
        myNavMeshAgentComponent.SetDestination(agentsTargetDestinationsGameObject.transform.position);
    }

    private void Update()
    {
        CheckIfTargetDestinationHasBeenReached();
    }

    private void CheckIfTargetDestinationHasBeenReached()
    {
        if (Vector3.Distance(gameObject.transform.position, agentsTargetDestinationsGameObject.transform.position) < 0.5f)
        {
            winLoseTextPanel.SetActive(true);
            winLoseText.GetComponent<TextMeshProUGUI>().text = "Oh no, you lose!";
        }
    }
}
