using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    float speed = -7.0f;
    public GameObject obj;
    GameManager manager;
    public GameObject player;
    string check;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 bomb_vector = transform.position;
        Vector2 player_vector = player.transform.position;
        transform.Translate(0, speed * Time.deltaTime, 0);
        float distance = Vector2.Distance(player_vector, bomb_vector);

        if (distance < 1f)
        {
            manager.GameOver();
            Destroy(gameObject);
        }

        if (transform.position.y <= -4.0f)
        {
            manager.ScoreText(100);
            Instantiate(obj, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        check = manager.score.text;
        if(Convert.ToInt32(check) > 2000)
        {
            manager.LevelUp();
        }

        
    }
}
