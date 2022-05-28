using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PerkDeck : MonoBehaviour
{
    private PerkDisplay[] _perks;

    public void Init(JobData job)
    {
        _perks = GetComponentsInChildren<PerkDisplay>();
        for (int i = 0; i < job.Perks.Length; i++)
            _perks[i].Init(this, job.Perks[i]);
    }

    public void SomethingChanged()
    {
        foreach (var perk in _perks)
            perk.Refresh();
    }
}
