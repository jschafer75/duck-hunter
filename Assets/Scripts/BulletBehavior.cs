using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag != "Player") {
            Destroy(gameObject);
        }
        
        if (collision.gameObject.tag == "Duck") {
            Destroy(collision.gameObject);
            FindObjectOfType<ScoreKeeper>().UpdateScore(1);
            FindObjectOfType<DuckController>().DuckDestroyed();
        }
    }
}
