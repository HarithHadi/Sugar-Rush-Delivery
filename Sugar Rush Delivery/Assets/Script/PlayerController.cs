using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float[] lanes = { -3.25f, 0, 3.25f };
    public float speed;

    private int currentLane = 1; // start at middle
    private float targetX;

    void Start()
    {
        targetX = lanes[currentLane];
        Vector3 pos = transform.position;
        pos.x = targetX;
        transform.position = pos;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            currentLane = Mathf.Max(0, currentLane - 1);
            targetX = lanes[currentLane];
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            currentLane = Mathf.Min(lanes.Length - 1, currentLane + 1);
            targetX = lanes[currentLane];
        }

        // MOVEMENT (every frame)
        Vector3 pos = transform.position;
        pos.x = Mathf.MoveTowards(pos.x, targetX, speed * Time.deltaTime);
        transform.position = pos;
    }
}
