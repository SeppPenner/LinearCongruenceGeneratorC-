using System;

namespace LCG
{
    public class LinearCongruenceGenerator
    {
        private long _a;
        private long _b;
        private long _m;
        private long _y;

        public LinearCongruenceGenerator(long m, long a, long b, long y)
        {
            Init(m, a, b, y);
        }

        private void Init(long m, long a, long b, long y)
        {
            if (!CheckForInitError(m, a, b)) SetInit(m, a, b, y);
        }

        private void SetInit(long m, long a, long b, long y)
        {
            _m = m;
            _a = a;
            _b = b;
            _y = y;
        }

        private bool CheckForInitError(long m, long a, long b)
        {
            if (a >= m) throw new TypeLoadException("Parameter a mustn't bee larger or equal to m");
            if (b >= m) throw new TypeLoadException("Parameter b mustn't bee larger or equal to m");
            return false;
        }

        public long NextLong()
        {
            _y = (_a * _y + _b) % _m;
            return _y;
        }

        public int NextInt()
        {
            _y = (_a * _y + _b) % _m;
            return (int) _y;
        }

        public double NextDouble()
        {
            _y = (_a * _y + _b) % _m;
            return _y;
        }
    }
}