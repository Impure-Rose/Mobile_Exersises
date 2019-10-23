using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Joystick : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private Image joystick;
    private bool joystickPressed;
    [SerializeField] private Vector3 targetPos, camDistance = new Vector3(0f, 13f, -14f);
    [SerializeField] private GameObject player;
    private float cameraSmoothSpeed = 1f;
    [SerializeField] private float speed = 8f;

    [SerializeField] private GameObject particles;
    private ParticleSystem ps;


    // Start is called before the first frame update
    void Start()
    {
        camDistance = new Vector3(0f, 9f, -14f);
        ps = particles.GetComponent<ParticleSystem>();
        ps.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (joystickPressed == true)
        {
            targetPos = new Vector3(joystick.rectTransform.localPosition.x, player.transform.position.y, joystick.rectTransform.localPosition.y);
            player.transform.position = Vector3.MoveTowards(player.transform.position, targetPos, speed * Time.deltaTime);

            player.transform.LookAt(targetPos);
        }
        Vector3 distance = player.transform.position + camDistance;
        cam.transform.position= Vector3.Lerp(cam.transform.position, distance, cameraSmoothSpeed * Time.deltaTime);
        cam.transform.LookAt(player.transform.position);
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked");
        joystickPressed = true;
        ps.Play();
    }
    private void OnMouseUp()
    {
        joystickPressed = false;
        ps.Stop();
    }
}
