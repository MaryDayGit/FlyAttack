using UnityEngine;
using UnityEngine.UI;
public class VolumeSettings : MonoBehaviour
{
    private Button _button;
    [SerializeField]
    private readonly Sprite[] sprite;
    private void Awake()
    {
        _button = GetComponent<Button>();
    }
    public void OnOffSounds()
    {
        if (GlobalCs.isOnSound == true)
        {
            AudioListener.volume = 0f;
            GlobalCs.isOnSound = false;
            _button.image.sprite = sprite[1];
        }
        else
        {
            AudioListener.volume = 1f;
            GlobalCs.isOnSound = true;
            _button.image.sprite = sprite[0];
        }
    }
}
