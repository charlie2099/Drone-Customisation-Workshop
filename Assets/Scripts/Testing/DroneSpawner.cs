﻿using System.IO;
using DroneLoadout;
using UnityEditor;
using UnityEngine;

namespace Testing
{
    public class DroneSpawner : MonoBehaviour
    {
        //[SerializeField] private DroneType droneType;
        [SerializeField] private string dronePrefabPath = "Assets/Resources/";

        private void Start()
        {
            SpawnDrone();
        }

        private void SpawnDrone()
        {
            string droneName = "TestDrone.prefab";
            var path = dronePrefabPath + droneName;

            if (File.Exists(path))
            {
                GameObject customisedDronePrefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
                GameObject customisedDrone = Instantiate(customisedDronePrefab, transform.position, Quaternion.identity);
                Debug.Log($"Drone Cost: {customisedDrone.GetComponent<Drone>().DecorableDrone.Cost}");
                // TODO: Overwrite/create a new ScriptableObject DroneConfig?
            }
            else
            {
                Debug.LogError("Prefab does not exist!");
            }

            //var droneObject = Instantiate(dronePrefab, transform.position, Quaternion.identity);
            //var drone = droneObject.GetComponent<Drone>();
            
            // Instantiate drone attachment prefabs
            /*foreach (var attachmentPoint in drone.GetAttachmentPoints())
            {
                var propellerAttachment = Instantiate(propellerAttachmentPrefab).GetComponent<DroneAttachment>();
                drone.Decorate(propellerAttachment, attachmentPoint);
                Debug.Log($"{attachmentPoint.name}: {attachmentPoint.GetDroneAttachment()}");
                
                //attachmentPoint.AddDroneAttachment();
                //attachmentPoint.GetDroneAttachment()
                //drone.Decorate(, attachmentPoint);
            }*/
            
            //DroneSaveSystem.LoadFromFile();
            //drone.DecorableDrone = DroneFactory.CreateDrone(drone.DroneConfigData.droneType, drone.DroneConfigData);
            //_decorableDrone = new DroneDecorator(_decorableDrone, droneAttachment.Data);

            //string customisationData = PlayerPrefs.GetString("DroneCustomisationData");
            //IDrone customisedDrone = JsonUtility.FromJson<IDrone>(customisationData);
            //GameObject newDrone = Instantiate(dronePrefab, transform.position, Quaternion.identity);
            //newDrone.GetComponent<Drone>().Decorate(customisedDrone, );
            //Debug.Log(customisationData);
        }
    }
}
