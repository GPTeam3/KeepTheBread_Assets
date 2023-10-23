using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public GameObject score;

    void Start()
    {
        score = GameObject.Find("GameScore");
    }
    public void LevelScene()
    {
        SceneManager.LoadScene("SelectLevel");
    }

    public void GameScene1()
    {
        SceneManager.LoadScene("Final1");
        score.GetComponent<GameScore>().level = 0;
    }

    public void GameScene2()
    {
        SceneManager.LoadScene("Final2");
        score.GetComponent<GameScore>().level = 1;
    }

    public void GameScene3()
    {
        SceneManager.LoadScene("Final3");
        score.GetComponent<GameScore>().level = 2;
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("GameMenu");
    }
}

