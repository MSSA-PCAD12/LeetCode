using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{//https://leetcode.com/problems/add-binary/
    public class AddBinaryLeet
    {
        public string AddBinary(string a, string b)
        {

            int maxLength = Math.Max(a.Length, b.Length);
            a = a.PadLeft(maxLength, '0');
            b = b.PadLeft(maxLength, '0');
            StringBuilder sb = new();
            int carry = 0;
            for (int i = maxLength - 1; i >= 0; i--)
            {
                int result = (a[i] - '0') + (b[i] - '0') + carry;
                if (result > 1) carry = 1; else carry = 0;
                sb.Insert(0, result % 2);
            }

            if (carry == 1) sb.Insert(0, '1');

            return sb.ToString();
        }

        public string AddBinary2(string a, string b)
        {
            string paddedA = "";
            if (a.Length % 8 != 0)
            {
                paddedA = string.Concat(new String('0', 8 - a.Length % 8), a);
            }
            else { paddedA = a; }
            byte[] aBytes = new byte[(paddedA.Length / 8)];
            for (int i = 0; i < aBytes.Length; i++)
            {
                aBytes[i] = Byte.Parse((paddedA[(i * 8)..((i + 1) * 8)]).ToString(), NumberStyles.BinaryNumber);
            }

            string paddedB = "";
            if (b.Length % 8 != 0)
            {
                paddedB = string.Concat(new String('0', b.Length % 8), b);
            }
            else { paddedB = b; }
            byte[] bBytes = new byte[(paddedB.Length / 8)];
            for (int i = 0; i < bBytes.Length; i++)
            {
                bBytes[i] = Byte.Parse((paddedB[(i * 8)..((i + 1) * 8)]).ToString(), NumberStyles.BinaryNumber);
            }
            var bigA = new BigInteger(aBytes);
            var bigB = new BigInteger(bBytes);
            var bigResult = bigA + bigB;

            StringBuilder sb = new StringBuilder();
            while (bigResult > 0)
            {
                sb.Insert(0, (bigResult % 2));
                bigResult /= 2;
            }
            return sb.ToString();
            //base 2 = binary
            //base 16 = hexdecimal
            //base 8
            //base 64
        }
    }
}
