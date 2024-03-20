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
    enum Directions { left, right, down, up }
    Directions direction;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        direction = Directions.right;

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
            direction = Directions.up;
           
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
            direction = Directions.down;

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
            direction = Directions.right;
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
            direction = Directions.left;
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

        //Shooter here:
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newbullet = Instantiate(rightbullet, gameObject.transform.position + new Vector3 (0f, 0.18f, 0f), gameObject.transform.rotation);
            if (direction == Directions.up)
            {
                newbullet.transform.Rotate(0f, 0f, 90f);
            }
            if (direction == Directions.down)
            {
                newbullet.transform.Rotate(0f, 0f, 270f);
            }
            if (direction == Directions.left)
            {
                newbullet.transform.Rotate(0f, 0f, 180f);
            }
            if (direction == Directions.right)
            {
                newbullet.transform.Rotate(0f, 0f, 0f);
            }

        }

    }
}
