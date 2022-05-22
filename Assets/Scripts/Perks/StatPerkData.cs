using UnityEngine;

public class StatPerkData : PerkData
{
    [SerializeField] StatTypes _stat;
    [SerializeField] int _value;

    public override PerkTypes Type => PerkTypes.Stat;

    protected override void Apply()
    {
        _statistic.Stats.IncreaseStat(_stat, _value);
    }
}
