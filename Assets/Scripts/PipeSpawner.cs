using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class PipeSpawner : MonoBehaviour
{
    public static PipeSpawner Instance;

    public Pipe Pipe;
    ObjectPool<Pipe> pool;
    [SerializeField] float minY, maxY;
    [SerializeField] float frequency;
    float timer;

    private void Awake()
    {
        Instance=this;
    }
    private void Start()
    {
        pool = new ObjectPool<Pipe>(Pipe, 10);
    }

    private void Update()
    {
        Vector2 pipePosition = transform.position;

        timer += Time.deltaTime;

        if (timer > frequency)
        {
            timer = 0;
            Pipe nextPipe = pool.GetObject();
            nextPipe.transform.position = new Vector2(11f, Random.Range(minY, maxY));
        }
    }


}
