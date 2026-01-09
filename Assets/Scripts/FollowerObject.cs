using UnityEngine;

public class FollowerObject : MonoBehaviour
{
    [SerializeField] private Transform _object;
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 direction = (_object.position - transform.position).normalized;
        transform.Translate(direction * _speed);
    }
}
