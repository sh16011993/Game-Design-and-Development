using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtonLevelLoad : MonoBehaviour
{
    public string LevelToLoad;
    public void loadLevel(){
        SceneManager.LoadScene(LevelToLoad);
    }
}
