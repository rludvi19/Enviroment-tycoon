using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraControl : MonoBehaviour
{
    
    //Controls the speed of the camera
    public float panSpeed = 1f;
    private Vector3 mouseOrigin;
    public Vector3 camOrigin;
    
    public float rotateMultiplier = 1f;
    private float rotateSpeed;
    private Vector3 mouseDir;
    public Transform RotateTarget;
    
    void Start()
    {
        camOrigin = transform.position;
    }
    
    void Update()
    {
        //Position of the camera
        Vector3 cpos = transform.position;
        
        //Key input
        if (Input.GetKey("w") && cpos.y >= 0)
        {

            cpos += transform.forward * panSpeed;
        }
        
        if (Input.GetKey("s") && cpos.y <= 100)
        {
            // cpos.z -= panSpeed;
            cpos += transform.forward * -panSpeed;
        } 
        
        if (Input.GetKey("x"))
        {
            Cursor.visible = true;
        }
        
        //Camera movement
         transform.position = cpos;
         
         
        //Rotation
        //Test with key input
        if (Input.GetKey("a"))
        {
            RotateTarget.transform.Rotate(0, 0.5f, 0);
        }
        
        if (Input.GetKey("d"))
        {
            RotateTarget.transform.Rotate(0, -0.5f, 0);
        }
        
        //Rotate with Mouse
        //Event on right mouse down
        if (Input.GetMouseButtonDown(1))
        {
            //Save the position of the mouse
            mouseOrigin = Input.mousePosition;
            Cursor.visible = false;
            return;
        }
        
        //Event on right mouse hold
        if (Input.GetMouseButton(1))
        {
            mouseDir = (Input.mousePosition - mouseOrigin);
            rotateSpeed =  rotateMultiplier / 200 * mouseDir.x;
            //Debug.Log("Dir.x: " + mouseDir.x + " speed: " + rotateSpeed);
            RotateTarget.transform.Rotate(0, rotateSpeed, 0);
        }
        
        //Event on right mouse release
        if (Input.GetMouseButtonUp(1))
        {
            Cursor.visible = true;
        }
    }
    
    //Method to reset camera
    public void ResetCamera()
    {
        RotateTarget.transform.rotation = Quaternion.identity;
        transform.position = camOrigin ;

    }

    
}
