﻿using System.Text;

namespace RaceElement.Util.SystemExtensions
{
    public static class IntegerExtensions
    {
        /// <summary>
        /// Sets this value or returns it, clipped by min and max (inclusive)
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int Clip(ref this int value, int min, int max)
        {
            if (value < min) value = min;
            if (value > max) value = max;
            return value;
        }

        /// <summary>
        /// Sets this value or returns it, clipped by max (inclusive)
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int ClipMax(ref this int value, int max)
        {
            if (value > max) value = max;
            return value;
        }

        /// <summary>
        /// Sets this value or returns it, clipped by min (inclusive)
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int ClipMin(ref this int value, int min)
        {
            if (value < min) value = min;
            return value;
        }

        public static string ToString(this int[] values)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < values.Length; i++)
            {
                double v = values[i];
                builder.Append($"{{{v}}}");
                if (i < values.Length - 1)
                    builder.Append(", ");
            }
            return builder.ToString();
        }
    }
}
