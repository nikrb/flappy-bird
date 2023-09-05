using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D my_rigid_body;
    public float flap_strength = 20;
    public LogicScript logic;
    public bool bird_is_alive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && bird_is_alive)
        {
            my_rigid_body.velocity = Vector2.up * flap_strength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        bird_is_alive = false;
    }
}
