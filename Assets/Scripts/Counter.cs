using System.Collections;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI _text;
	[SerializeField] private float _delay;
	[SerializeField] private AudioSource _mouseDown;

	private bool _work;

	private void Start()
	{
		_text.text = "";
		_work = true;
		StartCoroutine(Countdown(_delay));
	}

	private void OnMouseDown()
	{
		_work = !_work;
		_mouseDown.volume = 1;
		_mouseDown.Play();
	}

	private IEnumerator Countdown(float delay)
	{
		bool isContinue = true;
		var wait = new WaitForSeconds(delay);
		int numberCount = 0;

		while (isContinue)
		{
			if (_work)
			{
				numberCount++;
				DisplayCountdown(numberCount);
				Debug.Log("Display shows the number: " + numberCount + " with cooldown: " + delay);
			}
			else
			{
				Debug.Log("Numbers do not increase.");
			}

			yield return wait;
		}
	}

	private void DisplayCountdown(int count)
	{
		_text.text = count.ToString("");
	}
}