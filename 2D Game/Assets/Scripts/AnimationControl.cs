using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    //declaring animator for character
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            animator.SetTrigger ("jump");
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            animator.SetBool("run", true);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("run", false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("crouch", true);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.SetBool("crouch", false);
        }
    }
}
