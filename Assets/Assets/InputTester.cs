using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputTester : MonoBehaviour
{
    [SerializeField]
    InputActionAsset _playerInput;
    private InputAction _move;

    void Start()
    {
        _move = _playerInput.FindActionMap("Player").FindAction("Move");
        _move.performed += HandleMove;
    }

    void OnDestroy()
    {
        _move.performed -= HandleMove;
    }

    private void HandleMove(InputAction.CallbackContext callbackContext)
    {
        var moveVector = callbackContext.ReadValue<Vector2>();
        Debug.Log("move invoked: " + moveVector);
    }
}
