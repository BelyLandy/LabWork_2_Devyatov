using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    [SerializeField] private bool isChanged;
    //private Vector3 lastMousePosition;

    [SerializeField] private Texture2D _texture2D;

    private void Awake()
    {
        //Cursor.visible = !isChanged;
        //this.enabled = !isChanged;
        Cursor.SetCursor(_texture2D, Vector2.zero, CursorMode.Auto);
        
        //lastMousePosition = Input.mousePosition;
    }

    void Update() 
    {
        SetCustomCursor();
    }

    private void SetCustomCursor()
    {
        if (!isChanged) return;

        Vector3 currentMousePosition = Input.mousePosition;
        //if (currentMousePosition != lastMousePosition)
        //{
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(currentMousePosition);
            worldPosition.z = 0f;
            transform.position = worldPosition;
            //lastMousePosition = currentMousePosition;
        //}
    }
}