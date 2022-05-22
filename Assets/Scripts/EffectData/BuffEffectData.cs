using UnityEngine;

public class BuffEffectData : EffectData
{
    [SerializeField] BuffTypes _buffType;
    [SerializeField] BuffValues _buffValue;
    [SerializeField] int _value;

    public int Value
    {
        get => _value;
        set => _value = value;
    }
}

public enum BuffTypes
{
    Positive,
    Negative
}
public enum BuffValues
{
    Damage,
    Accuracy,
    DamageReduction,
    AttackSpeed
}
