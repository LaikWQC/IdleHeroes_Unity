using UnityEngine;

public class BuffValuePerkData : PerkData
{
    [SerializeField] BuffEffectData _buff;
    [SerializeField] int _value;

    public override PerkTypes Type => PerkTypes.Effect;

    protected override void Apply()
    {
        _buff.Value += _value;
    }
}