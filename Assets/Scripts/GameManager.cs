using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    int points = 0;
    public Text scoreText;
    public GameObject gameOverPanel; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
       
    public void IncrementPoints()
    {
        points += 10;
        DisplayScore();
    }

    public void IncrementExtraPoints()
    {
        points += 30;
        DisplayScore();
    }

    void DisplayScore()
    {
        scoreText.text = "Points: " + points.ToString();
    }

    public void GameOver()
    {
        ObSpawn.instance.gameOver = true;
        StopScrolling();
        gameOverPanel.SetActive(true);
    }

    void StopScrolling()
    {
        TextureScroll[] scrollingObjects = FindObjectsOfType<TextureScroll>(); 

        foreach(TextureScroll t in scrollingObjects)
        {
            t.scroll = false;  
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu"); 
    }

}
