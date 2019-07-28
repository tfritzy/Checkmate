using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    public delegate void ClickMiss();
    public static event ClickMiss OnClickMiss;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Cast a ray straight down.
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.forward);

            // If it hits something...
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                IClickable clickable = hit.collider.gameObject.GetComponent<IClickable>();
                if (clickable != null)
                {
                    clickable.Click();
                }
            }
            else
            {
                if (OnClickMiss != null)
                {
                    OnClickMiss();
                }

            }
        }
    }
}
