using UnityEngine;

public class BuffValuePerkData : PerkData
{
    [SerializeField] BuffEffectData _buff;
    [SerializeField] int _value;

    public override PerkTypes Type => PerkTypes.Effect;

    protected override void Apply(HeroStatisticContainer statistic)
    {
        _buff.Value += _value;
    }

    protected override void Cancel(HeroStatisticContainer statistic)
    {
        _buff.Value -= _value;
    }
}