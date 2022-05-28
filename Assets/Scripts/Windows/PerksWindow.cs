using UnityEngine;

public class PerksWindow : Window
{
    [SerializeField] Transform _deckFolder;
    private PerkDeck _deck;

    public static PerksWindow Current { get; private set; }

    private void Awake()
    {
        Current = this;
    }

    public void Show(JobData job)
    {
        _deck = Instantiate(job.DeckPf, _deckFolder);
        _deck.Init(job);
        Show();
    }

    public override void Close()
    {
        Destroy(_deck.gameObject);
        base.Close();
    }
}
