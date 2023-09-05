using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawn_rate = 3;
    private float timer = 0;
    public float height_offset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawn_rate)
        {
            timer += Time.deltaTime;
        } else
        {
            spawnPipe();
            timer = 0;
        }
    }
    private void spawnPipe()
    {
        float lowest_point = transform.position.y - height_offset;
        float highest_point = transform.position.y + height_offset;
        Instantiate(pipe, new Vector3(transform.position.x, 
            Random.Range(lowest_point, highest_point), transform.position.z), transform.rotation);
    }
}
