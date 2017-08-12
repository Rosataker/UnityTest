using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    // Use this for initialization
    public GameObject obj_player;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (MakeCube.f_gameover == false) { 
            if(Input.GetKey(KeyCode.A))//偵測鍵盤按下A
            {//按下後每次移動0.1單位
                obj_player.transform.position += new Vector3(-0.1f, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                obj_player.transform.position += new Vector3(0.1f, 0, 0);
            }
            if (Input.GetKey(KeyCode.W))
            {
                obj_player.transform.position += new Vector3(0, 0, 0.1f);
            }
            if (Input.GetKey(KeyCode.S))
            {
                obj_player.transform.position += new Vector3(0, 0, -0.1f);
            }
        }
    }
}
