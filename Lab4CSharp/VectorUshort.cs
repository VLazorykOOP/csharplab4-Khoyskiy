using System;
namespace Lab4CSharp
{
    public class VectorUshort
    {
        private ushort[] ArrayUShort;
        private uint num;
        private uint codeError;
        private static uint num_vs;

        public VectorUshort()
        {
            this.num = 1;
            ArrayUShort = new uint[num];
            ArrayUShort[0] = 0;
        }
        public VectorUshort(uint num)
        {
            this.num = num;
            ArrayUShort = new ushort[num];
            for (uint i = 0; i < num; i++)
            {
                ArrayUShort[i] = 0;
            }
        }
        public VectorUshort(uint num, uint value)
        {
            this.num = num;
            ArrayUShort = new ushort[num];
            for (uint i = 0; i < num; i++)
            {
                ArrayUShort[i] = value;
            }
        }
        public void Fill()
        {
            Console.WriteLine("g");
        }
    }
};