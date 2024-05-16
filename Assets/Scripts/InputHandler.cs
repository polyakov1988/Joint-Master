using System;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public event Action MoveSwingPressed;
    public event Action RunCatapultPressed;
    public event Action ReloadCatapultPressed;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveSwingPressed?.Invoke();
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RunCatapultPressed?.Invoke();
        }
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ReloadCatapultPressed?.Invoke();
        }
    }
}
