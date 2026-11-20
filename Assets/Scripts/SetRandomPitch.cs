using UnityEngine;

public class SetRandomPitch : MonoBehaviour
{
    public void PlayAtRandomPitch()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        float pitch = 0;
        while (pitch == 0)
        {
            pitch = Random.Range(0.1f, 3f);
        }
        audioSource.pitch = pitch;
        audioSource.Play();
    }
}
