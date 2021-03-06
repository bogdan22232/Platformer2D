﻿using Assets.Scripts.Interfaces;
using UnityEngine;

public abstract class EnemyMob : MonoBehaviour, IEnemy
{
    public float Damage;
    public float Health;
    public float AttackSpeed = 2;
    public float MoveSpeed = 1f;
    public float RangeVision = 4;
    public float RangePotrol = 100f;
    public bool Potrol = true;

    private float _StartMoveSpeed;

    void Start()
    {
        _StartMoveSpeed = MoveSpeed;
    }

    public abstract void MoveToPosition(Vector3 position);
    public abstract void MoveToPosition(float xPosition);
    public abstract void LookRight();
    public abstract void StartFight();
    public abstract void StopFight();
    public abstract void LookLeft();


    public virtual void Kill()
    {
        Destroy(gameObject);
    }

    public void StartPause()
    {
        StartStand();
        StopFight();
    }

    public void StopPause()
    {
        StopStand();
        StartFight();
    }

    public virtual void Attack(PlayerController player)
    {
        player.TakeDamage(Damage);
    }

    public virtual void TakeDamage(float damage)
    {
        Health -= damage;
    }

    public virtual void StartStand()
    {
        MoveSpeed = 0;
    }

    public virtual void StopStand()
    {
        MoveSpeed = _StartMoveSpeed;
    }
}