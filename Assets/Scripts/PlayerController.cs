using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Netcode;
using UnityEditor;
using UnityEngine;

public class PlayerController : NetworkBehaviour
{
    [SerializeField] private float m_Speed = 0.001f;

    [SerializeField] private Vector2 m_SpawnPosHost;
    [SerializeField] private Vector2 m_SpawnPosClient;

    private float m_MoveY;
    private Rigidbody2D m_Rigidbody;

    public override void OnNetworkSpawn()
    {
        if (!IsOwner) Destroy(this);
        if (IsHost) transform.position = m_SpawnPosHost;
        if (!IsHost) transform.position = m_SpawnPosClient;
    }

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        m_MoveY = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        m_Rigidbody.AddForce(new Vector2(0, m_MoveY * m_Speed), ForceMode2D.Force);
    }

}
