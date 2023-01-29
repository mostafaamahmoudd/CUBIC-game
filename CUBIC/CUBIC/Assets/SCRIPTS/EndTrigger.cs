using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public gameMAnager gamemanager;

    private void OnTriggerEnter()
    {
        gamemanager.CompleteLevel();
    }

}
