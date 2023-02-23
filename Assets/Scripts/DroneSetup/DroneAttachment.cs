using DroneSetup.Decorators;
using UnityEngine;
using UnityEngine.Serialization;

namespace DroneSetup
{
    /// <summary>
    /// Attached to every drone attachment prefab, and should be added to any new ones that are made.
    /// </summary>
    public class DroneAttachment : MonoBehaviour
    {
        public DroneAttachmentSO Data => droneData;
        [FormerlySerializedAs("droneAttachmentSo")] [SerializeField] private DroneAttachmentSO droneData;
    }
}
