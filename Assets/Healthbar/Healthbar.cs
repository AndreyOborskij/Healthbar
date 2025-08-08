using System;
using UnityEngine;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Health _health;

    public Action IncreasedValue;
    public Action DecreasedValue;

    public float CurrentHealth { get; private set; }
    public float MaxCurrentHealth { get; private set; }

    private void OnEnable()
    {
        _health.Treatmented += Heal;
        _health.Damaged += TakeDamage;
    }

    private void Awake()
    {
        CurrentHealth = _health.CurrentValue;
        MaxCurrentHealth = _health.MaxValume;
    }

    private void OnDisable()
    {
        _health.Treatmented += Heal;
        _health.Damaged += TakeDamage;
    }

    private void Heal()
    {
        CurrentHealth = _health.CurrentValue;

        IncreasedValue?.Invoke();
    }

    private void TakeDamage()
    {
        CurrentHealth = _health.CurrentValue;

        DecreasedValue?.Invoke();
    }
}