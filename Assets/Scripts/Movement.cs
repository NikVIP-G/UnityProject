using UnityEngine;

public class Movement : MonoBehaviour
{
    private const string Horizontal = nameof(Horizontal);
    private const string Vertical = nameof(Vertical);

    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis(Horizontal), 0f, Input.GetAxis(Vertical));

        transform.Translate(direction * _speed * Time.deltaTime);
    }
}
