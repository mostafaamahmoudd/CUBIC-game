using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoretext;
    int score_ = 0;

    void Update()
    {
        scoretext.text = score_.ToString();
        ++score_;
        //scoretext.text = player.position.z.ToString("0");
    }
}
