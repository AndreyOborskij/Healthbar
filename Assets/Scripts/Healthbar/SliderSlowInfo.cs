using System.Collections;
using UnityEngine;

public class SliderSlowInfo : SliderFastInfo
{
    private Coroutine _coroutine;
    private float _startPosition;
    private float _smoothSpeed = 5f;

    private void Update()
    {
        OutputInfo();
    }

    protected override void OutputInfo()
    {
        float targetValue = _healthbar.CurrentHealth / _healthbar.MaxCurrentHealth;

        if( _coroutine != null )
        {
            StopCoroutine(_coroutine);
        }

        _coroutine = StartCoroutine(PaintVolume(targetValue));
    }

    private IEnumerator PaintVolume(float targetValue)
    {
        _startPosition = _slider.value; 

        while (_slider.value != targetValue)
        {
            _slider.value = Mathf.Lerp(_startPosition, targetValue, _smoothSpeed * Time.deltaTime);
            yield return null; 
        }

        _slider.value = targetValue;
        _coroutine = null;
    }
}
