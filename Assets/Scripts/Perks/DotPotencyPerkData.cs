using UnityEngine;

public class DotPotencyPerkData : PerkData
{
    [SerializeField] DoTEffectData _dot;
    [SerializeField] int _value;

    public override PerkTypes Type => PerkTypes.Effect;

    protected override void Apply()
    {
        _dot.Potency += _value;
    }
}