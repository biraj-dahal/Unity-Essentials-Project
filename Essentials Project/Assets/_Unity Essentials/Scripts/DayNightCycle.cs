using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [SerializeField] private float dayDurationInSeconds = 60f; // Default: 60 seconds for a full day

    private void Update()
    {
        // Calculate the rotation speed based on the duration of the full day
        float rotationSpeed = 360f / dayDurationInSeconds; // Degrees per second

        // Rotate the Directional Light around the X-axis
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
