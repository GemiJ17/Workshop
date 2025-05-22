using UnityEngine;
using UnityEngine.SceneManagement;
public class StartBTN : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnPressStartButton()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void OnPressQuitButton()
    {
        Application.Quit();
    }
   
}
