using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private GameObject _beam;
    [SerializeField] private int _levelCount;
    [SerializeField] private SpawnPlatform _spawnPlatform;
    [SerializeField] private Platform[] _platforms;
    [SerializeField] private FinishPlatform _finishPlatform;

    private void Start()
    {
        Build();
    }

    private void Build()
    {
        GameObject beam = Instantiate(_beam, transform.position, Quaternion.identity, transform);
        beam.transform.localScale = new Vector3(1f, _levelCount / 2f, 1f);
    }
}
