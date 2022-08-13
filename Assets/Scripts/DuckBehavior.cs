using System.Collections.Generic;
using UnityEngine;

public class DuckBehavior : MonoBehaviour
{
    public Rigidbody2D Body;
    public float VelocityChangeFactor = 0.3f;
    public float InitialVelocityMax = 5.0f;

    // Start is called before the first frame update
    void Start() {
        InvokeRepeating("ChangeDirection", 0.0f, 0.1f);
        Body = GetComponent<Rigidbody2D>();

        float xVelocity = Random.Range(-InitialVelocityMax, InitialVelocityMax);
        float yVelocity = Random.Range(-InitialVelocityMax, InitialVelocityMax);

        Body.velocity = Vector2.ClampMagnitude(new Vector2(xVelocity, yVelocity), InitialVelocityMax);
    }

    public void ChangeDirection() {
        float xVelocityChange = Random.Range(-VelocityChangeFactor, VelocityChangeFactor);
        float yVelocityChange = Random.Range(-VelocityChangeFactor, VelocityChangeFactor);

        Vector2 velocityChange = new Vector2(xVelocityChange, yVelocityChange);
        
        Body.velocity = Vector2.ClampMagnitude(Body.velocity + velocityChange, InitialVelocityMax);
    }
}
