using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top3 : MonoBehaviour
{
    MusicSettings musicSettings;
    
    // Start is called before the first frame update
    void Start()
    {
        musicSettings = GetComponent<MusicSettings>();
        Debug.Log($"The best video game ever is Minecraft");
        Debug.Log($"The best film ever is Spiderman");
        Debug.Log($"The best song ever is {musicSettings.bestSongEver}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
