using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScoreController : MonoBehaviour
{
    // スコアを表示するテキスト
    private GameObject gamescoreText;

    // スコア
    private int gameScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        // シーン中のGameOverTextオブジェクトを取得
        this.gamescoreText = GameObject.Find("ScoreText");

    }

    // Update is called once per frame
    void Update()
    {
    }

    // 衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.gameScore += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.gameScore += 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.gameScore += 50;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.gameScore += 100;
        }
        this.gamescoreText.GetComponent<Text>().text = "Score: " + this.gameScore;
    }
}
