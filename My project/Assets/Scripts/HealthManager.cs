using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class HealthManager : MonoBehaviour
{
    public int health;
    public TMP_Text healthText;
    public void DecreaseHealth()
    {
        if (health > 0)
        {
            health--;
            healthText.SetText(health.ToString());
        }

        if (health <= 0)
        {
            healthText.SetText("You Died.");
        }
   }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple"))
        {
            DecreaseHealth();
            Destroy(other.gameObject);
        }
    }
}
