using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActionData : MonoBehaviour
{
    [SerializeField] ActionTargetTypes _targetType = ActionTargetTypes.Target;

    public ActionTargetTypes TargetType => _targetType;
}
public enum ActionTargetTypes
{
    Target,
    Enemy,
    Self
}
