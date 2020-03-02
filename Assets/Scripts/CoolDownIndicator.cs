using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoolDownIndicator : MonoBehaviour
{

    // Use this for initialization
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public void SetMaxCoolDown(float cooldown)
    {
        slider.maxValue = cooldown; ;
        slider.value = cooldown;

        fill.color = gradient.Evaluate(1f);
    }
    public void SetCooldown(float cooldown)
    {
        slider.value = cooldown;


        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
    private void LateUpdate()
    {
        if (slider.value == 0 && Input.GetMouseButtonDown(0))
        {
            SoundManager.instance.NoCoolDown();

        }
        else if (slider.value > 0 && Input.GetMouseButtonDown(0))
        {
            SoundManager.instance.SlowDownSound();
        }
    }

}
