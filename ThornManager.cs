using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThornManager : MonoBehaviour
{
    private float health;
    public float damage;

    bool colliderBusy = false;

    bool dead = false;

    public Transform FloatingText;

    public Slider slider;

    void Start()
    {
        slider.maxValue = health;
        slider.value = health;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !colliderBusy)
        {
            colliderBusy = true;
            collision.GetComponent<PlayerManager>().GetDamage(damage);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            colliderBusy = false;
        }
    } 

    public void GetDamage(float damage)
    {
        Instantiate(FloatingText, transform.position, Quaternion.identity).GetComponent<TextMesh>().text = damage.ToString();

        if ((health - damage) >= 0)
        {
            health -= damage;
        }
        else
        {
            health = 0;
        }
        slider.value = health;
        AmIdead();
    }

    void AmIdead()
    {
        if (health <= 0)
        {
            dead = true;
        }
    }
}

