using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Repeater : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField, Min(2)] private float _delay = 2.0f;
    [SerializeField, Min(1)] private float _repeatRate = 2.0f;

    private void Start()
    {
        _text.text = "0";
        InvokeRepeating(nameof(ChangedTimer), _delay, _repeatRate);
    }

    private void ChangedTimer()
    {
        _text.text = Time.time.ToString();
    }
}
