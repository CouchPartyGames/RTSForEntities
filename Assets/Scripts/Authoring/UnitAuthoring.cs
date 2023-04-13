using UnityEngine;
using Unity.Entities;

public class UnitAuthoring : MonoBehaviour {
    public GameObject Prefab;
}

public class UnitBaker : Baker<UnitAuthoring> {
    public override void Bake(UnitAuthoring authoring) {
        var entity = GetEntity(TransformUsageFlags.Dynamic);
    }
}


