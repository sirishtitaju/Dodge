using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed = 5;
    private float maxY = 4.48f, minY = -4.48f, minX = -8.31f, maxX = 8.31f;
    public Rigidbody2D ball;

    public int maxCooldowntime = 4;

    public static float currentCooldown = 0;
    private float SlowCooldown;

    public CoolDownIndicator cooldownbar;
    private Vector2 movement;
    private int mouseCount;

    public AudioSource bgMusic;
    Vector2 mousepos;
    public TimeManager timeManager;
    void Start()
    {
        currentCooldown = maxCooldowntime;
        cooldownbar.SetMaxCoolDown(maxCooldowntime);
    }
    void FixedUpdate()
    {
        Vector2 temp = transform.position;
        if (temp.y >= maxY)
            temp.y = maxY;

        if (temp.y <= minY)
            temp.y = minY;
        transform.position = temp;

        if (temp.x >= maxX)
            temp.x = maxX;

        if (temp.x <= minX)
            temp.x = minX;
        transform.position = temp;

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        ball.MovePosition(ball.position + movement * speed * Time.fixedDeltaTime);
        mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 lookDir = mousepos - ball.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        ball.rotation = angle;

        // if (SlowCooldown % 10 == 0)
        {
            Debug.Log("Cooldown Over");
            if (currentCooldown > 0)
            {
                if (Input.GetMouseButtonDown(0))
                {

                    bgMusic.pitch -= Time.deltaTime * 4 / 5;
                    SoundManager.instance.SlowDownSound();
                    timeManager.DoSlowMotion();
                    // Debug.Log("Available");
                    DecreaseCooldown(1);
                    //Debug.Log(currentCooldown);
                    // if (currentCooldown < 4)
                    {
                        StartCoroutine(IncreaseCooldown());

                    }
                    // StartCoroutine(ResetCooldown(10));
                }
            }

        }
        //else
        // Debug.Log("Cooldown Ongoing");
    }
    void DecreaseCooldown(int time)
    {
        currentCooldown -= time;
        // Debug.Log("currentCool" + currentCooldown);
        cooldownbar.SetCooldown(currentCooldown);
    }
    IEnumerator ResetCooldown(int time)
    {
        yield return new WaitForSeconds(time);
        currentCooldown = 0;
    }
    IEnumerator IncreaseCooldown()
    {
        yield return new WaitForSeconds(8);
        // float temp = 0;
        // temp = temp + Time.deltaTime;
        // currentCooldown = temp;
        currentCooldown += 1f;
        // Debug.Log("RandomcurrentCool" + currentCooldown);
        cooldownbar.SetCooldown(currentCooldown);
        //StartCoroutine(ResetCooldown(1));
    }
}
