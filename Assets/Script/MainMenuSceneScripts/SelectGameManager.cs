using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public class SelectGameManager : MonoBehaviour {

	public Dropdown dropDown;
	public List<TempGameInfo> gameInfoList = new List<TempGameInfo> ();
	string selectedGameName ;
	TempGameInfo selectdGameInfo;

	// Use this for initialization
	void Start () {
		gameInfoList.Add (new TempGameInfo ("DropBoxGame", "DropBoxGame 설명글 DropBoxGame 설명글 DropBoxGame 설명글 DropBoxGame 설명글"));
		gameInfoList.Add (new TempGameInfo ("StackBoxGame", "StackBoxGame 설명글 StackBoxGame 설명글S tackBoxGame 설명글 StackBoxGame 설명글"));

		Debug.Log ("start dropDown:" + dropDown.captionText.GetComponent<Text>().text);

		selectedGameName = dropDown.captionText.GetComponent<Text> ().text;
		selectdGameInfo = gameInfoList.Find(e => e.name.Contains(selectedGameName));
		WriteGameComment(selectdGameInfo.comment);
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void OnSelectGame() {
		selectedGameName = dropDown.captionText.GetComponent<Text> ().text;
		selectdGameInfo = gameInfoList.Find(e => e.name.Contains(selectedGameName));

		Debug.Log ("update dropDown: " + dropDown.captionText.GetComponent<Text>().text);

		WriteGameComment(selectdGameInfo.comment);

	}
		
	public void WriteGameComment(String comment) {
		Debug.Log ("update comment: " + comment);
	}
		
	public void DrawGameImage() {

	}

	public class TempGameInfo {
				
		public string name;
		public string comment;

		public TempGameInfo (string name, string comment) {
			this.name = name;
			this.comment = comment;
		}
	}
		

}


