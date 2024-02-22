using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] float speed;
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        Vector2 objectPosition = transform.position;
        if (objectPosition.x < -12)
            gameObject.SetActive(false);
    }

 

}
