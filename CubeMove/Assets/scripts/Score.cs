using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public TextMeshProUGUI textScore;
    public double zp,zpn;
    // Update is called once per frame
    private void Start()
    {
        zp = player.position.z;
    }
    void Update()
    {
        zpn = player.position.z - zp;
        textScore.text = zpn.ToString("0");
    }
}
