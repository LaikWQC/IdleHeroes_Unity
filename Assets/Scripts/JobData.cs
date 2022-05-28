using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobData : MonoBehaviour
{
    [SerializeField] HeroStats _stats = new HeroStats();
    [SerializeField] PerkData _startingPerk;
    [SerializeField] PerkDeck _deckPf;

    public void Init(HeroData hero)
    {
        Hero = hero; 
        Statistic = new HeroStatisticContainer(_stats);
        DefaultWeapon = GetComponentInChildren<WeaponData>();
        Perks = GetComponentsInChildren<PerkData>();
        foreach (var perk in Perks) perk.Init(this);
        _startingPerk?.InitialUnlock();
    }

    public HeroData Hero { get; private set; }
    public PerkDeck DeckPf => _deckPf;
    public WeaponData DefaultWeapon { get; private set; }
    public PerkData[] Perks { get; private set; }
    public HeroStatisticContainer Statistic { get; private set; }
    public int Exp { get; set; } = 500;
}
