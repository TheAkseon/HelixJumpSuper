using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private GameObject _beam;
    [SerializeField] private int _levelCount;

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
