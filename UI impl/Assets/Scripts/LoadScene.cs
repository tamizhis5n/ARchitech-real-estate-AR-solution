using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour

{
    public string LevelName = null;
    public void LoadLevel()
    {
        SceneManager.LoadScene(LevelName);
    }
}
