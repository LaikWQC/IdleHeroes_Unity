using System.Collections.Generic;
using UnityEngine;

public class HeroStatisticContainer
{
    public HeroStatisticContainer(HeroStats stats)
    {
        Stats = stats;
    }

    public HeroStats Stats { get; }
    public List<AbilityData> Abilities { get; } = new List<AbilityData>();
}
