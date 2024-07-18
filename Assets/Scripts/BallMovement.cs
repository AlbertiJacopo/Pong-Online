using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private Vector2 m_InitialForce = new Vector2(8, 2);
    private Rigidbody2D m_Rigidbody;

    public void StartBouncing()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        m_Rigidbody.AddForce(m_InitialForce, ForceMode2D.Impulse);
    }
}
