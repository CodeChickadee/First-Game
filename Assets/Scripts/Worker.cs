using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{
    [SerializeField]
    private Animator playerAnimator;

    private SpriteRenderer _spriteRenderer;
	// Use this for initialization
	void Start ()
	{
	    playerAnimator = GetComponent<Animator>();
	    _spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

		KeyBoardMovement();
	    HandleAnimation();

	}

    void KeyBoardMovement()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
            _spriteRenderer.flipX = true;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
            _spriteRenderer.flipX = false;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.y++;
            this.transform.position = position;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.y--;
            this.transform.position = position;
        }
    }

    public void HandleAnimation()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerAnimator.SetBool("Walk", true);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerAnimator.SetBool("Walk", true);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerAnimator.SetBool("Walk", true);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerAnimator.SetBool("Walk", true);
        }
        else
        {
            playerAnimator.SetBool("Walk", false);
        }
    }
}
