﻿using DroneLoadout.Component;
using DroneLoadout.Decorators;

namespace DroneLoadout.Concrete
{
    public class InterceptorDrone : IDrone 
    {
        private readonly DroneConfigData _droneConfigData;
    
        public InterceptorDrone(DroneConfigData droneConfigData)
        {
            _droneConfigData = droneConfigData;
        }

        public float Cost => _droneConfigData.Cost;
        public float Range => _droneConfigData.Range;
        public float TopSpeed => _droneConfigData.TopSpeed;
        public float Acceleration => _droneConfigData.Acceleration;
        public float Weight => _droneConfigData.Weight;
    }
}