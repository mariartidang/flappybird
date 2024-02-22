using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    bool isStarted;

    public void StartGame()
    {
        if (isStarted)
            return;

        isStarted = true;
        PipeSpawner.Instance.enabled = true;
        PlayerController.Instance.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
    }
}
