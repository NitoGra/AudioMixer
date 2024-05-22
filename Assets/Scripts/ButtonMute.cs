using TMPro;
using UnityEngine;

public class ButtonMute : MonoBehaviour
{
	[SerializeField] private AudioListener _listener;
	[SerializeField] private TextMeshProUGUI _text;

	private bool _isSoundWork = true;
	private string _soundOnSign = "X";
	private string _soundOffSign = "O";

	public void SwitchSoundWork()
	{
		_isSoundWork = !_isSoundWork;

		if (_isSoundWork)
		{
			_text.text = _soundOnSign;
			_listener.enabled = true;
		}
		else
		{
			_text.text = _soundOffSign;
			_listener.enabled = false;
		}
	}
}