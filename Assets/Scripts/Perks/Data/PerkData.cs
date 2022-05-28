using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PerkData : MonoBehaviour
{
    [SerializeField] int _maxLevel = 1;
    [SerializeField] int _startPrice;
    [SerializeField] float _priceInc = 1.3f;
    [SerializeField] PerkOwnerTypes _ownerType = PerkOwnerTypes.All;
    [SerializeField] PerkData[] _unlockThisPerks;

    private JobData _job;

    public void Init(JobData job)
    {
        _job = job;
        Price = _startPrice;
    }

    public int Level { get; private set; }
    public int MaxLevel => _maxLevel;
    public bool IsVisible { get; private set; } = false;
    public bool CanBuy => Level < _maxLevel && _job.Exp >= Price;
    public int Price { get; private set; }
    public abstract PerkTypes Type { get; }

    public bool Buy()
    {
        if (!CanBuy) return false;
        _job.Exp -= Price;
        IncreaseOneLevel();
        return true;
    }

    public void InitialUnlock()
    {
        IsVisible = true;
        IncreaseOneLevel();
    }

    private void IncreaseOneLevel()
    {
        if (Level == 0)
            foreach (var perk in _unlockThisPerks)
                perk.IsVisible = true;

        Level++;
        Price = Mathf.CeilToInt(Price * _priceInc);
        Apply();
    }

    private void Apply()
    {
        switch(_ownerType)
        {
            case PerkOwnerTypes.All:
                foreach(var job in _job.Hero.Jobs)
                    Apply(job.Statistic);
                break;
            case PerkOwnerTypes.Self:
                Apply(_job.Statistic);
                break;
        }
    }
    protected abstract void Apply(HeroStatisticContainer statistic);
    protected abstract void Cancel(HeroStatisticContainer statistic);
}
public enum PerkOwnerTypes
{
    Self,
    All
}
public enum PerkTypes
{
    Ability,
    Action,
    Effect,
    Stat,
    Passive
}
