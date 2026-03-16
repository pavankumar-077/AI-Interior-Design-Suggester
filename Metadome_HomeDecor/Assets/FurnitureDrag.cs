using UnityEngine;
using UnityEngine.InputSystem;

public class FurnitureDrag : MonoBehaviour
{
    private bool isDragging = false;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void OnMouseDown()
    {
        isDragging = true;
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Floor"))
                {
                    transform.position = new Vector3(hit.point.x, transform.position.y, hit.point.z);
                }
            }
        }
    }
}
