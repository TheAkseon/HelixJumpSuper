using UnityEngine;

public class SpawnPlatform : Platform
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Ball _ball;

    private void Start()
    {
        SpawnBall();
    }

    private void SpawnBall()
    {
        Instantiate(_ball, _spawnPoint.position, Quaternion.identity);
    }
}
