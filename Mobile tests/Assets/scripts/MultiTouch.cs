using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiTouch : MonoBehaviour
{
    [SerializeField] private GameObject mySprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<Input.touchCount;i++)
        {
            Vector3 spritePosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
            spritePosition.z = 0f;
            GameObject clone = Instantiate(mySprite, spritePosition, Quaternion.identity);
            Destroy(clone, 0.5f);
        }
    }
}
