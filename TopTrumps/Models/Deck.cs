﻿using System.Data.SqlClient;

namespace TopTrumps.Models;
public class Deck
{
    public int Id { get; set; }
    public string Name { get; set; }
    private Queue<Card>? _cards { get; set; }
    private string? _owner { get; set; }
    public Deck(Queue<Card>? cards, string? owner)
    {
        _cards = cards;
        _owner = owner;
    }
    public string? getOwner() { return _owner; }
    public Queue<Card>? getCards() { return _cards; }

    public void getShuffled()
    {
        if (_cards != null)
        {
            Queue<Card> shuffled = new Queue<Card>();

            shuffled = Shuffle();
            foreach (var card in _cards)
            {
                _cards.Enqueue(shuffled.Dequeue());
                _cards.Dequeue();
            }
        }
    }
    private Queue<Card> Shuffle()
    {
        if (_cards != null) {
            List<Card> cards = new List<Card>();
            Queue<Card> shuffled = new Queue<Card>();
            foreach (var card in _cards)
            {
                cards.Add(card);
            }
            int index = 0;
            foreach (var card in _cards)
            {
                Random Jump = new Random();
                index += Jump.Next(cards.Count);
                shuffled.Enqueue(cards[index]);
                cards.RemoveAt(index);
            }
            return shuffled;
        }
        return new Queue<Card>();
    }
    public async void Load(int deckNo)
    {
        await Task.Delay(deckNo);
        Queue<Card> cards = new Queue<Card>();
        for (int i = 0; i < 20; i++)
        {

        }
        
    }
}
