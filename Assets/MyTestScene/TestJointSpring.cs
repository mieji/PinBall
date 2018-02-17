using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestJointSpring : MonoBehaviour {
    public float haneru = 10;
    public float kakudo = 70;
	// Use this for initialization
	void Start () {

     
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void hingeDoor()
    {
 //       Debug.Log("test");
        HingeJoint hinge = GetComponent<HingeJoint>();
        JointSpring spring = hinge.spring;
        spring.spring = haneru;
        spring.damper = 3;
        spring.targetPosition = kakudo;
        hinge.spring = spring;

    }
}
