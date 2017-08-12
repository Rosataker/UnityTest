using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HowToWin : MonoBehaviour {

    // Use this for initialization

    public Text GUI_score;
    public Text GUI_time;
    public static float f_score;
    
    
    
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        GUI_score.text = "score:" + f_score;
        GUI_time.text = (Time.time < MakeCube.f_timeEnd) ? "time:" + Time.time : "time:" + MakeCube.f_timeEnd;
        

    }
}
