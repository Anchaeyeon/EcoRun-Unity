using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // ������ ǥ���� UI �ؽ�Ʈ
    private int score = 0; // ���� ����

    void Start()
    {
        StartCoroutine(UpdateScoreText());
    }

    void UpdateScore()
    {
        score++;
        scoreText.text = string.Format("X {0:D3}", score);
    }

    IEnumerator UpdateScoreText()
    {
        while (true) // ���� ����, �ʿ信 ���� ���� ������ �߰��� �� �ֽ��ϴ�.
        {
            // ���⿡ 1�ʸ��� ������ �۾��� �߰��ϼ���.
            Debug.Log("1�ʸ��� ����Ǵ� �۾�");
            UpdateScore();
            // 1�� ���� ���
            yield return new WaitForSeconds(1f);
        }
    }
}
