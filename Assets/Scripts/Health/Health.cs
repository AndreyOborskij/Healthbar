using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float _maxValue = 100;
    private float _minValue = 0;

    public float CurrentValue { get; private set; }
    public float MaxValume => _maxValue;

    public event Action Damaged;
    public event Action Died;
    public event Action Treatmented;

    private void Awake()
    {
        CurrentValue = _maxValue;
    }

    public void DecreaseValue(float damage)
    {
        if (damage < 0)
        {
            return;
        }

        CurrentValue = Mathf.Max(CurrentValue - damage, _minValue);        

        Damaged?.Invoke();

        if (CurrentValue <= _minValue)
        {
            Died?.Invoke();
        }
    }

    public void IncreaseValue(float heal)
    {
        if (heal < 0)
        {
            return;
        }

        CurrentValue = Mathf.Min(CurrentValue + heal, _maxValue);

        Treatmented?.Invoke();
    }
}