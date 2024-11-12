using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerObjectMovementScript : MonoBehaviour
{
    public Vector3 startPoint;
    // Start is called before the first frame update
    void Start()
    {
        startPoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(-100, 0, 0);
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "EndPoint"){
            gameObject.transform.position = startPoint;
        }
    }
}
