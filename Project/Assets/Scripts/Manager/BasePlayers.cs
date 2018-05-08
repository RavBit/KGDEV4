using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Interface with an AdjustHealth that has to be added to the Base_Trainer class
public class BasePlayers : MonoBehaviour
{
    [SerializeField]
    protected int amount_cards = 3;
    [SerializeField]
    protected List<Card> cards;
    [SerializeField]
    protected List<Card> playedCards;

    [Header("Objects")]
    public GameObject CardContainer;

    private void Start()
    {
        EventManager.CardsRandomizer += GetRandomCards;
    }
    public void AssignCard(Card _card)
    {
        cards.Add(_card);
    }
    public void GetRandomCards()
    {
        cards.Add(EventManager.Return_RandomCard());

    }

    public virtual void Test()
    {
        Debug.Log("Test");
    }
    public virtual void Test2()
    {

    }
}

public interface IBasePlayers
{

    void GetRandomCards(List<Card> _cards);
}