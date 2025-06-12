using UnityEngine;
using UnityEngine.UI;

public class TurntableController : MonoBehaviour
{
    public AudioSource audioPlayer;

    public Button playButton;
    public Button pauseButton;
    public Button rewindButton;
    public Button forwardButton;

    public Slider volumeSlider;
    public Slider speedSlider;

    void Start()
    {
        playButton.onClick.AddListener(() => audioPlayer.Play());
        pauseButton.onClick.AddListener(() => audioPlayer.Pause());
        rewindButton.onClick.AddListener(Rewind);
        forwardButton.onClick.AddListener(Forward);

        volumeSlider.onValueChanged.AddListener(SetVolume);
        speedSlider.onValueChanged.AddListener(SetSpeed);

        volumeSlider.value = audioPlayer.volume;
        speedSlider.value = audioPlayer.pitch;
    }

    void SetVolume(float volume)
    {
        audioPlayer.volume = volume;
    }

    void SetSpeed(float speed)
    {
        audioPlayer.pitch = speed;
    }

    void Rewind()
    {
        audioPlayer.time = Mathf.Max(0f, audioPlayer.time - 2f);
    }

    void Forward()
    {
        if (audioPlayer.clip != null)
            audioPlayer.time = Mathf.Min(audioPlayer.clip.length, audioPlayer.time + 2f);
    }
}
