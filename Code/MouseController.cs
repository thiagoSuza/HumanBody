using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public static MouseController instance;

    [SerializeField]
    private GameObject sidePanel;

    [SerializeField]
    private float rotateSpeed;
    
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float zoomSpeed;

    [SerializeField]
    private Camera cam;



    private float _zoom;
    private Vector3 _position;
    private Quaternion _rotation;


    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        _zoom = 60;
        _position = transform.position;
        _rotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            DesactiveSidePanel();
        }


        if(Input.GetMouseButton(2))
        {
            Rotate();
        }

        if (Input.GetMouseButton(0))
        {
            Movement();
        }

        Zoom();

       
       
    }


    public void DesactiveSidePanel()
    {
        sidePanel.SetActive(false);
    }

    public void ActiveSidePanel()
    {
        sidePanel.SetActive(true);
    }


    public void Rotate()
    {
        float mouseX = Input.GetAxis("Mouse X");

        float rotacao = mouseX * rotateSpeed;

        transform.Rotate(Vector3.up,rotacao);
    }

    public void Movement()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 move = new Vector3(mouseX, mouseY, 0f) * moveSpeed * Time.deltaTime;

         transform.Translate(move);

       

    }


    public void Zoom()
    {
        if(Input.GetAxis("Mouse ScrollWheel") > 0 && cam.fieldOfView > 15f)
        {
            cam.fieldOfView -= zoomSpeed;
        }


        if(Input.GetAxis("Mouse ScrollWheel") < 0 && cam.fieldOfView < 75f)
        {
            cam.fieldOfView += zoomSpeed;
        }
    }

    
    public void ResetPosition()
    {
        cam.fieldOfView = _zoom;
        transform.position = _position;
        transform.rotation = _rotation;
    }
    
}
