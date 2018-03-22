using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

    Rigidbody2D rigid2D;
    
    //制限速度
    float maxWalkSpeed = 3.0f;

    // Use this for initialization
    void Start () {
        rigid2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            //ストーンを掴む。
            OnMouseDrag();
            Debug.Log("マウス左ボタンを押しました。");
        }

        if (Input.GetMouseButton(0))
        {
            //投げる強さを選択する。
            Debug.Log("マウス左ボタンを押し続けています。");
        }
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButtonUp(0))
        {
            //-Y座標方向へ飛ぶ。
            GetMouseButtonUp();
            Debug.Log("マウス左ボタンを離しました。");
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

    void GetMouseButton()
    {
        //投げる強さを選択する。
    }

    void GetMouseButtonUp()
    {
        //-Y座標方向へ飛ぶ。           //力
        rigid2D.AddForce(Vector2.down * 500);

        //徐々に加速を落とす
        for (Vector2 i; rigid2D.velocity =< i; i=rigid2D.velocity - i)
    }
}
