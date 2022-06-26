using System.Collections.Generic;
using UnityEngine;

public class DuckBehavior : MonoBehaviour
{

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    public Direction dir = Direction.Left;
    public List<Direction> dirList = new List<Direction>();
    public int timeInDir = 0;
    private const int VertMax = 4;
    private const int HorzMax = 8;

    // Start is called before the first frame update
    void Start()
    {
        dirList.Add(Direction.Up);
        dirList.Add(Direction.Down);
        dirList.Add(Direction.Left);
        dirList.Add(Direction.Right);

        InvokeRepeating("ChangeDirection", 0.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        switch (dir)
        {
            case Direction.Up:
                UpdatePosition(0, 1);
                break;
            case Direction.Down:
                UpdatePosition(0, -1);
                break;
            case Direction.Left:
                UpdatePosition(-1, 0);
                break;
            case Direction.Right:
                UpdatePosition(1, 0);
                break;
            default:
                break;
        }
    }

    public void ChangeDirection()
    {
        dir = dirList[Random.Range(0, 4)];
    }

    void UpdatePosition(int x, int y)
    {
        Vector2 pos = transform.position;
        pos.x = pos.x + 10.0f * x * Time.deltaTime;
        pos.y = pos.y + 10.0f * y * Time.deltaTime;
        transform.position = pos;
    }
}
