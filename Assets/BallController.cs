using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;
    private GameObject scoreText;
    private int score = 0;

	// Use this for initialization
	void Start () {
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoreText = GameObject.Find("ScoreText");
        this.scoreText.GetComponent<Text>().text = "Score = " + score;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "GameOver!!";
        }
	}
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "SmallStarTag")
        {
            score += 1;
        } else if (col.gameObject.tag == "LargeStarTag")
        {
            score += 10;
        } else if (col.gameObject.tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            score += 5;
        }

            this.scoreText.GetComponent<Text>().text = "Score = " + score;

    }
}
