using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteToggle : MonoBehaviour
{
    // Start is called before the first frame update
    public bool muted = false;
    public void Toggle()
    {
        if (muted)
        {
            AudioListener.volume = 1;
            muted = false;
        }
        else
        {
            AudioListener.volume = 0;
            muted = true;
        }
    }
}
