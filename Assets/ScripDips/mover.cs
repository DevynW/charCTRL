using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] float speed = 4f;
    [SerializeField] GameObject upbullet;
    [SerializeField] GameObject downbullet;
    [SerializeField] GameObject rightbullet;
    [SerializeField] GameObject leftbullet;
    Animator animator;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movers here:
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("up", Input.GetKey(KeyCode.UpArrow));
            sr.flipX = false;
            gameObject.transform.Translate(speed* Time.deltaTime * Vector3.up);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector3 shoot = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
                Instantiate(upbullet, shoot, upbullet.transform.rotation);
            }
        }
        else
        {
            animator.SetBool("up", false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("down", Input.GetKey(KeyCode.DownArrow));
            sr.flipX = false;
            gameObject.transform.Translate(speed * Time.deltaTime * Vector3.down);

            //Shooter here:
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector3 shoot = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
                Instantiate(downbullet, shoot, downbullet.transform.rotation);
            }
        }
        else
        {
            animator.SetBool("down", false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("right", Input.GetKey(KeyCode.RightArrow));
            sr.flipX = false;
            gameObject.transform.Translate(speed * Time.deltaTime * Vector3.right);

            //Shooter here:
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector3 shoot = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
                Instantiate(rightbullet, shoot, rightbullet.transform.rotation);
            }
        }
        else
        {
            animator.SetBool("right", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("left", Input.GetKey(KeyCode.LeftArrow));
            sr.flipX = true;
            gameObject.transform.Translate(speed * Time.deltaTime * Vector3.left);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector3 shoot = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
                Instantiate(leftbullet, shoot, leftbullet.transform.rotation);
            }
        }
        else
        {
            animator.SetBool("left", false);
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

        

    }
}
