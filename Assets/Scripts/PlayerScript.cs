using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 50f;
    public float ZRotate = 45f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, speed, 0);
        if(Input.GetKeyDown(KeyCode.Space)){
            speed = -1*speed;
            ZRotate = -1*ZRotate;
            gameObject.transform.rotation = Quaternion.Euler(0, 0, ZRotate);
        }
    }
    private void OnCollisionEnter(Collision other) {
        // if (other.gameObject.tag == "EndPoint"){
        //     gameObject.transform.position = startPoint;
        // }
    }
}
