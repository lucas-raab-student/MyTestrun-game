using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactsdMovement : MonoBehaviour
{
    CharacterController characterController;
    public float MoveSpeed = 5f;
    private Vector3 MoveDirection;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        MoveDirection.Normalize();
        MoveDirection.y = -1f;
        characterController.Move(MoveDirection*MoveSpeed*Time.deltaTime);
    }
    public void AddMoveInput(float fowardInput, float rightInput)
    {
        Vector3 fowrward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;

        fowrward.y = 0f;
        right.y = 0f;
        fowrward.Normalize();
        right.Normalize();


        MoveDirection = (fowardInput * fowrward) + (rightInput * right);
    }
}
