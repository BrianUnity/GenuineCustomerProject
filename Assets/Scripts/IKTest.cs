using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public GameObject target;

    Animator anim;

    private void OnAnimatorIK(int layerIndex) {
        anim.SetIKPosition(AvatarIKGoal.RightHand, target.transform.position);
        anim.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
