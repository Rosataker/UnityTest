using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAddS : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.position.y < -5) //方塊掉到 -5 
        {
            HowToWin.f_score += 1.25f;
            Debug.Log(HowToWin.f_score);
            Destroy(gameObject);
        }
	}
}
