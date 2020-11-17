
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void nextLevel(string namelv)
    {
        SceneManager.LoadScene(namelv);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("開頭");
    }

    public void Quit()
    {
        Application.Quit();
    }
        

}
