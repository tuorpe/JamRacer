using UnityEngine;


//Acitvate Canvas Overlay for In-Game Menu, controlled by isInGameMenu bool in GameManager
public class inGameMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isInGameMenu)
        {
            // Handle in-game menu logic here
        }
    }
}
