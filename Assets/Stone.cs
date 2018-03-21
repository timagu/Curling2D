using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            OnMouseDrag();
        }

        if (Input.GetMouseButton(0) == false)
        {

        }
    }

    void OnMouseDrag()
    {
        Vector2 objectPointInScreen
            = Camera.main.WorldToScreenPoint(this.transform.position);

        Vector2 mousePointInScreen = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        Vector2 mousePointInWorld = Camera.main.ScreenToWorldPoint(mousePointInScreen);
        this.transform.position = mousePointInWorld;
    }
}
