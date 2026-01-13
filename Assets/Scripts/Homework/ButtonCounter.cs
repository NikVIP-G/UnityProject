using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCounter : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private TextMeshProUGUI _text;
    
    private bool _isActive = false;
    private string _textBeforeStart = "Старт";
    private string _textBeforeStop = "Стоп";

    public event Action<bool> StateButtonChanged;

    private void Awake()
    {
        _text.text = _textBeforeStart;
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClicked);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        _isActive = !_isActive;
        _text.text = _isActive ? _textBeforeStop : _textBeforeStart;
        StateButtonChanged?.Invoke(_isActive);
    } 
}
