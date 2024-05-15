using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    bool endGame = false;
    float delay = 0.5f;
    public GameObject triggerText;
    public void Complete()
    {
        triggerText.SetActive(true);
        Debug.Log("Won");
    }
   public void GameOver()
    {
        if(endGame==false)
        {
            endGame = true;
            Debug.Log("Game Over");
            Invoke("Replay", delay);
        }
       
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
