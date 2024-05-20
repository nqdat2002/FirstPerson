using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    // Update is called once per frame
    public AudioSource sound;
    public Transform player;
    public float maxDistance = 10f;
    public float minVolume = 0.1f;
    public float maxVolume = 1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(player.position, transform.position);
        float volume = Mathf.Lerp(maxVolume, minVolume, distanceToPlayer / maxDistance);
        sound.volume = volume;
    }
}
