using System;
using UnityEngine;
using UnityEngine.UI;

namespace GIG.Asset.Views
{
    public class ViewSlider :
        MonoBehaviour
    {
        public event Action<float> onValueChanged;

        [SerializeField] private Slider _slider;
        [SerializeField] private Image _bar;

        private void Awake() => _slider.onValueChanged.AddListener(ValueChanged);

        private void ValueChanged(float value)
        {
            _bar.fillAmount = value;
            onValueChanged?.Invoke(value);
        }

        public void SetValue(float value)
        {
            _slider.value = value;
            _bar.fillAmount = value;
        }
    }
}