using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    Vector2 checkpointPos;
    SpriteRenderer spriteRenderer;
    public GameObject winningObject;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        checkpointPos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Die();
        }

        if (collision.CompareTag("Player"))
        {
            ShowWinScreen();
        }
    }

    public void UpdateCheckpoint(Vector2 pos)
    {
        checkpointPos = pos;
    }

    void Die()
    {
        StartCoroutine(Respawn(0.2f));
    }


    IEnumerator Respawn(float duration)
    {
        spriteRenderer.enabled = false;
        yield return new WaitForSeconds(duration);
        transform.position = checkpointPos;
        spriteRenderer.enabled = true;

    }

    private void ShowWinScreen()
    {
        SceneManager.LoadScene("Win", LoadSceneMode.Additive);
        StartCoroutine(EndScreen());
    }

    IEnumerator EndScreen()
    {
        yield return new WaitForSeconds(5f);
        RestartGame();
    }

    private void RestartGame()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
