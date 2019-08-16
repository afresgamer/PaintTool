using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKWindowFormApp1
{
    /// <summary>
    /// 描画種類(円、直線、四角)
    /// </summary>
    [Flags]
    public enum ShapeMode { Circle, StraightLine, Square }

    public interface IShapeMode
    {
        void SetShapeMode(ShapeMode shapeMode);
        ShapeMode GetShapeMode();
    }
}
