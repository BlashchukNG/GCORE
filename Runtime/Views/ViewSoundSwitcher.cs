using GIG.Asset.Controllers;
using GIG.Asset.Extensions;
using UnityEngine;
using UnityEngine.UI;

namespace GIG.Asset.Views
{
    public class ViewSoundSwitcher :
        MonoBehaviour
    {
        public Button button;
        public AudioSource source;

        public Sprite on;
        public Sprite off;

        private void Awake()
        {
            button.Action(SwitchState);
        }

        private void SwitchState()
        {
            if (button.image.sprite == on)
            {
                source.volume = 0;
                button.image.sprite = off;
            }
            else
            {
                source.volume = 1;
                button.image.sprite = on;
            }

            foreach (var switcher in FindObjectsOfType<ViewSoundSwitcher>())
                switcher.UpdateState();

            FindObjectOfType<SaveController>().Save();
        }

        public void UpdateState() => button.image.sprite = source.volume > 0.5f ? on : off;
    }
}