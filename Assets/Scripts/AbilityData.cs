using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityData : MonoBehaviour
{
    [SerializeField] float _cooldown = 1.5f;
    [SerializeField] AbilityTargetTypes _targetType = AbilityTargetTypes.Enemy;
    [SerializeField] AbilityChance _abilityChance = new AbilityChance();
    [SerializeField] ActionData[] _actions;

    public float Cooldown => _cooldown;
    public AbilityTargetTypes TargetType => _targetType;
    public ActionData[] Actions => _actions;
    public AbilityChance AbilityChance => _abilityChance;
}

public enum AbilityTargetTypes
{
    Enemy,
    Self
}

[System.Serializable]
public class AbilityChance
{
    [SerializeField] AbilityChanceTypes _type = AbilityChanceTypes.Normal;
    [SerializeField] int _chance = 5;

    public AbilityChanceTypes Type => _type;
    public int Chance
    {
        get => _chance;
        set => _chance = value;
    }
}

public enum AbilityChanceTypes
{
    Core,
    Normal,
    Hight
}
