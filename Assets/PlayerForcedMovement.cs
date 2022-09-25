using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForcedMovement : MonoBehaviour {
    public float m_fSpeed;
    public bool m_bIsForcing = false;

    private CharacterController m_cController;

    private void Start() {
        m_cController = GetComponent<CharacterController>();
    }

    private void FixedUpdate() {
        if (m_bIsForcing) {
            m_cController.SimpleMove(transform.forward * m_fSpeed);
        }
    }
}
