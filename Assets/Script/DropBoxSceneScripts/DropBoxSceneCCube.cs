using UnityEngine;
using System.Collections;

public class DropBoxSceneCCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 0.5f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other){
        if(other.tag == "wall")
        {
            Debug.Log("aaaa");
        }
    }
}
