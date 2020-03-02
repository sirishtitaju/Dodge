using UnityEngine;
public class BulletScript : MonoBehaviour
{
    public GameObject HitEffect;

    public int maxHealthBar = 4;

    public int currentHealthBar;
    private float SlowHealthBar;

    //public HealthBarIndicator healthbar;

    void Start()
    {
        currentHealthBar = maxHealthBar;
        // healthbar.SetMaxHealth(currentHealthBar);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag == "Enemy")
        {
            DestroyEffect();
            Destroy(collision.gameObject);
            SoundManager.instance.DeathSound();

        }
        if (collision.tag == "Player")
        {
            DestroyEffect();
            DecreaseHealth(1);
        }
        if (collision.tag == "border")
        {
            DestroyEffect();
        }
    }
    void DestroyEffect()
    {

        GameObject effect = Instantiate(HitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 0.4f);
        Destroy(gameObject);


    }
    void DecreaseHealth(int health)
    {
        currentHealthBar -= health;
        // healthbar.SetHealth(currentHealthBar);
    }
}
