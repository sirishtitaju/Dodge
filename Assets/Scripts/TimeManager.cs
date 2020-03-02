using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

    // Use this for initialization
    public float slowdownFactor = 0.05f;
    public float slowdownLength = 4f;
    private void Update()
    {
        Time.timeScale += Time.unscaledDeltaTime * (1f / slowdownLength);
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
        // Debug.Log(Time.timeScale);
        if (Time.timeScale == 0.7f)
            SoundManager.instance.NormalSound();
    }
    public void DoSlowMotion()
    {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * 0.2f;
    }
}
