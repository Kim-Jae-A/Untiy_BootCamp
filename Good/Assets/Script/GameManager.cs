using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI score;
    public GameObject bomb;
    public GameObject gameover;
    public GameObject loding;
    public GameObject tjfaud;
    // GameObject player;
    public static bool isdead = false;
    float scorecheck;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        scorecheck = 0;
        score.text = $"{scorecheck}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreText(float sc)
    {
        scorecheck += sc;
        score.text = $"{scorecheck}";
    }
    
    public void OnRetryButtonEnter()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GameOver()
    {
        gameover.SetActive(true);
        Time.timeScale = 0;
    }
    public void OnStartButtonEnter()
    {    
        //SceneManager.LoadScene("SampleScene");
        loding.SetActive(false);
        tjfaud.SetActive(false);

        Time.timeScale = 1;
    }

    public void OnTjfaudButtonEnter()
    {
        tjfaud.SetActive(true);
    }
    public void OnTjfaudCloseButtonEnter()
    {
        tjfaud.SetActive(false);
    }

    public void LevelUp()
    {
        Time.timeScale = 2;
    }

}
