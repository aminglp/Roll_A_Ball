using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 dirction = new Vector3(horizontal,0 ,vertical ).normalized;
        _rigidbody.linearVelocity = dirction*_moveSpeed;
    }
}