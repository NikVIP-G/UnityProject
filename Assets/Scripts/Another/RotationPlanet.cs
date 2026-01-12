using UnityEngine;

public class RotationPlanet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _centerRotation;

    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - _centerRotation.position;
    }

    private void Update()
    {
        transform.position = _centerRotation.position + _offset;
        transform.RotateAround(_centerRotation.position, Vector3.up, _speed * Time.deltaTime);
        transform.Rotate(Vector3.up * _speed * Time.deltaTime);
        _offset = transform.position - _centerRotation.position;
    }
}
