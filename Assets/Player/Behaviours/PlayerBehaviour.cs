using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : StateMachineBehaviour {
    protected PlayerInput m_cInput;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        if (!m_cInput) {
            m_cInput = animator.gameObject.transform.parent.gameObject.GetComponent<PlayerInput>();
        }
        animator.ResetTrigger("SpiritAttack");
    }
}
