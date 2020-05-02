namespace MKWindowFormApp1
{
    /// <summary>
    /// 描画種類(円、直線、四角)
    /// </summary>
    public enum ShapeMode { Circle, StraightLine, Square, Erase }

    public interface IShapeMode
    {
        void SetShapeMode(ShapeMode shapeMode);
        ShapeMode GetShapeMode();
    }
}
