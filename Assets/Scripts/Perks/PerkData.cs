using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PerkData : MonoBehaviour
{
    [SerializeField] int _maxLevel = 1;
    [SerializeField] int _startPrice;
    [SerializeField] float _priceInc = 1.3f;
    [SerializeField] PerkOwnerTypes _ownerType = PerkOwnerTypes.All;

    private JobData _job;

    public void Init(JobData job)
    {
        _job = job;
        _statistic = _ownerType == PerkOwnerTypes.All ? _job.Hero.Statistic : _job.Statistic;
        Price = _startPrice;
    }

    public int Level { get; private set; }
    public int MaxLevel => _maxLevel;
    public int Price { get; private set; }
    public abstract PerkTypes Type { get; }

    public bool Buy()
    {
        if (Level >= _maxLevel) return false;
        if (_job.Exp < Price) return false;
        _job.Exp -= Price;
        IncreaseOneLevel();
        return true;
    }

    public void BuyForFree()
    {
        if (Level >= _maxLevel) return;
        IncreaseOneLevel();
    }

    private void IncreaseOneLevel()
    {
        Level++;
        Price = Mathf.CeilToInt(Price * _priceInc);
        Apply();
    }

    protected abstract void Apply();
    protected HeroStatisticContainer _statistic { get; private set; }
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
