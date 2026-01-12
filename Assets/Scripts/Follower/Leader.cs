using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leader : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private float _speed;

    private int _currentPoint = 0;
    
    private void Update()
    {
        if (transform.position == _points[_currentPoint].position)
            _currentPoint = (_currentPoint + 1) % _points.Length;
        
        transform.position = Vector3.MoveTowards(transform.position, _points[_currentPoint].position, _speed * Time.deltaTime);
    }
}
