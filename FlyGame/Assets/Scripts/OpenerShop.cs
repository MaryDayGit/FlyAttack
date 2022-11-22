
using UnityEngine;

public class OpenerShop : MonoBehaviour
{
    public GameObject panel;
    public void OpenPanel()
    {
        if (panel != null)
        {
            Animator animator = panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("OpenMenuTrigger");
                animator.SetBool("OpenMenuTrigger", !isOpen);
            }

        }
    }
}
