using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroData : MonoBehaviour
{
    void Start()
    {
        Jobs = GetComponentsInChildren<JobData>();
        Abilities = GetComponentsInChildren<AbilityData>();
        Actions = GetComponentsInChildren<ActionData>();
        Effects = GetComponentsInChildren<EffectData>();
        Statistic = new HeroStatisticContainer(new HeroStats());

        foreach (var job in Jobs)
            job.Init(this);
    }

    public JobData[] Jobs { get; private set; }
    public AbilityData[] Abilities { get; private set; }
    public ActionData[] Actions { get; private set; }
    public EffectData[] Effects { get; private set; }
    public HeroStatisticContainer Statistic { get; private set; }
}
