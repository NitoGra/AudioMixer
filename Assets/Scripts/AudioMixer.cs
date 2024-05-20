using UnityEngine;
using UnityEngine.Audio;

public class AudioMixer : MonoBehaviour
{
	[SerializeField] private AudioMixerGroup _mixer;
	[SerializeField] private string _volumeName;

	private bool _isAudioPlay = true;
	private float _startAudioVolume = 0.5f;

	private void Start()
	{
		ChangeVolume(_startAudioVolume);
	}

	private void OnEnable()
	{
		Time.timeScale = 0.0f;
	}

	private void OnDisable()
	{
		Time.timeScale = 1.0f;
	}

	public void ToggleVolume()
	{
		_isAudioPlay = !_isAudioPlay;

		if (_isAudioPlay)
			_mixer.audioMixer.SetFloat(_volumeName, 0);
		else
			_mixer.audioMixer.SetFloat(_volumeName, -80);
	}

	public void ChangeVolume(float volume)
	{
		if (_isAudioPlay)
			_mixer.audioMixer.SetFloat(_volumeName, Mathf.Log10(volume) * 40);
	}
}