using UnityEngine;

public class ActionPotencyPerkData : PerkData
{
    [SerializeField] DamageActionData _action;
    [SerializeField] int _potency;

    public override PerkTypes Type => PerkTypes.Action;

    protected override void Apply(HeroStatisticContainer statistic)
    {
        _action.Potency += _potency;
    }

    protected override void Cancel(HeroStatisticContainer statistic)
    {
        _action.Potency -= _potency;
    }
}
