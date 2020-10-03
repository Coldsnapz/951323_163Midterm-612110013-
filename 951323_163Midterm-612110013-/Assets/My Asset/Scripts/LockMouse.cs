using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockMouse : MonoBehaviour
{
    CursorLockMode lockMode;
 
    void Awake () {
        lockMode = CursorLockMode.Locked;
        Cursor.lockState = lockMode;
    }
}
