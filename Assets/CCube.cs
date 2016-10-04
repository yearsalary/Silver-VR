using UnityEngine;
using System.Collections.Generic;
using Leap.Unity;

public class CCube : MonoBehaviour {
	List<string> touchedBoneList = new List<string>();
	enum Bons{
		bone1, bone2, bone3 
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col) {
		//Debug.Log (col.collider.name);
		/*
		if(frame.Hands.Count > 0){
			List<Leap.Hand> hands = frame.Hands;
			Leap.Hand firstHand = hands [0];
			Debug.Log (firstHand.GrabStrength);
		}
		*/

		/**
		foreach (string name  in System.Enum.GetNames(typeof(Bons))) {
			if (col.collider.name.Equals (name)) {
				touchedBoneList.Add (name);
			}
				
		}
		Debug.Log (touchedBoneList.Count);
		touchedBoneList.Clear ();
		**/
	}
}
