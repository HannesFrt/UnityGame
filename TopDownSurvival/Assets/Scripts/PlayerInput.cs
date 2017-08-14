using UnityEngine;

[RequireComponent(typeof(PlayerMove))]
public class PlayerInput : MonoBehaviour {

    public float moveSpeed = 1f;
    PlayerMove moveController = null;

    private void Start()
    {
        if(moveController == null)
        {
            moveController = GetComponent<PlayerMove>();
        }
    }

    void Update () {
        moveInput();
    }

    private void moveInput()
    {
        float _moveX = Input.GetAxisRaw("Horizontal");
        float _moveZ = Input.GetAxisRaw("Vertical");

        Vector3 _horMove = Vector3.right * _moveX;
        Vector3 _verMove = Vector3.forward * _moveZ;

        Vector3 _movement = (_horMove + _verMove).normalized * moveSpeed;

        moveController.setMovement(_movement);
    }
}
