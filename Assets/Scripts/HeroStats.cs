using System;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HeroStats
{
    [SerializeField] int _str;
    [SerializeField] int _dex;
    [SerializeField] int _int;

    public int Str 
    {
        get => _str;
        set => _str = value; 
    }
    public int Dex
    {
        get => _dex;
        set => _dex = value;
    }
    public int Int
    {
        get => _int;
        set => _int = value;
    }

    public void IncreaseStat(StatTypes type, int value)
    {
        _statsTypeDict[type](this, value);
    }

    private static Dictionary<StatTypes, Action<HeroStats, int>> _statsTypeDict = new Dictionary<StatTypes, Action<HeroStats, int>>
    {
        { StatTypes.Str, (s,v) => s.Str += v },
        { StatTypes.Dex, (s,v) => s.Dex += v },
        { StatTypes.Int, (s,v) => s.Int += v },
    };
}
public enum StatTypes
{
    Str,
    Dex,
    Int
}
