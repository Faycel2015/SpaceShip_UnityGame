using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public static int Score = 0;
    public float speed = 5.5f;

    public Text TXTScore;
    public GameObject Fire;

    public GameObject GameOver;

    public AudioSource SoundFire;

    void Start()
    {
        Score = 0;
    }

    
    void Update()
    {
        TXTScore.text = Score.ToString();

        if (Input.GetKey(KeyCode.LeftArrow)  && transform.position.x > -2f) {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

        }

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 2f)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);

        }

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            SoundFire.Play();
            Instantiate(Fire, transform.position, transform.rotation);
        }

    }

    void OnTriggerEnter2D(Collider2D col) {

        if (col.tag == "Enemy") {


            if (Score > PlayerPrefs.GetInt("HiScore")) {
                PlayerPrefs.SetInt("HiScore", Score);
            }

            GameOver.gameObject.SetActive(true);
            Time.timeScale = 0;

        }
    
    }

   public void ResetGame() {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
