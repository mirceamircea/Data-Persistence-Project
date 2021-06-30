using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    public TMP_InputField playerNameButton;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Instance.bestScore > 0)
        {
            bestScoreText.SetText("Best Score : " + GameManager.Instance.bestScorePlayerName + " : " + GameManager.Instance.bestScore);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
        GameManager.Instance.playerName = playerNameButton.text;
    }
}
