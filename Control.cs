using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{

    public Text TXTHiScore;
    void Start()
    {
        TXTHiScore.text = "HiScore: " + PlayerPrefs.GetInt("HiScore", 0).ToString();
        
    }

    
    void Update()
    {
        
    }

    public void GOTO_Play() {

        SceneManager.LoadScene("GamePlay");        
    }


}
