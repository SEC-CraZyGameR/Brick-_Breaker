using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

	private float speed = 150.0f;
	private Rigidbody2D rBoby;
	private int score = 0;
	public Text scoreText, gameEndText;
	public GameObject gameEndPanel;

	void Start () {
		rBoby = GetComponent<Rigidbody2D> ();
		reSpawn ();
	}

	public void reSpawn()
	{
		//transform.position = Vector2.zero;
		rBoby.AddForce (new Vector2 (-speed, speed));
		//rBoby.velocity = Random.insideUnitCircle.normalized * speed;
	}

	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.CompareTag ("brick")) {
			Destroy (col.gameObject);
			addScore ();
		}
		if (col.gameObject.CompareTag ("die")) {
			rBoby.velocity = Vector2.zero;
			gameEndText.text = "You Lose";
			gameEndPanel.SetActive (true);
		}
	}
	public void addScore()
	{
		score++;
		scoreText.text = "Score : " + score.ToString();
		if (score >= 16) {
			gameEndText.text = "You Win";
			rBoby.velocity = Vector2.zero;
			gameEndPanel.SetActive (true);
		}

	}


	public void reStart()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
