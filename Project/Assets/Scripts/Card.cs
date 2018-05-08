using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card {
    public int ID;
    public string name;
    [TextArea]
    public string description;
    public int energy;
    public int health;
    public int power;
}
