using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTimer : MonoBehaviour
{

    public Text timeText;
    public float timer;

	void Start ()
    {
        timer = 0;
	}
	
	void Update ()
    {
        timer = Time.time;
        timeText.text = "Timer: " + timer.ToString();
	}
}
