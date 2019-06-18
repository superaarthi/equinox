using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    public float speed;
    public float jumpMag;
    public AudioSource jumpAudio;
    public AudioSource landAudio;
    private bool canJump = false;
    private Transform trans;
    private Rigidbody rb;
    private Animator animator;

    void Start()
    {
        rb = rigidbody;
        trans = transform;
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        trans.Translate(speed * horizontal * Time.deltaTime, 0, 0);

        if (horizontal > 0)
        {
            trans.localScale = new Vector3(-1, 1, 1);
        }
        else if (horizontal < 0)
        {
            trans.localScale = new Vector3(1, 1, 1);
        }

        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            canJump = false;
            animator.SetBool("Jumping", true);
            jumpAudio.Play();
            rb.AddForce(Vector3.up * jumpMag * 10);
        }

        if (canJump && (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)))
        {
            animator.SetBool("Running", true);
        }
        else
        {
            animator.SetBool("Running", false);
        }

        if (canJump && animator.GetCurrentAnimatorStateInfo(0).IsName("Saltine_Idle") && !animator.GetBool("Blinking") && !animator.GetBool("Jumping") && !animator.GetBool("Running") && Random.value < .005)
        {
            animator.SetBool("Blinking", true);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("JumpFloor"))
        {
            canJump = true;
            animator.SetBool("Jumping", false);
            landAudio.Play();
        }
    }

    void EndBlinking()
    {
        animator.SetBool("Blinking", false);
    }
}
