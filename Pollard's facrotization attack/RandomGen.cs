using System;
using System.Numerics;

namespace Pollard_s_facrotization_attack
{
    public static class RandomGen
    {
        /// <summary>
        /// Возвращает случайное число, которое лежит в заданном диапазоне
        /// </summary>
        public static BigInteger NextBigInteger(BigInteger left, BigInteger right)
        {
            byte[] max = (right - left).ToByteArray();
            int length = max.Length;
            byte[] res = new byte[length];
            Random x = new Random();
            res[length - 1] = Convert.ToByte(x.Next(Convert.ToInt32(max[length - 1])));
            for (int i = 0; i < length - 1; i++)
            {
                res[i] = Convert.ToByte(x.Next(byte.MaxValue + 1));
            }
            return (new BigInteger(res) + left);
        }
    }
}
