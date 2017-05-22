using System.Drawing;
using System.Windows.Forms;

namespace RFIDIntegratedApplication
{
    interface IAGauge
    {
        bool AllowDrop { get; set; }
        bool AutoSize { get; set; }
        Color BackColor { get; set; }
        ImageLayout BackgroundImageLayout { get; set; }
        Color BaseArcColor { get; set; }
        int BaseArcRadius { get; set; }
        int BaseArcStart { get; set; }
        int BaseArcSweep { get; set; }
        int BaseArcWidth { get; set; }
        byte Cap_Idx { get; set; }
        Color[] CapColors { get; set; }
        Point CapPosition { get; set; }
        Point[] CapsPosition { get; set; }
        string[] CapsText { get; set; }
        string CapText { get; set; }
        Point Center { get; set; }
        Font Font { get; set; }
        bool ForeColor { get; set; }
        bool ImeMode { get; set; }
        float MaxValue { get; set; }
        float MinValue { get; set; }
        AGauge.NeedleColorEnum NeedleColor1 { get; set; }
        Color NeedleColor2 { get; set; }
        int NeedleRadius { get; set; }
        int NeedleType { get; set; }
        int NeedleWidth { get; set; }
        byte Range_Idx { get; set; }
        Color RangeColor { get; set; }
        bool RangeEnabled { get; set; }
        float RangeEndValue { get; set; }
        int RangeInnerRadius { get; set; }
        int RangeOuterRadius { get; set; }
        Color[] RangesColor { get; set; }
        bool[] RangesEnabled { get; set; }
        float[] RangesEndValue { get; set; }
        int[] RangesInnerRadius { get; set; }
        int[] RangesOuterRadius { get; set; }
        float[] RangesStartValue { get; set; }
        float RangeStartValue { get; set; }
        Color ScaleLinesInterColor { get; set; }
        int ScaleLinesInterInnerRadius { get; set; }
        int ScaleLinesInterOuterRadius { get; set; }
        int ScaleLinesInterWidth { get; set; }
        Color ScaleLinesMajorColor { get; set; }
        int ScaleLinesMajorInnerRadius { get; set; }
        int ScaleLinesMajorOuterRadius { get; set; }
        float ScaleLinesMajorStepValue { get; set; }
        int ScaleLinesMajorWidth { get; set; }
        Color ScaleLinesMinorColor { get; set; }
        int ScaleLinesMinorInnerRadius { get; set; }
        int ScaleLinesMinorNumOf { get; set; }
        int ScaleLinesMinorOuterRadius { get; set; }
        int ScaleLinesMinorWidth { get; set; }
        Color ScaleNumbersColor { get; set; }
        string ScaleNumbersFormat { get; set; }
        int ScaleNumbersRadius { get; set; }
        int ScaleNumbersRotation { get; set; }
        int ScaleNumbersStartScaleLine { get; set; }
        int ScaleNumbersStepScaleLines { get; set; }
        float Value { get; set; }

        event AGauge.ValueInRangeChangedDelegate ValueInRangeChanged;
    }
}