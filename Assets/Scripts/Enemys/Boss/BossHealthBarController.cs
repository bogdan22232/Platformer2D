﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBarController : MonoBehaviour
{
    public AbstructBoss Boss;
    public Image BackGrondImage;
    public Image FrontImage;

    private float _maxHealth;
    private float _nowHealth;
    private float _minHealth = 0;

    private void Start()
    {
        _maxHealth = Boss.Health;
        _nowHealth = Boss.Health;
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        if (Boss.Health <= _minHealth)
        {
            BackGrondImage.fillAmount = 0;
            return;
        }

        if (_nowHealth != Boss.Health)
        {
            _nowHealth = Boss.Health;
            BackGrondImage.fillAmount = _nowHealth / 100;
        }
    }
}