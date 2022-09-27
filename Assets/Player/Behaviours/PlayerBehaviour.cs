using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : StateMachineBehaviour {
    protected bool m_bInitialized = false;
    protected PlayerInput m_cInput;
    protected PlayerForcedMovement m_cForcedMovement;
    protected PlayerInvincible m_cInvincible;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        if (!m_bInitialized) {
            m_cInput = animator.gameObject.transform.parent.gameObject.GetComponent<PlayerInput>();
            m_cForcedMovement = animator.gameObject.transform.parent.gameObject.GetComponent<PlayerForcedMovement>();
            m_cInvincible = animator.GetComponent<PlayerInvincible>();
            m_bInitialized = true;
        }
        animator.ResetTrigger("SpiritAttack");
    }
}
