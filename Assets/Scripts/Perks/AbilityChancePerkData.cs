using UnityEngine;

public class AbilityChancePerkData : PerkData
{
    [SerializeField] AbilityData _ability;
    [SerializeField] int _value;

    public override PerkTypes Type => PerkTypes.Ability;

    protected override void Apply()
    {
        _ability.AbilityChance.Chance += _value;
    }
}