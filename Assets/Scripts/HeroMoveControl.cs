using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class HeroMoveControl : MonoBehaviour
{
    public MoveConfig MoveConfig;

    private Vector3 _direction;
    private Rigidbody2D _body;
    private static readonly float DirectionSpeedBound = Mathf.Sqrt(2) / 2;

    private void Start()
    {
        _body = GetComponent<Rigidbody2D>();
    }
    
    private void Update()
    {
        var mouseAngle = MouseUtils.GetMouseAndTargetAngle(transform.position);
        SetMovementParams();
        LookAtCursor(mouseAngle);
    }

    private void FixedUpdate()
    {
        var currentSpeed = MoveConfig.Speed * Time.deltaTime;

        if (Mathf.Abs(_direction.x) > 0 && Mathf.Abs(_direction.y) > 0)
        {
            currentSpeed *= DirectionSpeedBound;
        }
        _body.velocity = _direction * currentSpeed;
    }

    private void LookAtCursor(float mouseAngle)
    {
        transform.rotation = Quaternion.AngleAxis(mouseAngle, Vector3.forward);
    }

    private void SetMovementParams()
    {
        _direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

}