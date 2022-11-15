using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<GameObject> Target;
    public bool IsGameActive = true;
    public int score = 0;
    public TextMeshProUGUI GameOverText;
    public Button RestartButton;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
        StartCoroutine(SpawnTarget());
    }
    public void UpdateScore(int addToScore)
    {
        score += addToScore;
        Debug.Log("Score: " + score.ToString());
        scoreText.text = "Score:" + score;
    }
    IEnumerator SpawnTarget()
    {
        while(IsGameActive)
        {
            yield return new WaitForSeconds(1f);
            int index = Random.Range(0, Target.Count);
            Instantiate(Target[index]);
        }
    }
    public void GameOver()
    {
        IsGameActive = false;
        GameOverText.gameObject.SetActive(true);
        RestartButton.gameObject.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
