using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private ButtonCounter _button;
    [SerializeField] private float _changedRate = 0.5f;

    private float _currentValue = 0.0f;
    private Coroutine _coroutine;

    public event Action<float> Changed;
    public float CurrentValue => _currentValue;

    private void OnEnable()
    {
        _button.StateButtonChanged += OnClickedButton;
    }

    private void OnDisable()
    {
        _button.StateButtonChanged -= OnClickedButton;
        Stop();
    }

    private IEnumerator CountingRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(_changedRate);
            _currentValue += 1.0f;
            Changed?.Invoke(_currentValue);
        }
    }

    private void OnClickedButton(bool isActive)
    {
        if (isActive)
            _coroutine = StartCoroutine(CountingRoutine());
        else
            Stop();
    }

    private void Stop()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);
    }
}
