using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonAction : MonoBehaviour
{
    [SerializeField] protected Health Health;
    [SerializeField] private Button _button;

    protected float CountHealth—hange = 10;

    private void Start()
    {
        _button.onClick.AddListener(ChangeValume);
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveListener(ChangeValume);
    }

    protected abstract void ChangeValume();    
}
