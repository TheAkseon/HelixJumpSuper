using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private GameObject _beam;
    [SerializeField] private int _levelCount;
    [SerializeField] private SpawnPlatform _spawnPlatform;
    [SerializeField] private Platform[] _platforms;
    [SerializeField] private FinishPlatform _finishPlatform;
    [SerializeField] private float _additionalScale = 3f;

    private float _additionalScaleForStartAndFinishPlatform = 0.5f;

    public float BeamScaleY => _levelCount / 2f + _additionalScaleForStartAndFinishPlatform + _additionalScale / 2f;

    private void Start()
    {
        Build();
    }

    private void Build()
    {
        GameObject beam = Instantiate(_beam, transform.position, Quaternion.identity, transform);
        beam.transform.localScale = new Vector3(1f, BeamScaleY, 1f);

        Vector3 spawnPosition = beam.transform.position;
        spawnPosition.y += beam.transform.localScale.y - _additionalScale;

        SpawnPlatform(_spawnPlatform, ref spawnPosition, beam.transform);

        for (int i = 0; i < _levelCount; i++)
        {
            SpawnPlatform(_platforms[Random.Range(0, _platforms.Length)], ref spawnPosition, beam.transform);
        }

        SpawnPlatform(_finishPlatform, ref spawnPosition, beam.transform);
    }

    private void SpawnPlatform(Platform platform, ref Vector3 spawnPosition, Transform parent)
    {
        Instantiate(platform, spawnPosition, Quaternion.Euler(0, Random.Range(0, 360), 0), parent);
        spawnPosition.y -= 1;
    }
}
