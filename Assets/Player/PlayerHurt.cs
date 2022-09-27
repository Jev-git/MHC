using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHurt : MonoBehaviour {
    public Animator m_cAnimator;
    public bool m_bIsInvincible = false;

    public void GetHit() {
        m_cAnimator.SetTrigger("GetHit");
    }
}
