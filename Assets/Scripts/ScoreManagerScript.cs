using UnityEngine;
using System.Collections;
using TouchScript.Gestures;
using UnityEngine.UI;

public class ScoreManagerScript : MonoBehaviour {

    public static int Score { get; set; }
	int oldScore = 0;

    float one;
    float ten;
    float hundred;

	// Use this for initialization
	void Start () {
        Score = 0;
        (Tens.gameObject as GameObject).SetActive(false);
        (Hundreds.gameObject as GameObject).SetActive(false);
	}
	
    public void Switch ()
    {
        iTween.PunchScale(gameObject, iTween.Hash("amount", new Vector3(0.2f, 0.2f, 0), "time", 1.7f, "easetype", iTween.EaseType.linear));
    }
    

	// Update is called once per frame
	void Update () {
		if (Score != oldScore) {
			iTween.PunchScale (gameObject, iTween.Hash ("amount", new Vector3 (1.0f, 1.0f, 0), "time", 0.2f, "easetype", iTween.EaseType.linear));
			oldScore = Score;
		}
		if (previousScore != Score) { //save perf from non needed calculations
			if (Score < 10) {
				//just draw units
				Units.GetComponent<Image> ().sprite = numberSprites [Score];
				Units.GetComponent<Transform> ().position = new Vector3 ((Screen.width / 2), Screen.height / (1.25f), 0);
              
			} else if (Score >= 10 && Score < 100) {
				//Destroy (gameObject);
				(Tens.gameObject as GameObject).SetActive (true);
				Tens.GetComponent<Image> ().sprite = numberSprites [Score / 10];
				Units.GetComponent<Image> ().sprite = numberSprites [Score % 10];

				float unitWIDTH = (Units.GetComponent<Image> ().sprite.rect.width) / ((Units.GetComponent<Image> ().sprite.rect.height) / (Units.GetComponent<RectTransform> ().rect.height));
				float tenWIDTH = (Tens.GetComponent<Image> ().sprite.rect.width) / ((Tens.GetComponent<Image> ().sprite.rect.height) / (Tens.GetComponent<RectTransform> ().rect.height));

				float numWIDTH = (unitWIDTH + tenWIDTH) / 2;

				if (tenWIDTH == numWIDTH)
					ten = (tenWIDTH / 3);
				else
					ten = (tenWIDTH / 2) + (numWIDTH - tenWIDTH);
				one = (unitWIDTH / 2) + (numWIDTH - unitWIDTH);

				Units.GetComponent<Transform> ().position = new Vector3 ((Screen.width / 2) + one, Screen.height / (1.25f), 0);
				Tens.GetComponent<Transform> ().position = new Vector3 ((Screen.width / 2) - ten, Screen.height / (1.25f), 0);
			} else if (Score >= 100) {
				(Hundreds.gameObject as GameObject).SetActive (true);
				Hundreds.GetComponent<Image> ().sprite = numberSprites [Score / 100];
				int rest = Score % 100;
				Tens.GetComponent<Image> ().sprite = numberSprites [rest / 10];
				Units.GetComponent<Image> ().sprite = numberSprites [rest % 10];

				float unitWIDTH = (Units.GetComponent<Image> ().sprite.rect.width) / ((Units.GetComponent<Image> ().sprite.rect.height) / (Units.GetComponent<RectTransform> ().rect.height));
				float tenWIDTH = (Tens.GetComponent<Image> ().sprite.rect.width) / ((Tens.GetComponent<Image> ().sprite.rect.height) / (Tens.GetComponent<RectTransform> ().rect.height));
				float hundredWIDTH = (Hundreds.GetComponent<Image> ().sprite.rect.width) / ((Hundreds.GetComponent<Image> ().sprite.rect.height) / (Hundreds.GetComponent<RectTransform> ().rect.height));

				float numWIDTH = (unitWIDTH + tenWIDTH + hundredWIDTH) / 2;

				hundred = (hundredWIDTH / 3) + (numWIDTH - hundredWIDTH);
				ten = (tenWIDTH / 2) + (numWIDTH - (tenWIDTH + hundredWIDTH));
				one = (unitWIDTH / 3) + (numWIDTH - unitWIDTH);

				Units.GetComponent<Transform> ().position = new Vector3 ((Screen.width / 2) + one, Screen.height / (1.25f), 0);
				Tens.GetComponent<Transform> ().position = new Vector3 ((Screen.width / 2) - ten, Screen.height / (1.25f), 0);
				Hundreds.GetComponent<Transform> ().position = new Vector3 ((Screen.width / 2) - hundred, Screen.height / (1.25f), 0);
			}

		}
	}


    int previousScore = -1;
    public Sprite[] numberSprites;
    public CanvasRenderer Units, Tens, Hundreds;
   
}
