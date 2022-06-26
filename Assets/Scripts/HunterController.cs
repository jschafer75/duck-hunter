using UnityEngine;

public class HunterController : MonoBehaviour
{
    public BulletBehavior BulletPrefab;
    public Transform LaunchOffset;
    public float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(BulletPrefab, LaunchOffset.position, transform.rotation);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Duck")
        {
            Destroy(gameObject);
        }
    }

    void moveCharacter(Vector2 direction)
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 pos = transform.position;
        pos.x = pos.x + speed * horizontal * Time.deltaTime;
        pos.y = pos.y + speed * vertical * Time.deltaTime;
        transform.position = pos;
    }
}
