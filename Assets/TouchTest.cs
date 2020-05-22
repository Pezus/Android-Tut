using UnityEngine;
using System.Collections;

public class TouchTest : MonoBehaviour {

    Ray ray;
    RaycastHit hit;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        Debug.Log("unpdate");
        if (Input.touchCount > 0)
        {
            Debug.Log("in 1");
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Debug.Log("in 2");
                ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

                if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                {
                    Debug.Log("Hit something");

                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}
