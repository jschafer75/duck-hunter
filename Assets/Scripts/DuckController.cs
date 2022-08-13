using UnityEngine;

public class DuckController : MonoBehaviour
{
    public DuckBehavior Duck;
    public AudioSource KillSound;
    public Rigidbody2D Body;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Duck, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public void DuckDestroyed(){
        KillSound.Play();
        Instantiate(Duck, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(Duck, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
