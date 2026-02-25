using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    [SerializeField] GameObject endGamePanel;

    public void WinGame()
    {
        Time.timeScale = 0f;
        endGamePanel.SetActive(true);
        Cursor.visible = true;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }

    public void ReloadLevel()
    {
        StartCoroutine(ReloadLevelRoutine());
    }

    IEnumerator ReloadLevelRoutine()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}