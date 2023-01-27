using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnit : MonoBehaviour
{
    [SerializeField] CatBase _base;
    [SerializeField] int level;
    [SerializeField] bool isPlayerUnit;  

    public Cats Cat { get; set; }
    
    public void Setup()
    {
        Cat = new Cats(_base, level);
        if (isPlayerUnit)
            GetComponent<Image>().sprite = Cat.Base.Frontsprite;
    }
}
