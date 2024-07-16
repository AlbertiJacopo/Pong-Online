using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private bool m_IsHost;
    [SerializeField] private UIManager m_UIManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AddPoint();
    }

    private void AddPoint()
    {
        m_UIManager.IncreaseScore(!m_IsHost);
    }
}
