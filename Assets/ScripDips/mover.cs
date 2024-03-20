using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] float speed = 4f;
    [SerializeField] GameObject bullet;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Movers here:
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(speed* Time.deltaTime * Vector3.up);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(speed * Time.deltaTime * Vector3.down);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(speed * Time.deltaTime * Vector3.right);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(speed * Time.deltaTime * Vector3.left);
        }

        //Teleporters here:
        if (gameObject.transform.position.x < -9.4f)
        {
            Debug.Log("Left Teleporter Reporting for Duty"); //making sure that we're getting here
            Vector3 teleport = new Vector3(9.4f, gameObject.transform.position.y, gameObject.transform.position.z);
            gameObject.transform.position = teleport;
        }

        if (gameObject.transform.position.x > 9.4f)
        {
            Debug.Log("Right Teleporter Reporting for Duty"); //making sure that we're getting here
            Vector3 teleport = new Vector3(-9.4f, gameObject.transform.position.y, gameObject.transform.position.z);
            gameObject.transform.position = teleport;
        }

        //Shooter here:
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 shoot = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            Instantiate(bullet, shoot, gameObject.transform.rotation);
        }

    }
}
