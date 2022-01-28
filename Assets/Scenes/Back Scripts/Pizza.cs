using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pizza : MonoBehaviour
{

    public void LoadScene(string s3)

    {
        SceneManager.LoadScene(s3);
    }
}