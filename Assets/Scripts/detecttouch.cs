using UnityEngine;

public class DetectTouch : MonoBehaviour
{
    public Animator stinkyAnimator;
    public AudioSource audioSource;  
    public AudioClip outchSound;     
    public AudioClip happySound;     

    void Update()
    {
        if (Input.touchCount > 0)
        {
            foreach (Touch touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    stinkyAnimator.SetTrigger("outch");
                    if(audioSource != null && outchSound != null)
                    {
                        audioSource.PlayOneShot(outchSound);
                    }
                }
                else if (touch.phase == TouchPhase.Ended)
                {
                    stinkyAnimator.SetTrigger("happy");
                    if(audioSource != null && happySound != null)
                    {
                        audioSource.PlayOneShot(happySound);
                    }
                }
            }
        }
    }
}
