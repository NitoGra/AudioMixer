using TMPro;
using UnityEngine;

public class ButtonMute : MonoBehaviour
{
	[SerializeField] private AudioListener _listener;
	[SerializeField] private TextMeshProUGUI _text;

	private bool _isSoundWork = true;
	private string _soundOnSign = "X";
	private string _soundOffSign = "O";
	private Vector3 _soundPosition;
	private Vector3 _mutePosition = new Vector3(-2000, 0, 0);

	private void Start()
	{
		_soundPosition = _listener.transform.position;
	}

	public void SwitchSoundWork()
	{
		_isSoundWork = !_isSoundWork;

		if (_isSoundWork)
		{
			_text.text = _soundOnSign;
			_listener.transform.position = _soundPosition;
		}
		else
		{
			_text.text = _soundOffSign;
			_listener.transform.position = _mutePosition;
		}
	}
}