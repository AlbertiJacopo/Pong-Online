using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private Vector2 m_InitialForce = new Vector2(5, 2);
    private Rigidbody2D m_Rigidbody;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        m_Rigidbody.AddForce(m_InitialForce, ForceMode2D.Impulse);
    }
}
