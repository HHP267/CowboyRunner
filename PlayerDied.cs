using UnityEngine;
using System.Collections;

public class PlayerDied : MonoBehaviour
{

    public delegate void EndGame();
    public static event EndGame endGame;

    void playerDiedEndGame()
    {
        if (endGame != null)
        {
            endGame();
        }

        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Collector")
        {
            playerDiedEndGame();
        }
    }

    //private void OnCollisionEnter2D(Collision2D target)
    //{
      //  if (target.gameObject.name == "Zombie")
        //{
         //   playerDiedEndGame();
        //}   
    //}
}



















