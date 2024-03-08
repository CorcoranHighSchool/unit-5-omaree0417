using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{

    public float targetTime = 50.0f;
    private float time;
    public TextMeshProUGUI timeText;
    private GameManagerX gamemanager;
    //Start is called before the first frame update
    void Start()
    {
        gamemanager = FindObjectOfType<GameManagerX>();
    }
    public void UpdateTime()
    {
        time += Time.deltaTime;
        timeText.text = "Time:" + Mathf.Round(time);
        if (time >= targetTime)
        {

            gamemanager.GameOver();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (gamemanager.isGameActive)
        {
            UpdateTime();
        }
    }
}