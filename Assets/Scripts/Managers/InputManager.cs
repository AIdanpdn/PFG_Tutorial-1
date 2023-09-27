using UnityEditor;
using UnityEngine;

public static class InputManager
{
    private static Controls _controls;
    private static Character _character;
    public static void Init(Character myPlayer)
    {
        _controls = new Controls();

        _controls.Game.Movement.performed += ctx =>
        {
            myPlayer.SetMovementDirection(ctx.ReadValue<Vector3>());
        };

        _controls.Game.Spawn.performed += sergio =>
        {
            myPlayer.SpawnObject();
            Debug.Log("Spawned");
        };

        _controls.Permanent.Enable();
    }

    public static void GameMode()
    {
        _controls.Game.Enable();
        _controls.UI.Disable();
    }

    public static void UIMode()
    {
        _controls.Game.Disable();
        _controls.UI.Enable();
    }

   

}
