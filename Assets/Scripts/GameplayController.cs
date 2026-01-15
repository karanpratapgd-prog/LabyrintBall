using UnityEngine;
using TMPro;
using System.Collections;

public class GameplayController : MonoBehaviour
{
    private TextMeshProUGUI countdownText;
    public int countdown = 100;

    void Awake()
    {
        countdownText = GameObject.Find("Countdown")
                        .GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        while (countdown > 0)
        {
            countdownText.text = "Time Left: " + countdown;
            yield return new WaitForSeconds(1f);
            countdown--;
        }

        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name
        );
    }
}
