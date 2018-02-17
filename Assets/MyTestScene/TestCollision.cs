using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour {

//    Material myMaterial; //material型の変数myMaterial
    Color color = Color.green; //Color型の変数colorにgreenを指定
    private float minEmission = 0.3f;
    private int degree = 0;
    private int speed = 10;

	// Use this for initialization
	void Start () {
 //       this.myMaterial = GetComponent<Renderer>().material;
//        Debug.Log(myMaterial);
 //       Debug.Log(this.color*minEmission);
	}
	
	// Update is called once per frame
	void Update () {
        if (this.degree >= 0)
        {
 //           Color.emissionColor = this.
 //           myMaterial.SetColor("_EmissionColor", this.color * emissionColor);
        }
 
    }

    private void OnCollisionEnter(Collision other)
    {
        this.degree = 180;
 
    }
}
