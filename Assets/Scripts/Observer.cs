using UnityEngine;

public class Observer : MonoBehaviour
{
    [SerializeField] private Transform _follower;

    void Update()
    {
        transform.LookAt(_follower.position);
    }
}
