using UnityEngine;

public class WindowMovement : MonoBehaviour
{

    public float maxY = 10.24f;
    public float speed = 0.01f;
    public float PositionZ = -5f;
    public float originalPositionY = 0f;
    public float currentPositionY = 0f;

    // Update is called once per frame
    void Update()
    {
        currentPositionY -= speed;
        this.gameObject.transform.position = new Vector3(0, currentPositionY, PositionZ);

        if (currentPositionY < maxY) {
            this.gameObject.transform.position = new Vector3(0, 0, 0);
            currentPositionY = originalPositionY;
        }
    }
}
