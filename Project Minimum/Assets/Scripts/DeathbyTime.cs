using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathbyTime : MonoBehaviour {

    [SerializeField]
    private float deathTime;

    void Update()
    {
        Destroy(this.gameObject, deathTime);
    }
}
