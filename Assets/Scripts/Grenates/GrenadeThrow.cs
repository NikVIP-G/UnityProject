using UnityEngine;

public class GrenadeThrow : MonoBehaviour
{
    [SerializeField] private Grenade _grenadePrefab;
    [SerializeField] private float _throwForce;
    [SerializeField] private Transform _throwPoint;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
            Instantiate(_grenadePrefab, _throwPoint.position, _throwPoint.rotation).Throw(_throwPoint.forward * _throwForce);
    }
}
