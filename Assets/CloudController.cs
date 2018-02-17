using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour {
    private float minimum = 1.0f;
    private float magSpeed = 10.0f;//拡大縮小のスピード　Sinカーブの振幅を狭くしている
    private float magnification = 0.7f;//sinの値を-0.7から+0.7に変換

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    //    Debug.Log(Mathf.Sin(Time.time*this.magSpeed));
        this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification);
	}
}
