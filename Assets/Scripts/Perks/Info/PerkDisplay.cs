using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerkDisplay : MonoBehaviour
{
    [SerializeField] Text _levelText;
    [SerializeField] GameObject _canBuyObj;

    private PerkDeck _owner;
    private PerkData _perk;

    public void Init(PerkDeck owner, PerkData perk)
    {
        _owner = owner;
        _perk = perk;
        DisplayLevel();
        DisplayCanBuy();
        SetVisibility();
    }

    public void Buy()
    {
        if (!_perk.Buy()) return;
        DisplayLevel();
        _owner.SomethingChanged();
    }

    public void Refresh()
    {
        DisplayCanBuy();
        SetVisibility();
    }

    private void DisplayLevel()
    {
        _levelText.text = $"{_perk.Level}/{_perk.MaxLevel}";
    }
    private void DisplayCanBuy()
    {
        _canBuyObj.SetActive(_perk.CanBuy);
    }
    private void SetVisibility()
    {
        gameObject.SetActive(_perk.IsVisible);
    }
}
