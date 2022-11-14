using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenerSettings : MonoBehaviour
{
    public GameObject panel;
    public void OpenPanel()
    {
        if (panel != null)
        {
            Animator animator = panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("SettingsMenu");
                animator.SetBool("SettingsMenu", !isOpen);
            }

        }
    }
}
