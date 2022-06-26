using UnityEngine;

public class DuckController : MonoBehaviour
{
    public DuckBehavior Duck;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Duck, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.FindObjectOfType(typeof(DuckBehavior)))
            Instantiate(Duck, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
