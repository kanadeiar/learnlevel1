﻿namespace Lesson1Anketa.AnketaFeat.TextFormat;

public class FormatInterpolated : FormatBase
{
    public override TextFormatCode GetCode()
    {
        return TextFormatCode.Interpolated;
    }

    public override string GetText(IPropertiesAnketa anketa)
    {
        return $"{anketa.SurName} {anketa.Name} {anketa.Age} лет {anketa.Height} см {anketa.Weight} кг";
    }
}