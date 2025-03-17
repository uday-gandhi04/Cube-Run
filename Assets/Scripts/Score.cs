using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{

    public Transform player;
    public TextMeshProUGUI score;
    // Update is called once per frame
    void Update()
    {
        score.text=player.position.z.ToString("0");
    }
}
