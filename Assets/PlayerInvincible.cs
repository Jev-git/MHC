using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvincible : MonoBehaviour {
    private PlayerHurt m_cPlayerHurt;

    void Start() {
        m_cPlayerHurt = transform.parent.gameObject.GetComponent<PlayerHurt>();
    }

    public void ActivateInvincibility() {
        m_cPlayerHurt.m_bIsInvincible = true;
    }

    public void DeactivateInvincibility() {
        m_cPlayerHurt.m_bIsInvincible = false;
    }
}
