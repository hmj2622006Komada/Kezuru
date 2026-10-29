using TMPro;
using UnityEngine;

public class RandomScript: MonoBehaviour
{
	[SerializeField] TextMeshProUGUI textMeshProText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		DisplayRandomNumber();
	}
	public void DisplayRandomNumber()
	{
		if (textMeshProText != null)
		{
			int randomNumber = Random.Range(1, 11);

			textMeshProText.text = randomNumber.ToString();
		}
	}
	// Update is called once per frame
	void Update()
    {
        
    }
}
