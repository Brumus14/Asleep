using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Vector2 playerInitialPosition;
    private GameObject[] enemies;
    private GameObject player;
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("slimeEnemy");
        player = GameObject.FindWithTag("Player");
    }

    public void PlayerDied()
    {
        Time.timeScale = 0f;
        StartCoroutine(Restartgame());
    }

    IEnumerator Restartgame()
    {
        yield return new WaitForSecondsRealtime(2f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(
        UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
