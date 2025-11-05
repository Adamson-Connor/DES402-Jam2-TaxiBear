using UnityEngine;

public class PageTurnAudio : MonoBehaviour
{
    public AK.Wwise.Event pageTurn;
    public void PlayAudio()
    {
        //post sound
        pageTurn.Post(gameObject);
    }
}
