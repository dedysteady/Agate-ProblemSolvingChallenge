using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    #region Singleton

    private static SoundManager _instance = null;

    public static SoundManager Instance
    {
        get
        {
            if (_instance == null)
            {
               _instance = FindObjectOfType<SoundManager>();

               if (_instance == null)
               {
                   Debug.LogError("Fatal Error: SoundManager not Found");
              }
            }   

            return _instance;
        }
    }

    #endregion

    public AudioClip gameOver;

    private AudioSource player;

    private void Start()
    {
        player = GetComponent<AudioSource>();
    }

    public void PlayGame()
    {
        player.PlayOneShot(gameOver);
    }
}
