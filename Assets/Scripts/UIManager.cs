using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_HostScoreUI;
    [SerializeField] private TextMeshProUGUI m_ClientScoreUI;
    [SerializeField] private BallMovement m_Ball;

    private int m_HostScore = 0;
    private int m_ClientScore = 0;

    public void IncreaseScore(bool hostPoint)
    {
        if (hostPoint)
        {
            m_HostScore++;
            m_HostScoreUI.text = m_HostScore.ToString();
        }

        else
        {
            m_ClientScore++;
            m_ClientScoreUI.text = m_ClientScore.ToString();
        }
    }

    public void StartGame()
    {
        m_Ball.StartBouncing();
    }
}
