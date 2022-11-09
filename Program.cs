using System;

namespace tets
{
    class CompNumber
    {
        private int real;
        private int im;

        public CompNumber()
        {
            this.real = 0;
            this.im = 0;
        }
        public CompNumber(int real)
        {
            this.real = real;
            this.im = 0;
        }
        public CompNumber(int real, int im)
        {
            this.real = real;
            this.im = im;
        }

        public static CompNumber operator +(CompNumber z1, CompNumber z2) //+
        {
            return new CompNumber (z1.Real + z2.Real, z1.Im + z2.Im);
        }
        public static CompNumber operator -(CompNumber z1, CompNumber z2) //-
        {
            return new CompNumber(z1.Real - z2.Real, z1.Im - z2.Im);
        }

        public int Real
        {
            get { return real; }
            set { if (value > 0) real = value; }
        }
        public int Im
        {
            get { return im; }
            set { if (value > 0) im = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CompNumber cM1 = new CompNumber(5);
            CompNumber cM2 = new CompNumber(4, 2);

            Console.WriteLine("(" + cM1.Real + "," + cM1.Im + ")");
            Console.WriteLine("(" + cM2.Real + "," + cM2.Im + ")\n");

            CompNumber res = cM1 + cM2;
            Console.WriteLine(res.Real + " " + res.Im + " +");

            res = cM1 - cM2;
            Console.WriteLine(res.Real + " " + res.Im + " -");

            Console.ReadKey();
        }
    }
}