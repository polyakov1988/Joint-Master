using UnityEngine;

public class Swing : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _force;
    [SerializeField] private InputHandler _inputHandler;

    private void OnEnable()
    {
        _inputHandler.MoveSwingPressed += OnMoveSwingPressed;
    }

    private void OnDisable()
    {
        _inputHandler.MoveSwingPressed -= OnMoveSwingPressed;
    }

    private void OnMoveSwingPressed()
    {
        _rigidbody.AddForce(transform.forward * _force);
    }
}
