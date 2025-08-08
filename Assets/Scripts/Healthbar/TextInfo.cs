using TMPro;
using UnityEngine;

public class TextInfo : MonoBehaviour
{
    [SerializeField] private Healthbar _healthbar;
    [SerializeField] private TextMeshProUGUI _text;

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

    private void OutputInfo()
    {
        _text.text = $"{_healthbar.CurrentHealth} / {_healthbar.MaxCurrentHealth}";
    }
}