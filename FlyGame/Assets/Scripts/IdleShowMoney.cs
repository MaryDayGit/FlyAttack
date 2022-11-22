
using UnityEngine;
using UnityEngine.UI;

public class IdleShowMoney : MonoBehaviour
{
    public GameObject panel;
    public GameObject textIdle;

    public void OpenPanel()
    {
        if (panel != null)
        {
            Animator animator = panel.GetComponent<Animator>();
            if (animator != null)
            {
                textIdle.GetComponent<Text>().text = "You were not online for " + GlobalCs.ts.Minutes.ToString() + " minutes" + "\n" + " You've earned " + GlobalCs.idleMoney.ToString();
                bool isOpen = animator.GetBool("OpenMenuTrigger");
                animator.SetBool("OpenMenuTrigger", !isOpen);
            }

        }
    }
}
