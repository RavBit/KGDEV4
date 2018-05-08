using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonConnect : MonoBehaviour {


    public string VersionName = "0.1";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ConnectToPhoton()
    {
        PhotonNetwork.ConnectUsingSettings(VersionName);

        Debug.Log("Connecting to Photon");
    }

    private void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(TypedLobby.Default);
    }

    private void OnJoinedLobby()
    {
        Debug.Log("On Joined Lobby");
        EventManager.Update_HubUI(ConnectState.Connected);
    }
    private void OnDisconnectedFromPhoton()
    {
        Debug.Log("Disconnected from Photon");
        EventManager.Update_HubUI(ConnectState.Disconnected);
    }
}
