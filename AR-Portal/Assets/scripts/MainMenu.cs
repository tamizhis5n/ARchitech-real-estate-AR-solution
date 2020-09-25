using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void furnished()
    {
        SceneManager.LoadScene(1);
    }
    public void empty()
    {
        SceneManager.LoadScene(2);
    }
    public void xray()
    {
        SceneManager.LoadScene(3);
    }
}
