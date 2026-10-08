using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public float seconds;
    public int minutes;
    public TextMeshProUGUI timerText;


    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
        if (seconds <= 0)
        {
            if (minutes >= 1)
            {
                seconds += 59;
                minutes -= 1;
            }
            else
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }

            


        }
        float roundSeconds  = Mathf.RoundToInt(seconds);
        timerText.text = minutes + ":" + roundSeconds.ToString();
       





    }
}
