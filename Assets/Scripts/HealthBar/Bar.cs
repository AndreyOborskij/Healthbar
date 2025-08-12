using UnityEngine;

public abstract class Bar : MonoBehaviour
{
    [SerializeField] protected Health Health;

    private void OnEnable()
    {
        Health.Treatmented += OutputInfo;
        Health.Damaged += OutputInfo;
    }

    private void OnDisable()
    {
        Health.Treatmented -= OutputInfo;
        Health.Damaged -= OutputInfo;
    }

    protected abstract void OutputInfo();
}
