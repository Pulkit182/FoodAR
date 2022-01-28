using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public Back()
    {
    }

    public void LoadPreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }



}

