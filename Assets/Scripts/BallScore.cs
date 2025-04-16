using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BallScore : MonoBehaviour
{
    // Material������
    Material myMaterial;

    public Text scoreText; //Text�p�ϐ�
    public int score = 0; //�X�R�A�v�Z�p�ϐ�
    public ScoreManager scoreManeger;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        SetScore();   //�����X�R�A�������ĕ\��
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

        //�I�u�W�F�N�g�ɃA�^�b�`���Ă���Material���擾
        this.myMaterial = GetComponent<Renderer>().material;

        SetScore();
    }

    void SetScore()
    {
        scoreManeger.score = score;
    }
}