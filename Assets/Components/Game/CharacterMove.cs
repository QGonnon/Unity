using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public int moveSpeed = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.Space)) { Debug.Log("Space pressed"); }
        //Debug.Log(Input.GetAxis("Horizontal"));
        Vector3 movementV = transform.forward * Input.GetAxis("Vertical");
        Vector3 movementH = transform.right * Input.GetAxis("Horizontal");
        transform.position += (movementV+ movementH) * moveSpeed * Time.deltaTime;
        
    }
}
