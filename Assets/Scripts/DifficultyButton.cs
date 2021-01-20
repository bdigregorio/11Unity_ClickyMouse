using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour {
    private Button button;
    private GameManager gameManager;
    public float spawnDelay;

    private void Start() {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    private void Update() {
        
    }

    private void SetDifficulty() {
        Debug.Log($"{gameObject.name} was clicked");
        gameManager.StartGame(spawnDelay);
    }
}
