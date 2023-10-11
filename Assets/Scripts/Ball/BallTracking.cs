using UnityEngine;

public class BallTracking : MonoBehaviour
{
    [SerializeField] private float _cameraOffsetY;
    [SerializeField] private float _cameraDistanceMultiplier;

    private Ball _ball;
    private Beam _beam;
    private Vector3 _cameraPosition;
    private Vector3 _ballPosition;
    private Vector3 _minBallPosition;

    private void Start()
    {
        _ball = FindObjectOfType<Ball>();
        _beam = FindObjectOfType<Beam>();
        _ballPosition = _ball.transform.position;
        _minBallPosition = _ball.transform.position;
        Track();
    }

    private void Update()
    {
        _ballPosition = _ball.transform.position;

        if (_ballPosition.y < _minBallPosition.y)
        {
            Track();
            _minBallPosition = _ballPosition;
        }
    }

    private void Track()
    {
        Vector3 beamPosition = _beam.transform.position;
        beamPosition.y = _ball.transform.position.y;
        _cameraPosition = _ball.transform.position;
        Vector3 direction = (beamPosition - _ball.transform.position).normalized;
        _cameraPosition -= direction * _cameraDistanceMultiplier;
        _cameraPosition.y += _cameraOffsetY;
        transform.position = _cameraPosition;
        transform.LookAt(_ball.transform);
    }
}
