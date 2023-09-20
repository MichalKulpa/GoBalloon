using UnityEngine;

namespace GB.Level
{
    public class Cleaner : MonoBehaviour
    {
        private void OnTriggerExit(Collider other)
        {
            Destroy(other.gameObject);
        }
    }
}

