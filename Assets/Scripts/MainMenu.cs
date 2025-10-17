using UnityEngine;

//Activate Canvas Overlay for Main Menu, controlled by isMainMenu bool in GameManager

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isMainMenu)
        {
            // Handle main menu logic here
        }
    }
}
