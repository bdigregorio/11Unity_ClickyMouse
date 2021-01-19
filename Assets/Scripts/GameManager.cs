// C# Standard Lib
using System.Collections;
using System.Collections.Generic;

// Unity
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour {
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public bool gameIsActive = true;
    private int score = 0;
    private float spawnRate = 1.0f;


    private void Start() {
        StartCoroutine(SpawnTarget());
        UpdateScore(0);
    }

    private IEnumerator SpawnTarget() {
        while (gameIsActive) {
            yield return new WaitForSeconds(spawnRate);
            int randomIndex = Random.Range(0, targets.Count);
            Instantiate(targets[randomIndex]);
        }
    }

    public void UpdateScore(int scoreToAdd) {
        score += scoreToAdd;
        scoreText.text = $"Score: {score}";
    }

    public void GameOver() {
        gameIsActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
