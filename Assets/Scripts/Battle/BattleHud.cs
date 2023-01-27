using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHud : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] Text levelText;
    [SerializeField] HPBar hpBar;

    Cats _cat;

    public void SetData(Cats cat)
    {
        nameText.text = cat.Base.Name;
        levelText.text = "Lvl" + cat.Level;
        hpBar.SetHP((float)cat.HP / cat.MaxHP);
    }

    public void UpdateHP()
    {
        hpBar.SetHP((float)_cat.HP / _cat.MaxHP);
    }
}
