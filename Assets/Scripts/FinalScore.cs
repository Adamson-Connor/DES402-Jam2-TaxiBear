using TMPro;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    [SerializeField] private GameObject[] positiveResults;
    [SerializeField] private int finalScore;
    [SerializeField] private GameObject text;
    public void GetScore()
    {
        finalScore = 0;

        foreach (GameObject obj in positiveResults)
        {
            if (obj.activeInHierarchy)
            {
                finalScore++;
            }
        }

        text.GetComponent<TextMeshProUGUI>().SetText(finalScore + "/3");
    }
}
