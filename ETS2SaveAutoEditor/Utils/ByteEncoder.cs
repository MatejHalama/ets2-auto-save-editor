using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ASE.Utils {
    public enum ByteOrder {
        BigEndian,
        LittleEndian
    }

    public class ByteEncoder {
        public static byte[] EncodeInt16(short a, ByteOrder endian = ByteOrder.LittleEndian) {
            var buf = BitConverter.GetBytes(a);
            if(BitConverter.IsLittleEndian != (endian == ByteOrder.LittleEndian)) {
                Array.Reverse(buf);
            }
            return buf;
        }

        public static byte[] EncodeUInt16(ushort a, ByteOrder endian = ByteOrder.LittleEndian) {
            var buf = BitConverter.GetBytes(a);
            if (BitConverter.IsLittleEndian != (endian == ByteOrder.LittleEndian)) {
                Array.Reverse(buf);
            }
            return buf;
        }

        public static byte[] EncodeInt32(int a, ByteOrder endian = ByteOrder.LittleEndian) {
            var buf = BitConverter.GetBytes(a);
            if (BitConverter.IsLittleEndian != (endian == ByteOrder.LittleEndian)) {
                Array.Reverse(buf);
            }
            return buf;
        }

        public static byte[] EncodeUInt32(uint a, ByteOrder endian = ByteOrder.LittleEndian) {
            var buf = BitConverter.GetBytes(a);
            if (BitConverter.IsLittleEndian != (endian == ByteOrder.LittleEndian)) {
                Array.Reverse(buf);
            }
            return buf;
        }

        public static byte[] EncodeInt64(long a, ByteOrder endian = ByteOrder.LittleEndian) {
            var buf = BitConverter.GetBytes(a);
            if (BitConverter.IsLittleEndian != (endian == ByteOrder.LittleEndian)) {
                Array.Reverse(buf);
            }
            return buf;
        }

        public static byte[] EncodeUInt64(ulong a, ByteOrder endian = ByteOrder.LittleEndian) {
            var buf = BitConverter.GetBytes(a);
            if (BitConverter.IsLittleEndian != (endian == ByteOrder.LittleEndian)) {
                Array.Reverse(buf);
            }
            return buf;
        }

        public static byte[] EncodeInt128(Int128 a, ByteOrder endian = ByteOrder.LittleEndian) {
            var buf = new byte[16];
            for (int i = 0; i < 16; i++) {
                buf[i] = (byte)(a & 0xFF);
                a >>= 8;
            }
            if(endian == ByteOrder.LittleEndian) {
                Array.Reverse(buf);
            }
            return buf;
        }

        public static byte[] EncodeUInt128(UInt128 a, ByteOrder endian = ByteOrder.LittleEndian) {
            var buf = new byte[16];
            for (int i = 0; i < 16; i++) {
                buf[i] = (byte)(a & 0xFF);
                a >>= 8;
            }
            if (endian == ByteOrder.LittleEndian) {
                Array.Reverse(buf);
            }
            return buf;
        }

        public static short DecodeInt16(Span<byte> buf, ByteOrder endian = ByteOrder.LittleEndian) {
            return endian == ByteOrder.LittleEndian ? BinaryPrimitives.ReadInt16LittleEndian(buf) : BinaryPrimitives.ReadInt16BigEndian(buf);
        }

        public static ushort DecodeUInt16(Span<byte> buf, ByteOrder endian = ByteOrder.LittleEndian) {
            return endian == ByteOrder.LittleEndian ? BinaryPrimitives.ReadUInt16LittleEndian(buf) : BinaryPrimitives.ReadUInt16BigEndian(buf);
        }

        public static int DecodeInt32(Span<byte> buf, ByteOrder endian = ByteOrder.LittleEndian) {
            return endian == ByteOrder.LittleEndian ? BinaryPrimitives.ReadInt32LittleEndian(buf) : BinaryPrimitives.ReadInt32BigEndian(buf);
        }

        public static uint DecodeUInt32(Span<byte> buf, ByteOrder endian = ByteOrder.LittleEndian) {
            return endian == ByteOrder.LittleEndian ? BinaryPrimitives.ReadUInt32LittleEndian(buf) : BinaryPrimitives.ReadUInt32BigEndian(buf);
        }

        public static long DecodeInt64(Span<byte> buf, ByteOrder endian = ByteOrder.LittleEndian) {
            return endian == ByteOrder.LittleEndian ? BinaryPrimitives.ReadInt64LittleEndian(buf) : BinaryPrimitives.ReadInt64BigEndian(buf);
        }

        public static ulong DecodeUInt64(Span<byte> buf, ByteOrder endian = ByteOrder.LittleEndian) {
            return endian == ByteOrder.LittleEndian ? BinaryPrimitives.ReadUInt64LittleEndian(buf) : BinaryPrimitives.ReadUInt64BigEndian(buf);
        }

        public static Int128 DecodeInt128(Span<byte> buf, ByteOrder endian = ByteOrder.LittleEndian) {
            return endian == ByteOrder.LittleEndian ? BinaryPrimitives.ReadInt128LittleEndian(buf) : BinaryPrimitives.ReadInt128BigEndian(buf);
        }

        public static UInt128 DecodeUInt128(Span<byte> buf, ByteOrder endian = ByteOrder.LittleEndian) {
            return endian == ByteOrder.LittleEndian ? BinaryPrimitives.ReadUInt128LittleEndian(buf) : BinaryPrimitives.ReadUInt128BigEndian(buf);
        }

        public static byte[] EncodeFloat(float a, ByteOrder endian = ByteOrder.LittleEndian) {
            var buf = BitConverter.GetBytes(a);
            if (BitConverter.IsLittleEndian != (endian == ByteOrder.LittleEndian)) {
                Array.Reverse(buf);
            }
            return buf;
        }

        public static byte[] EncodeDouble(double a, ByteOrder endian = ByteOrder.LittleEndian) {
            var buf = BitConverter.GetBytes(a);
            if (BitConverter.IsLittleEndian != (endian == ByteOrder.LittleEndian)) {
                Array.Reverse(buf);
            }
            return buf;
        }

        public static float DecodeFloat(Span<byte> buf, ByteOrder endian = ByteOrder.LittleEndian) {
            return endian == ByteOrder.LittleEndian ? BinaryPrimitives.ReadSingleLittleEndian(buf) : BinaryPrimitives.ReadSingleBigEndian(buf);
        }

        public static double DecodeDouble(Span<byte> buf, ByteOrder endian = ByteOrder.LittleEndian) {
            return endian == ByteOrder.LittleEndian ? BinaryPrimitives.ReadDoubleLittleEndian(buf) : BinaryPrimitives.ReadDoubleBigEndian(buf);
        }
    }
}