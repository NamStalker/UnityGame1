using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController1 : MonoBehaviour {

	public float speed;

	private Rigidbody rb;
    private int score;

    public Text winText;
    public Text scoreText;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
        score = 0;
        SetScoreText();
        winText.text = "";
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            score++;
            SetScoreText();
        }
    }

    private void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
        if (score >= 16)
        {
            winText.text = "You Win!";
        }
    }

}
