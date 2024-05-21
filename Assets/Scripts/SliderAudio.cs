using UnityEngine;
using UnityEngine.Audio;

public class SliderAudio : MonoBehaviour
{
	[SerializeField] private UnityEngine.UI.Slider _sliderSetting;
	[SerializeField] private AudioMixerGroup _groupAudio;

	private void Start()
	{
		ChangeSliders();
	}

	private void ChangeSliders(float volume = 0)
	{
		_sliderSetting.value = volume;
	}

	public void ChangeVolume(float volume)
	{
		_groupAudio.audioMixer.SetFloat(_groupAudio.name, Mathf.Log10(volume) * 40);
	}
}