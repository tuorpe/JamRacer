using UnityEngine;

//Generate track here from segments, controlled by isPlaying bool in GameManager

public class TrackGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isPlaying)
        {
            // Track generation logic goes here
        }
    }
}
