﻿using System.Linq;
using AutomaticParking.Agents.Data;
using AutomaticParking.Common.Enumerations;
using UnityEngine;

namespace AutomaticParking.Agents.Components
{
    public class ParkingAgentCollisionsHandler : MonoBehaviour
    {
        private ParkingAgentCollisionData collisionData;

        private void OnCollisionEnter(Collision collision)
        {
            string gameObjectTag = collision.gameObject.tag;
            if (Tag.List.Contains(gameObjectTag))
                collisionData.CollisionTag = gameObjectTag;
        }

        public ParkingAgentCollisionsHandler Initialize(ParkingAgentCollisionData collisionData)
        {
            this.collisionData = collisionData;
            return this;
        }
    }
}