using UnityEngine;

public class AbilityPerkData : PerkData
{
    [SerializeField] AbilityData _ability;

    public override PerkTypes Type => PerkTypes.Ability;

    protected override void Apply()
    {
        _statistic.Abilities.Add(_ability);
    }
}
