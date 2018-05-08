using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour {
    [Header("Main Text Objects")]
    public Text UsernameText;
	// Use this for initialization
	void Start () {
        UsernameText.text = AppManager.instance.User.username;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
