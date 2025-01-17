namespace DroneLoadout.Scripts
{
    /// <summary>
    /// The decorable drone component that each concrete drone class possesses.
    /// Allows for easy modification of data and behaviour at runtime without altering
    /// the object itself.
    /// </summary>
    public interface IDrone
    {
        public float Cost { get; }
        public float Range { get; }
        public float TopSpeed { get; }
        public float Acceleration { get; }
        public float Weight { get; }
        //public void Shoot(Vector3 target);
    }
}
