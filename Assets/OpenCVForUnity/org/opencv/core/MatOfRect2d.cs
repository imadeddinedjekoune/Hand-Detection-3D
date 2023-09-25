using System;
using System.Collections.Generic;

namespace OpenCVForUnity.CoreModule
{
    public class MatOfRect2d : Mat
    {

        // 32SC4
        private const int _depth = CvType.CV_64F;
        private const int _channels = 4;

        public MatOfRect2d()
            : base()
        {

        }

        protected MatOfRect2d(IntPtr addr)
            : base(addr)
        {

            if (!empty() && checkVector(_channels, _depth) < 0)
                throw new CvException("Incompatible Mat");
            //FIXME: do we need release() here?
        }

        public static MatOfRect2d fromNativeAddr(IntPtr addr)
        {
            return new MatOfRect2d(addr);
        }

        public MatOfRect2d(Mat m)
            : base(m, Range.all())
        {

            if (!empty() && checkVector(_channels, _depth) < 0)
                throw new CvException("Incompatible Mat");
            //FIXME: do we need release() here?
        }

        public MatOfRect2d(params Rect2d[] a)
            : base()
        {

            fromArray(a);
        }

        public void alloc(int elemNumber)
        {
            if (elemNumber > 0)
                base.create(elemNumber, 1, CvType.makeType(_depth, _channels));
        }

        public void fromArray(params Rect2d[] a)
        {
            if (a == null || a.Length == 0)
                return;
            int num = a.Length;
            alloc(num);
            double[] buff = new double[num * _channels];
            for (int i = 0; i < num; i++)
            {
                Rect2d r = a[i];
                buff[_channels * i + 0] = (double)r.x;
                buff[_channels * i + 1] = (double)r.y;
                buff[_channels * i + 2] = (double)r.width;
                buff[_channels * i + 3] = (double)r.height;
            }
            put(0, 0, buff); //TODO: check ret val!
        }

        public Rect2d[] toArray()
        {
            int num = (int)total();
            Rect2d[] a = new Rect2d[num];
            if (num == 0)
                return a;
            double[] buff = new double[num * _channels];
            get(0, 0, buff); //TODO: check ret val!
            for (int i = 0; i < num; i++)
                a[i] = new Rect2d(buff[i * _channels], buff[i * _channels + 1], buff[i * _channels + 2], buff[i * _channels + 3]);
            return a;
        }

        public void fromList(List<Rect2d> lr)
        {
            //            Rect2d[] ap = lr.ToArray (new Rect2d[0]);
            Rect2d[] ap = lr.ToArray();
            fromArray(ap);
        }

        public List<Rect2d> toList()
        {
            Rect2d[] ar = toArray();
            return new List<Rect2d>(ar);
        }
    }
}
