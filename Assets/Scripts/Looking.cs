using UnityEngine;

public class Looking : MonoBehaviour
{
    private readonly string MouseX = "Mouse X";
    private readonly string MouseY = "Mouse Y";

    [SerializeField] private float _speed;
    [SerializeField] private Transform _camera;
    [SerializeField] private Transform _body;

    private void Update()
    {
        _camera.Rotate(-Input.GetAxis(MouseY) * _speed * Time.deltaTime * Vector3.right);
        _body.Rotate(Input.GetAxis(MouseX) * _speed * Time.deltaTime * Vector3.up);
    }
}
