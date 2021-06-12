using System;

public class Physics
{
    //X,Y velocities, between 0 - 1
    private float[] velocity = new float[2];
    Subject subject;

    public float GetXVelocity => velocity[0];
    public float GetYVelocity => velocity[1]; 
    public enum PhysicsEvent
    {

        ON_LAND, 
        IN_AIR,
        IN_WATER
    }
    
}