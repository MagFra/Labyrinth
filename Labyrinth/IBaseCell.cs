namespace Labyrinth
{
    /// <summary>
    /// Interface that defines the minimum a simplified-/base- Cell is required to support.
    /// </summary>
    public interface IBaseCell
    {
        bool OpensToEast { get; }
        bool OpensToNorth { get; }
        bool OpensToSouth { get; }
        bool OpensToWest { get; }
    }
}