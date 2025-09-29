using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseHandler : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

    }

    [ContextMenu("Pause")]
    public void PauseGame()
    {
        SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
    }

    public void UnpauseGame()
    {
        SceneManager.UnloadSceneAsync("Pause");
    }

    public void OnPause(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            // if pause menu is open, pressing pause button means we want to unpause
            if (SceneManager.GetSceneByName("Pause").isLoaded)
            {
                UnpauseGame();
            }
            // if pause menu is not open, pressing pause button means we want to pause
            else
            {
                PauseGame();
            }
        }
    }
}
