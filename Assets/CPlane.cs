using UnityEngine;
using System.Collections;

public class CPlane : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<Renderer> ().material.color = new Color (1, 1, 1, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
