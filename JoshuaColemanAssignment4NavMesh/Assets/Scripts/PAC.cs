using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAC : MonoBehaviour
{
    private Animator animator;

    private const string idle_animation_bool = "idle";

    private const string walk_animation_bool = "walk";

    private void AnimateIdle()
    {
        Animate(idle_animation_bool);
    }

    private void Animatewalk()
    {
        Animate(walk_animation_bool);
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Animate(string boolName)
    {
        DisableOtherAnimations(animator, boolName);

        animator.SetBool(boolName, true);
    }

    private void DisableOtherAnimations(Animator animator, string animation)
    {
        foreach(AnimatorControllerParameter parameter in animator.parameters)
        {
            if (parameter.name != animation)
            {
                animator.SetBool(parameter.name, false);
            }
        }
    }
}
