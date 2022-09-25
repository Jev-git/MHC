using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class PlayerInput : MonoBehaviour {
    public InputActionMap m_cInputs;
    private CharacterController m_cController;
    public Transform m_goCamera;
    public Transform m_goOrientation;
    public Animator m_cAnimator;

    private Vector2 m_vMoveInput;

    public float m_fMoveSpeed;
    public bool m_bIsSpiritAttackInputPerformed = false;
    public bool m_bCanMove = true;

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        m_cController = GetComponent<CharacterController>();

        m_cInputs["Move"].performed += ctx => m_vMoveInput = ctx.ReadValue<Vector2>();
        m_cInputs["Move"].canceled += ctx => m_vMoveInput = Vector2.zero;
        m_cInputs["SpiritAttack"].performed += ctx => m_cAnimator.SetTrigger("SpiritAttack");
    }

    void Update() {
    }

    private void FixedUpdate() {
        if (m_bCanMove) {
            Vector3 _vForwardDir = transform.position - new Vector3(m_goCamera.position.x, transform.position.y, m_goCamera.position.z);
            m_goOrientation.forward = _vForwardDir.normalized;
            Vector3 _vMoveDir = m_goOrientation.forward * m_vMoveInput.y + m_goOrientation.right * m_vMoveInput.x;
            if (_vMoveDir != Vector3.zero) {
                transform.LookAt(Vector3.Slerp(transform.position + transform.forward, transform.position + _vMoveDir.normalized, .3f));
                m_cController.SimpleMove(_vMoveDir * m_fMoveSpeed);
                m_cAnimator.SetBool("IsRunning", true);
            }
            else {
                m_cAnimator.SetBool("IsRunning", false);
            }
        }
    }

    private void OnEnable() {
        m_cInputs.Enable();
    }

    private void OnDisable() {
        m_cInputs.Disable();
    }
}
