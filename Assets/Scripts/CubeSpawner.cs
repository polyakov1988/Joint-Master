using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private Cube _prefab;
    [SerializeField] private CollisionHandler _collisionHandler;

    private void OnEnable()
    {
        _collisionHandler.CatapultReady += Spawn;
    }

    private void OnDisable()
    {
        _collisionHandler.CatapultReady -= Spawn;
    }

    private void Spawn()
    {
        Instantiate(_prefab);
    }
}
