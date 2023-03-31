using UnityEngine;
using Unity.Entities;
using RTSForEntities.Components;

namespace Authoring {
    public class UnitMovementAuthoring : MonoBehaviour {
        public float speed;
    }

    public class UnitMovementBaker : Baker<UnitMovementAuthoring> {
        public override void Bake(UnitMovementAuthoring authoring) {
            var entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent(entity, new UnitMovement {
                speed = authoring.speed
            });
        }
    }
}