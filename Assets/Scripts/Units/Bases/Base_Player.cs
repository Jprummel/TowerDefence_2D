using UnityEngine;
using System.Collections;

public class Base_Player : Base_Stats 
{
    
	// Use this for initialization
	void Start () 
    {
	    
	}
	
	// Update is called once per frame
	void Update () 
    {
	
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
