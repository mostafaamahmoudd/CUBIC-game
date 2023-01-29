using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameMAnager : MonoBehaviour
{
    bool gameHasended = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasended == false)
        {
            gameHasended = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
