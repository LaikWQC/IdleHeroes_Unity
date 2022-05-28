using System.Collections;
using UnityEngine;

public class Room : MonoBehaviour
{
    private HeroData _hero;

    public void Init(HeroData hero)
    {
        _hero = hero;
    }

    public void ShowStats()
    {
        PerksWindow.Current.Show(_hero.CurrentJob);
    }
}
