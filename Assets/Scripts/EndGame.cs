using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();
    }

}
