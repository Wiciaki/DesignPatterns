using System.Linq;

using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] characters;

    public void SetCharacter(int c)
    {
        for (var i = 0; i < this.characters.Length; i++)
        {
            this.characters[i].SetActive(i == c);
        }
    }

    public void ChangeAnimation()
    {
        foreach (var controller in this.characters.Select(c => c.GetComponent<CharacterController>()))
        {
            controller.ChangeAnimation();
        }
    }
}