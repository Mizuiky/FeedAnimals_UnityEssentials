using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 25;
    private float bottomBound = -7;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z > this.topBound)
        {
            Destroy(this.gameObject);
        }
        else if (this.transform.position.z < this.bottomBound)
        {
            Destroy(this.gameObject);
            Debug.Log("Game Over");
        }
    }
}
