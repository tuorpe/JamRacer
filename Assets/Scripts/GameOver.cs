using UnityEngine;


//Activate Canvas Overlay for Main Menu, controlled by isMainMenu bool in GameManager
public class GameOver : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isGameOver)
        {
            // Handle game over logic here
            Debug.Log("Game Over! Final Score: " + GameManager.Instance.score);
            // You can add more game over handling code here
        }
    }
}
