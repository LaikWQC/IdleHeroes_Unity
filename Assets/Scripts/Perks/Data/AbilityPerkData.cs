using UnityEngine;

public class AbilityPerkData : PerkData
{
    [SerializeField] AbilityData _ability;

    public override PerkTypes Type => PerkTypes.Ability;

    protected override void Apply(HeroStatisticContainer statistic)
    {
        statistic.Abilities.Add(_ability);
    }

    protected override void Cancel(HeroStatisticContainer statistic)
    {
        statistic.Abilities.Remove(_ability);
    }
}
