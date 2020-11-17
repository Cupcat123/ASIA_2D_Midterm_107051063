
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
  // u pick the wrong house fool
  public void StartGame()
    {
        print("fku");
        SceneManager.LoadScene("關卡1");

    }
  public void QuitGame ()
    {
        print("ariari");
        Application.Quit();
    }
}
