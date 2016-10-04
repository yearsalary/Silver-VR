using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;


public class LoginManager : MonoBehaviour {
	
	string id;
	string pw;

	// Use this for initialization
	void Start () {
		var ID_inputTextField = GameObject.Find ("ID_inputTextField").GetComponent<InputField> ();
		var PW_inputTextField = GameObject.Find ("PW_inputTextField").GetComponent<InputField> ();
		var submitIdEvent = new InputField.SubmitEvent ();
		var submitPwEvent = new InputField.SubmitEvent ();

		submitIdEvent.AddListener (SetId);
		submitPwEvent.AddListener (SetPw);

		ID_inputTextField.onEndEdit = submitIdEvent;
		PW_inputTextField.onEndEdit = submitPwEvent;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Login () {
		Debug.Log ("id:"+this.id+"\tpw:"+this.pw);
		UserInfo.id = this.id;
		SceneManager.LoadScene (1);
	}

	public void SetId(string id) {
		this.id = id;
	}

	public void SetPw(string pw) {
		this.pw = pw;
	}

}

