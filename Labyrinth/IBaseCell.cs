namespace Labyrinth
{
    public interface IBaseCell
    {
        bool OpenEast { get; }
        bool OpenNorth { get; }
        bool OpenSouth { get; }
        bool OpenWest { get; }
    }
}