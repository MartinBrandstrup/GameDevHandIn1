using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RespawnButton : MonoBehaviour
{

    public Button RespawnB;

    // Start is called before the first frame update
    void Start()
    {
        Button RespawnBtn = RespawnB.GetComponent<Button>();
        RespawnBtn.onClick.AddListener(RespawnOnClick);
    }

    void RespawnOnClick()
    {
        Debug.Log ("You have clicked the respawn button!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Score.scoreString = "Score = ";
    }
}
