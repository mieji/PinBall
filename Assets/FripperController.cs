using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour {

    private HingeJoint myHingeJoint; //HingeJoint型の変数myHingeJointを作る
    private float defaultAngle = 20;
    private float flickAngle = -20;


	// Use this for initialization
	void Start () {
        this.myHingeJoint = GetComponent<HingeJoint>(); //アタッチしたComponentを取得
        SetAngle(this.defaultAngle);

    }

    // Update is called once per frame
    void Update() {
        if (Input.touchCount > 0)
        {
            for(int i=0;i < Input.touchCount; i++)
            {
                Touch touchPos = Input.GetTouch(i);

                if (touchPos.phase == TouchPhase.Began && touchPos.position.x < 180 && tag == "LeftFripperTag")
                {
  //                  Debug.Log(touchPos.position.x);
                    SetAngle(this.flickAngle);
                }

                if (touchPos.phase == TouchPhase.Ended && touchPos.position.x < 180 && tag == "LeftFripperTag")
                {
                    SetAngle(this.defaultAngle);
                }

                if (touchPos.phase == TouchPhase.Began && touchPos.position.x > 180 && tag == "RightFripperTag")
                {
 //                   Debug.Log(touchPos.position.x);
                    SetAngle(this.flickAngle);
                }

                if (touchPos.phase == TouchPhase.Ended && touchPos.position.x > 180 && tag == "RightFripperTag")
                {
                    SetAngle(this.defaultAngle);
                }
            }

        }

       


        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag"){
            SetAngle(this.flickAngle);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag"){
            SetAngle(this.flickAngle);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag"){
            SetAngle(this.defaultAngle);
        }
		
        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag"){
            SetAngle(this.defaultAngle);
        }
	}

    public void SetAngle(float angle)
    {
        JointSpring JointSpr = this.myHingeJoint.spring; //アタッチしたHingeJoint Component の値springを取得してJointSpring型のJointSpr変数に入れる 要するにキーを押す前の今のフリッパの角度を入れる
 //       Debug.Log(JointSpr.targetPosition);
        JointSpr.targetPosition = angle;　//JointSpr変数の要素はsping,damper,targetPositionと3つあって	targetPositionが今回変えたい要素、その要素とはバネが戻ろうとする目標位置。押すと-20が入る
 //       Debug.Log(JointSpr.targetPosition);
        this.myHingeJoint.spring = JointSpr;//ここで角度を変えている。どんな動作で変えるかというとJointSpringで。コンポーネントがついているフリッパの角度を押したときは-20にする
    }

}
