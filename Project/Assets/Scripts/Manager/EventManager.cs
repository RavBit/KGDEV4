using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EventManager : MonoBehaviour {
    public delegate void ChangeUI(ConnectState CS);
    public static event ChangeUI UpdateHubUI;
    public delegate void RandomizeCards();
    public static event RandomizeCards CardsRandomizer;
    public delegate Card RandomCardReturn();
    public static event RandomCardReturn ReturnRandomCard;

    public static void Update_HubUI(ConnectState CS)
    {
        UpdateHubUI(CS);
    }
    public static void Cards_Randomizer()
    {
        CardsRandomizer();
    }
    public static Card Return_RandomCard()
    {
        return ReturnRandomCard();
    }
}
