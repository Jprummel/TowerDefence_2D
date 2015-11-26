using UnityEngine;
using System.Collections;

public class BasePlayer : BaseStats 
{
    void OnCollisionEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            lives--;
            StartCoroutine(GameOver());
        }
    }

    IEnumerator GameOver()
    {
        if(lives <= 0)
        {
            yield return new WaitForSeconds (1);
            Application.LoadLevel("Game_Over");
        }
    }
}
