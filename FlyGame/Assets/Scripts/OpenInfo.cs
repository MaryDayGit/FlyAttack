
using UnityEngine;

public class OpenInfo : MonoBehaviour
{
    public GameObject panel;
    public void OpenPanel()
    {
        if (panel != null)
        {
            Animator animator = panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("InfoTrigger");
                animator.SetBool("InfoTrigger", !isOpen);
            }

        }
    }
}
