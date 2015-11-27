using UnityEngine;
using System.Collections;

public class BasePlayer : BaseStats 
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "Enemy")
        {
            lives--;
            Destroy(other.gameObject);
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
