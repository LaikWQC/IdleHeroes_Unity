using UnityEngine;

public class DoTEffectData : EffectData
{
    [SerializeField] int _potency;

    public int Potency
    {
        get => _potency;
        set => _potency = value;
    }
}
