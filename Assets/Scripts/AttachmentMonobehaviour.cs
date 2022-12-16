using Drone;
using Drone.Decorators;
using UnityEngine;

public class AttachmentMonobehaviour : MonoBehaviour
{
    public DroneAttachment Attachment => droneAttachment;
    [SerializeField] private DroneAttachment droneAttachment;
}
