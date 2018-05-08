using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum ConnectState
{
    Connected,
    Disconnected
}
public class HubManager : MonoBehaviour {
    [Header("System Objects")]
    public Text MainText;
    public GameObject ConnectedScreen;
    public GameObject DisconnectedScreen;
	// Use this for initialization
	void Start () {
        UpdateSystem();
        EventManager.UpdateHubUI += UpdateNetworkUI;
    }
#region UI SYSTEM
    public void UpdateSystem()
    {
        MainText.text = "Welcome " + AppManager.instance.User.username;
    }
    void UpdateNetworkUI(ConnectState CS)
    {
        switch(CS)
        {
            case (ConnectState.Connected):
                DisconnectedScreen.SetActive(false);
                ConnectedScreen.SetActive(true);
                break;
            case (ConnectState.Disconnected):
                ConnectedScreen.SetActive(false);
                DisconnectedScreen.SetActive(true);
                break;
        }
    }
    public void SwitchSingle()
    {
        SceneManager.LoadScene("Single");
    }
}



#endregion