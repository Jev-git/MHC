using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForcedMovement : MonoBehaviour {
    public float m_fIaiSpiritAttackForwardSpeed;
    public float m_fRollSpeed;

    public bool m_bIsForcingIaiSpiritAttack = false;
    public bool m_bIsRolling = false;

    private CharacterController m_cController;

    private void Start() {
        m_cController = GetComponent<CharacterController>();
    }

    private void FixedUpdate() {
        if (m_bIsForcingIaiSpiritAttack) {
            m_cController.SimpleMove(transform.forward * m_fIaiSpiritAttackForwardSpeed);
        } else if (m_bIsRolling) {
            m_cController.SimpleMove(transform.forward * m_fRollSpeed);
        }
    }
}
