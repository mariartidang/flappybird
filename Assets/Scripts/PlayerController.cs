using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;

    [SerializeField] private float BirdJump=1.5f;
    [SerializeField] Vector3 onJumpAngles;
    [SerializeField] float returnSpeed;
    Transform visual;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Instance = this;
        visual = transform.GetChild(0);
    }
    public void OnJump()
    {
        rb.velocity = Vector2.up*BirdJump;
        visual.rotation = Quaternion.Euler(onJumpAngles);
    }

    private void Update()
    {
        visual.rotation = Quaternion.Lerp(visual.rotation, Quaternion.Euler(Vector3.zero), returnSpeed * Time.deltaTime);
    }
}