using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
        _text.text = "";
        StartCoroutine(CountDown(1));
    }

    private IEnumerator CountDown(float delay, int start = 10)
    {
        WaitForSeconds wait = new WaitForSeconds(delay);

        for (int i = start; i >= 0; i--)
        {
            DisplayCountdown(i);
            yield return wait;
        }
    }

    private void DisplayCountdown(int count)
    { 
        _text.text = count.ToString();
    }
}
