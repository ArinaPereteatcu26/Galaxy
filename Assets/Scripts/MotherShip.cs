using UnityEngine;

public class MotherShip : MonoBehaviour
{
    [SerializeField] GameSceneManager gameSceneManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameSceneManager.WinGame();
        }
    }
}