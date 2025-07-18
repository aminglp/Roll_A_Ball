using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        // float horizontal = Input.GetAxis("Horizontal");
        // float vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        move();
    }

    private void move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 dirction = new Vector3(horizontal,0 ,vertical );
        _rigidbody.angularVelocity = dirction*_moveSpeed;
    }
}