using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EffectData : MonoBehaviour
{
    [SerializeField] EffectDuration _effectDuration = new EffectDuration();
}

[System.Serializable]
public class EffectDuration
{
    [SerializeField] EffectDurationTypes _type = EffectDurationTypes.Tick;
    [SerializeField] int _value;
}

public enum EffectDurationTypes
{
    Tick,
    Attack,
    Defence
}
