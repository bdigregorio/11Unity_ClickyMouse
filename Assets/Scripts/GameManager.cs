using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public List<GameObject> targets;
    private float spawnRate = 1.0f;

    private void Start() {
        StartCoroutine(SpawnTarget());
    }

    private IEnumerator SpawnTarget() {
        while (true) {
            yield return new WaitForSeconds(spawnRate);
            int randomIndex = Random.Range(0, targets.Count);
            Instantiate(targets[randomIndex]);
        }
    }
}
