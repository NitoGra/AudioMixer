using UnityEngine;
using UnityEngine.Audio;

public class SliderAudio : MonoBehaviour
{
	[SerializeField] private UnityEngine.UI.Slider _sliderSetting;
	[SerializeField] private AudioMixerGroup _groupAudio;

	private float _volumeMultiplier = 40;

	private void Start()
	{
		ChangeSliders();
	}

	private void OnEnable()
	{
		_sliderSetting.onValueChanged.AddListener(ChangeVolume);
	}
	
	private void OnDisable()
	{
		_sliderSetting.onValueChanged.RemoveListener(ChangeVolume);
	}

	public void SwitchAudioEnabled(bool isEnabled)
	{
		_sliderSetting.interactable = isEnabled;

		if(isEnabled == false)
			ChangeSliders();
	}

	public void ChangeVolume(float value)
	{
		_groupAudio.audioMixer.SetFloat(_groupAudio.name, Mathf.Log10(value) * _volumeMultiplier);
	}

	private void ChangeSliders(float volume = 0)
	{
		_sliderSetting.value = volume;
	}
}