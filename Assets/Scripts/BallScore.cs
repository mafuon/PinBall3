using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BallScore : MonoBehaviour
{
    // Materialを入れる
    Material myMaterial;

    public Text scoreText; //Text用変数
    public int score = 0; //スコア計算用変数
    public ScoreManager scoreManeger;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        SetScore();   //初期スコアを代入して表示
    }


    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("a" + collision.gameObject.name);
        Debug.Log("a" + collision.gameObject.tag);
        if (collision.gameObject.tag == "SmallCloudTag")
        {
            Debug.Log("a");
            score += 150;
        }
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            Debug.Log("a");
            score += 300;
        }
        else if (collision.gameObject.tag == "" || collision.gameObject.tag == "SmallStarTag")
        {
            Debug.Log("a");
            score += 100;
        }

        //オブジェクトにアタッチしているMaterialを取得
        this.myMaterial = GetComponent<Renderer>().material;

        SetScore();
    }

    void SetScore()
    {
        scoreManeger.score = score;
    }
}