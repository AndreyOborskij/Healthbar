using UnityEngine;
using UnityEngine.UI;

public class SliderFastInfo : MonoBehaviour
{
    [SerializeField] protected Healthbar _healthbar;
    [SerializeField] protected Slider _slider;

    private void OnEnable()
    {
        _healthbar.IncreasedValue += OutputInfo;
        _healthbar.DecreasedValue += OutputInfo;
    }

    private void Start()
    {
        OutputInfo();
    }

    private void OnDisable()
    {
        _healthbar.IncreasedValue -= OutputInfo;
        _healthbar.DecreasedValue -= OutputInfo;
    }

    protected virtual void OutputInfo()
    {
        _slider.value = _healthbar.CurrentHealth / _healthbar.MaxCurrentHealth;
    }
}
