using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    

    private GameObject scoreText;


    public int score = 0;


    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoreText = GameObject.Find("ScoreText");


    }

    // Update is called once per frame
    void Update()
    {
          this.scoreText.GetComponent<Text>().text = "Score    "+score;
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        // デバッグ
        Debug.Log("ターゲットに衝突した。");
        if(other.gameObject.tag == "SmallStarTag")
        {
            score += 10;

        }
        if (other.gameObject.tag == "LargeStarTag")
        {
            score += 10;

        }
        if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 10;

        }
        if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 10;

        }


    }
}
