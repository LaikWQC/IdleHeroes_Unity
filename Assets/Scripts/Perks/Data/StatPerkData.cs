using UnityEngine;

public class StatPerkData : PerkData
{
    [SerializeField] StatTypes _stat;
    [SerializeField] int _value;

    public override PerkTypes Type => PerkTypes.Stat;

    protected override void Apply(HeroStatisticContainer statistic)
    {
        statistic.Stats.IncreaseStat(_stat, _value);
    }

    protected override void Cancel(HeroStatisticContainer statistic)
    {
        statistic.Stats.IncreaseStat(_stat, -_value);
    }
}
