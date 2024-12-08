using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionDetect : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple"))
        {
            score++;
            scoreText.SetText(score.ToString());
            Destroy(other.gameObject);
            Transport.instance.MoveGameObject();
        }
    }
}

