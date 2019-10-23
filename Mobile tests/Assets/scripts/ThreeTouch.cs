using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThreeTouch : MonoBehaviour
{
    [SerializeField] Text field;
    private Vector3 position;
    private float width;
    private float height;

    private void Awake()
    {
        width = (float)Screen.width / 2.0f;
        height = (float)Screen.height / 2.0f;
        position = new Vector3(0f, 0f, 0f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        field.text = "posx= " + position.x + "posY= " + position.y;
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase== TouchPhase.Moved)
            {
                Vector3 pos = touch.position;
                pos.x = (pos.x - width) / width * 10;
                pos.y = (pos.y - height) / height * 10;
                position = new Vector3(pos.x, pos.y, 0f);
                transform.position = position;
            }
            if(Input.touchCount == 2)
            {
                touch = Input.GetTouch(1);
                if (touch.phase == TouchPhase.Began)
                {
                    transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                }
                if (touch.phase == TouchPhase.Ended)
                {
                    transform.localScale = new Vector3(1f, 1f, 1f);
                }
            }
        }
        
    }
}
