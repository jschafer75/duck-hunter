using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class HunterController : MonoBehaviour
{
    public BulletBehavior BulletPrefab;
    public Transform LaunchOffset;
    public Rigidbody2D Body;
    public float speed = 3.0f;
    public string mainMenuScene;

    void Start() {
        Body = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue input) {
        Vector2 inputVec = input.Get<Vector2>();
        
        Body.velocity = inputVec * speed;
    }

    void OnFire() {
        Instantiate(BulletPrefab, LaunchOffset.position, transform.rotation).GetComponent<Rigidbody2D>().velocity = new Vector2(30.0f, 0.0f);
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Duck") {
            SceneManager.LoadScene(mainMenuScene);
        }
    }
}
