using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public Button startGameButton;
    public InputField enterName;
    public string playerName;

    public static DataManager Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        Button btn = startGameButton.GetComponent<Button>();
        btn.onClick.AddListener(StartGame);

    }

    void Update()
    {
        
    }
    void StartGame()
    {
        InputField enterName = GameObject.Find("EnterPlayerName").GetComponent<InputField>();
        playerName = enterName.text;
        Debug.Log(playerName);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }


}

