using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CardManager : MonoBehaviour {
    public List<Card> Cards;
	// Update is called once per frame
	void Start () {
        StartCoroutine("GetCards");
        EventManager.ReturnRandomCard += ReturnRandomCard;

    }
    public IEnumerator GetCards()
    {
        Cards.Clear();
        WWW cardsdata = new WWW("http://81.169.177.181/KGDEV4/request_cards.php");
        yield return cardsdata;
        Debug.Log(cardsdata.text);
        if (string.IsNullOrEmpty(cardsdata.error))
        {
            Cards = JsonHelper.getJsonArray<Card>(cardsdata.text).ToList<Card>();
            for (int i = 0; i < 5; i++)
            {
                EventManager.Cards_Randomizer();
            }
        }
        else
        {
            Debug.LogError("ERROR FATAL");
        }
    }

    public Card ReturnRandomCard()
    {
        int r =Random.Range(0, Cards.Count);
        return Cards[r];
    }
}
