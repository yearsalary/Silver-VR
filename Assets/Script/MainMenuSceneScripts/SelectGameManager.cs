using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SelectGameManager : MonoBehaviour {

	public Dropdown dropDown;

	// Use this for initialization
	void Start () {
		Debug.Log ("start dropDown:" + dropDown.value);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnSelectGame() {
		Debug.Log ("dropDown value:" + dropDown.value);
	}	


}
