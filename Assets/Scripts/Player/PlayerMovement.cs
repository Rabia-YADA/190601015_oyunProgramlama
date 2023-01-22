using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public VariableJoystick variableJoystick;
    public Animator animatorController;

    public float playerSpeed = 5f;
    public float playerRotationSpeed = 10f;

    void Update()
    {
        Vector2 joystickDirection = variableJoystick.Direction;
        Vector3 vectorMovement = new Vector3(joystickDirection.x, 0, joystickDirection.y);

        vectorMovement = vectorMovement * Time.deltaTime * playerSpeed;
        transform.position += vectorMovement;

        if (vectorMovement.magnitude != 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(vectorMovement, Vector3.up), Time.deltaTime * playerRotationSpeed);
        }

        bool isWalking = joystickDirection.magnitude > 0;
        animatorController.SetBool("isWalking", isWalking);
        animatorController.SetFloat("Speed", joystickDirection.magnitude);

    }
}
