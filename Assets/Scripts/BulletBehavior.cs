using UnityEngine;

public class BulletBehavior : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * 30.0f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Duck")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
