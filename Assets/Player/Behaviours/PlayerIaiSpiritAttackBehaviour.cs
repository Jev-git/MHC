using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIaiSpiritAttackBehaviour : PlayerBehaviour {
    private PlayerForcedMovement m_cForcedMovement;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateinfo, int layerindex) {
        base.OnStateEnter(animator, stateinfo, layerindex);
        if (!m_cForcedMovement) {
            m_cForcedMovement = animator.gameObject.transform.parent.gameObject.GetComponent<PlayerForcedMovement>();
        }
        m_cForcedMovement.m_bIsForcing = true;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        m_cForcedMovement.m_bIsForcing = false;
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}