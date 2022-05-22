using UnityEngine;

public class DamageActionData : ActionData
{
    [SerializeField] int _potency;

    private void Start()
    {
        Potency = _potency;
    }

    public int Potency { get; set; }
}
