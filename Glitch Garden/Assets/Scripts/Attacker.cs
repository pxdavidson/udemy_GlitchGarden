using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    // Define variables
    [ Range (0f, 3f)] [SerializeField] float moveSpeed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }

    // Sets the moveSpeed when called.
    public void SetMoveSpeed(float speed)
    {
        moveSpeed = speed;
    }
}
