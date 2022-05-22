using UnityEngine;

public class EffectActionData : ActionData
{
    [SerializeField] EffectData _effect;

    public EffectData Effect => _effect;
}
