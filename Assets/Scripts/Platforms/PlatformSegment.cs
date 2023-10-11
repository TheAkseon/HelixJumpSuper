using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlatformSegment : MonoBehaviour
{
    private bool _isBounce = false;
    private Rigidbody _rigidbody;

    public bool IsBounce => _isBounce;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Bounce(float explosionForce, Vector3 explosionPosition, float explosionRadius)
    {
        _rigidbody.isKinematic = false;
        _rigidbody.useGravity = true;
        _rigidbody.AddExplosionForce(explosionForce, explosionPosition, explosionRadius);
        _isBounce = true;
        transform.parent = null;
        Destroy(gameObject, 2f);
    }
}
