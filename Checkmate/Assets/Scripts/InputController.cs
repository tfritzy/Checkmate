using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
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

            /*
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics2D.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject.name);
                IClickable clickable = hit.collider.gameObject.GetComponent<IClickable>();
                if (clickable != null)
                {
                    print("My object is clicked by mouse");
                }
            }*/
        }
    }
}
