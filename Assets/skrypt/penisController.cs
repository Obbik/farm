using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class penisController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    float predkosc = 0f;
    float maxSpeed = 50f;

    // Update is called once per frame
    void Update()
    {

        transform.Translate(predkosc * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {


            if (predkosc < maxSpeed)
            {

                predkosc += .1f;
            }
            Debug.Log(predkosc);
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up * Time.deltaTime * 50);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.up * Time.deltaTime * -50);
            }

        }


        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 5);
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up * Time.deltaTime * 50);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.up * Time.deltaTime * -50);
            }

        }

        if (predkosc > 0 && Input.GetKey(KeyCode.W) == false)
            predkosc -= .05f;

    }
}
