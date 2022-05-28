using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroData : MonoBehaviour
{
    public void Init()
    {
        Jobs = GetComponentsInChildren<JobData>();
        Abilities = GetComponentsInChildren<AbilityData>();
        Actions = GetComponentsInChildren<ActionData>();
        Effects = GetComponentsInChildren<EffectData>();

        foreach (var job in Jobs)
            job.Init(this);

        CurrentJob = Jobs[0];
    }

    public JobData CurrentJob { get; private set; }
    public JobData[] Jobs { get; private set; }
    public AbilityData[] Abilities { get; private set; }
    public ActionData[] Actions { get; private set; }
    public EffectData[] Effects { get; private set; }
}
