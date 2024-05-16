using UnityEngine;

public class Spring : MonoBehaviour
{
    [SerializeField] private SpringJoint _springJoint;
    [SerializeField] private InputHandler _inputHandler;
    [SerializeField] private float _reloadSpringValue;
    [SerializeField] private float _runSpringValue;

    private void OnEnable()
    {
        _inputHandler.RunCatapultPressed += OnRunCatapultPressed;
        _inputHandler.ReloadCatapultPressed += OnReloadCatapultPressed;
    }

    private void OnDisable()
    {
        _inputHandler.RunCatapultPressed += OnRunCatapultPressed;
        _inputHandler.ReloadCatapultPressed += OnReloadCatapultPressed;
    }

    private void OnRunCatapultPressed()
    {
        _springJoint.spring = _runSpringValue;
    }
    
    private void OnReloadCatapultPressed()
    {
        _springJoint.spring = _reloadSpringValue;
    }
}
