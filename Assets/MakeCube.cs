using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCube : MonoBehaviour {

    // Use this for initialization
    public GameObject obj_cube;//生成方塊
    public float f_time = 0f;//計算時間
    public float f_timetotime = 2f;//每次生成的間格時間
    public static float f_timeEnd = 15;
    public static bool f_gameover = false;
    //間格時間宣告出來，可以在場景中直接設定

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        f_time += Time.deltaTime;
        Vector3 v3_random = new Vector3(Random.Range(-4.5f, 4.5f)
            , Random.Range(1, 3)
            , Random.Range(-4.5f, 4.5f));

        if (f_time > f_timetotime && f_gameover==false)
        {
            f_time = 0;
            GameObject obj_cube_clone = Instantiate(obj_cube
                , v3_random
                , Quaternion.identity) as GameObject;
        }


        if(Time.time > f_timeEnd)
        {
            f_gameover = true;
        }
	}
}
