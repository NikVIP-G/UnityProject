using UnityEngine;

abstract public class Follower : MonoBehaviour
{
    [SerializeField] private Transform _leader;
    [SerializeField] private float _speed;

    protected float Speed => _speed * Time.deltaTime;
    protected Vector3 Target => _leader.position;

    protected void Update()
    {
        Move();
    }
    abstract protected void Move();
}
