using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //public Text timerText;

    //private float startTime;

    public bool TimerOn;

    public Text counterText;

    public float seconds, minutes;

    public GameObject winTextObject;

    //Start is called before the first frame update
    void Start()
    {
        winTextObject.SetActive(false);
        //startTime = Time.time;
        //TimerOn = false;
        //Text counterText = GetComponent<Text>();
        //counterText = GetComponent<Text>() as Text;
    }

    // Update is called once per frame
    void Update()
    {
        //if (finished)
        //    return;

        //float t = Time.time - startTime;

        //string minutes = ((int)t / 60).ToString();
        //string seconds = (t % 60).ToString("f0");

        //timerText.text = minutes + ":" + seconds;

        if (TimerOn == true)
        {
            minutes = (int)(Time.timeSinceLevelLoad / 60f);
            seconds = (int)(Time.timeSinceLevelLoad % 60f);
            counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }



        //minutes = (int)(Time.time / 60f);
        //seconds = (int)(Time.time % 60f);
        //counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger!");
        if (other.gameObject.tag == "Finish") // or whatever you can use to detect the player
        {
            TimerOn = !true;
            winTextObject.SetActive(true);
            Debug.Log("IF Trigger!");
        }
    }




    //public void Finish()
    //{
    //    finished = true;
    //    //timerText.color = Color.Red;
    //}
}
