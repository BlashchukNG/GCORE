using System;
using UnityEngine;

namespace GIG.Asset.Providers
{
    public class Collision2DProvider :
        MonoBehaviour
    {
        public event Action<Collision2D> onCollisionEnter2D;
        public event Action<Collision2D> onCollisionStay2D;
        public event Action<Collision2D> onCollisionExit2D;
        public event Action<Collider2D> onTriggerEnter2D;
        public event Action<Collider2D> onTriggerStay2D;
        public event Action<Collider2D> onTriggerExit2D;

        private void OnCollisionEnter2D(Collision2D col) => onCollisionEnter2D?.Invoke(col);
        private void OnCollisionStay2D(Collision2D col) => onCollisionStay2D?.Invoke(col);
        private void OnCollisionExit2D(Collision2D col) => onCollisionExit2D?.Invoke(col);
        private void OnTriggerEnter2D(Collider2D col) => onTriggerEnter2D?.Invoke(col);
        private void OnTriggerStay2D(Collider2D col) => onTriggerStay2D?.Invoke(col);
        private void OnTriggerExit2D(Collider2D col) => onTriggerExit2D?.Invoke(col);
    }
}