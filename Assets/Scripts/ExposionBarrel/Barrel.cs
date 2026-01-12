using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Barrel : MonoBehaviour
{
    [SerializeField] private float _explosionRadios;
    [SerializeField] private float _explosionForce;
    [SerializeField] private ParticleSystem _effect;

    private void OnMouseUpAsButton()
    {
        Explode();
        Instantiate(_effect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    private void Explode()
    {
        foreach (Rigidbody explodableObjest in GetEplodableObjects())
            explodableObjest.AddExplosionForce(_explosionForce, transform.position, _explosionRadios);
    }

    private List<Rigidbody> GetEplodableObjects()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, _explosionRadios);

        List<Rigidbody> barrels = new();

        foreach (Collider hit in hits)
            if (hit.attachedRigidbody != null)
                barrels.Add(hit.attachedRigidbody); 

        return barrels;
    }
}
