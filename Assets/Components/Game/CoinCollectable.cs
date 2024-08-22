using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectable : MonoBehaviour
{
    public float RotationSpeed = 120.0f;
    private float elpasedTime = 0.0f;
    private float FloatingSpeed = 1.0f;
    private float duration = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        elpasedTime += dt;
        if (elpasedTime > duration) { FloatingSpeed *= -1; elpasedTime -= duration; }
        Vector3 newPos = new Vector3(0, dt* FloatingSpeed, 0);
        transform.position += newPos;
        transform.Rotate(0, 0, RotationSpeed * dt);

    }

    void OnTriggerEnter(Collider other)
    {

        Debug.Log(other.name);
        if (other.name == "Player") {
            Destroy(this.gameObject);
        }
    }
}
