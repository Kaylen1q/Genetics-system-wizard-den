using Robust.Shared.Serialization;


namespace Content.Shared.DNA
{
    public abstract partial class SharedDNAScannerComponent : Component
    {
        [Serializable, NetSerializable]
        public enum MedicalScannerVisuals : byte
        {
            Status
        }

        [Serializable, NetSerializable]
        public enum MedicalScannerStatus : byte
        {
            Off,
            Open,
            Red,
            Death,
            Green,
            Yellow,
        }
    }
}
