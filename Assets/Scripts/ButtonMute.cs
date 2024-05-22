using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ButtonMute : MonoBehaviour
{
	[SerializeField] private UnityEngine.UI.Button _button;
	[SerializeField] private SliderAudio _slider;
	[SerializeField] private TextMeshProUGUI _text;

	private bool _isSoundWork = true;
	private string _soundOnSign = "X";
	private string _soundOffSign = "O";

	private void OnEnable()
	{
		_button.onClick.AddListener(SwitchSoundWork);
	}

	private void OnDisable()
	{
		_button.onClick.RemoveListener(SwitchSoundWork);
	}

	public void SwitchSoundWork()
	{
		_isSoundWork = !_isSoundWork;

		if (_isSoundWork)
		{
			_slider.SwitchAudioEnabled(true);
			_text.text = _soundOnSign;
		}
		else
		{
			_slider.ChangeVolume(0);
			_slider.SwitchAudioEnabled(false);
			_text.text = _soundOffSign;
		}
	}
}