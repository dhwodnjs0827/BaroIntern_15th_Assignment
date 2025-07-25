using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : BaseController
{
    private static readonly int OnMove = Animator.StringToHash("OnMove");
    private PlayerInputActions playerInputActions;
    private PlayerInputActions.PlayerActions playerActions;

    protected override void Awake()
    {
        base.Awake();

        playerInputActions = new PlayerInputActions();
        playerActions = playerInputActions.Player;
    }

    private void OnEnable()
    {
        playerInputActions.Enable();

        playerActions.Move.started += MoveStarted;
        playerActions.Move.performed += MovePerformed;
        playerActions.Move.canceled += MoveCanceled;
    }

    private void OnDisable()
    {
        playerInputActions.Disable();

        playerActions.Move.started -= MoveStarted;
        playerActions.Move.performed -= MovePerformed;
        playerActions.Move.canceled -= MoveCanceled;
    }

    private void MoveStarted(InputAction.CallbackContext context)
    {
        spriteController.Animator.SetBool(OnMove, true);
    }
    
    private void MovePerformed(InputAction.CallbackContext context)
    {
        movementDirection = context.ReadValue<Vector2>();
        movementDirection = movementDirection.normalized;
    }

    private void MoveCanceled(InputAction.CallbackContext context)
    {
        movementDirection = Vector2.zero;
        spriteController.Animator.SetBool(OnMove, false);
    }
}