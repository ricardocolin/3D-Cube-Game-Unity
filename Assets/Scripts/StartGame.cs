using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartGameLevels () { 
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
