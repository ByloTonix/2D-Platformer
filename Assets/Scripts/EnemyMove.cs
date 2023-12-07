using UnityEngine;

public class EnemyMove : MonoBehaviour {
    [SerializeField] private float _minX;
    [SerializeField] private float _maxX;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private float _currentSpeed;
    private bool _movingRight = true;
    private Rigidbody2D _rb;

    private void Start() {
        _rb = GetComponent<Rigidbody2D>();
        _currentSpeed = _speed;
    }

    private void FixedUpdate() {
        var movingLeft = transform.position.x < _minX && _currentSpeed < 0 ||
                         transform.position.x < _maxX && _currentSpeed > 0;
        if (movingLeft != _movingRight) {
            _movingRight = movingLeft;
            _currentSpeed = -_currentSpeed;
            transform.eulerAngles = new Vector2(0, _movingRight ? 0 : 180);

            if (_jumpForce > 0) {
                _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            }
        }

        var lerpVelocity = Mathf.Lerp(_rb.velocity.x, _currentSpeed, Time.fixedTime * 10);
        _rb.velocity = new Vector2(lerpVelocity, _rb.velocity.y);
    }
}
