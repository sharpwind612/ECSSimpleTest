using Unity.Entities;
using Unity.Mathematics;

//actor data component
struct Actor : IComponentData
{
    public uint ID;
    public float offset;
    public bool bIncrease;
    //public float[] oriPosition;
}
