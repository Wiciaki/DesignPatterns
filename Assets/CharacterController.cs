using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private static readonly int TriggerId = Animator.StringToHash("Next");

    public void ChangeAnimation()
    {
        this.GetComponent<Animator>().SetTrigger(TriggerId);
    }
}