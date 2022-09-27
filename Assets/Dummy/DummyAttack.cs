using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyAttack : MonoBehaviour {
    void Start() {
        
    }

    void Update() {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player")) {
            PlayerHurt _cPH = other.GetComponent<PlayerHurt>();
            if (!_cPH.m_bIsInvincible) {
                _cPH.GetHit();
            }
        }
    }
}
