﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatisticsUI : MonoBehaviour
{
    #region Singleton

    public static StatisticsUI Instance;

    void Awake()
    {
        if (Instance != null)
        {
            Debug.LogWarning("More than one intence of StatisticsUI found!");
            return;
        }
        Instance = this;
    }

    #endregion

    public Text HP;
    public Text MP;
    public Text DPS;
    public Text Number;
    public Text Spell;
    public Text Potions;

    void Start()
    {
        HP.text = "HP : " + 0 + " / " + 0;
        MP.text = "MP : " + 0 + " / " + 0;
        DPS.text = "Shot DPS / Speed: " + 0 + " / " + 0;
        Number.text = "Number of Shots : " + 0;
        Spell.text = "Spell DMG / Cost : " + 0 + " / " + 0;
        Potions.text = "HP potions : " + 0;
    }

    public void HPupdate(float t, float tMax)
    {
        HP.text = "HP : " + t.ToString("N0") + " / " + tMax.ToString("N0");
    }

    public void MPUpdate(float t, float tMax)
    {
        MP.text = "MP : " + t.ToString("N0") + " / " + tMax.ToString("N0");
    }

    public void DPSupdate(float t1, float t2, int t3)
    {
        DPS.text = "Shot DPS / Speed : " + t1.ToString("N2") + " / " + t2.ToString("N0");
        Number.text = "Number of Shots : " + t3;
    }

    public void SpellUpdate(float t1, float t2)
    {
        Spell.text = "Spell DMG / Cost : " + t1.ToString("N2") + " / " + t2.ToString("N0");
    }

    public void PotionsUpdate(int t)
    {

        Potions.text = "HP potions : " + t;
    }
}