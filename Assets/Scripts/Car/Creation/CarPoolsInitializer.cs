﻿using System.Collections.Generic;
using AutomaticParking.Common.Patterns.Factory;
using AutomaticParking.Common.Patterns.Pool;
using UnityEngine;
using UnityEngine.Pool;

namespace AutomaticParking.Car.Creation
{
    public class CarPoolsInitializer : MonoBehaviour
    {
        [SerializeField] private PoolData poolData;
        [SerializeField] private CarsFactoryData factoryData;

        public List<IObjectPool<Transform>> CarPools { get; } = new();

        private void Awake()
        {
            foreach (GameObject carPrefab in factoryData.Prefabs)
            {
                var carFactory = new ComponentFactory<Transform>(carPrefab, factoryData.Parent);
                var carPoolFactory = new ComponentPoolFactory<Transform>(carFactory, poolData);
                CarPools.Add(carPoolFactory.FillWithStartObjects(carPoolFactory.Create()));
            }
        }
    }
}