using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Rigidbody2D Mario;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Mario.velocity = Vector2.up * 10;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Mario.velocity = Vector2.right * 2;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Mario.velocity = Vector2.left * 2;
        }
    }
}
