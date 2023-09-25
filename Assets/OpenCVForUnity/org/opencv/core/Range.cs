using System;
using OpenCVForUnity.UnityUtils;

namespace OpenCVForUnity.CoreModule
{

    /**
     * <p>Template class specifying a continuous subsequence (slice) of a sequence.</p>
     *
     * <p>class CV_EXPORTS Range <code></p>
     *
     * <p>// C++ code:</p>
     *
     *
     * <p>public:</p>
     *
     * <p>Range();</p>
     *
     * <p>Range(int _start, int _end);</p>
     *
     * <p>Range(const CvSlice& slice);</p>
     *
     * <p>int size() const;</p>
     *
     * <p>bool empty() const;</p>
     *
     * <p>static Range all();</p>
     *
     * <p>operator CvSlice() const;</p>
     *
     * <p>int start, end;</p>
     *
     * <p>};</p>
     *
     * <p>The class is used to specify a row or a column span in a matrix (</code></p>
     *
     * <p>"Mat") and for many other purposes. <code>Range(a,b)</code> is basically the
     * same as <code>a:b</code> in Matlab or <code>a..b</code> in Python. As in
     * Python, <code>start</code> is an inclusive left boundary of the range and
     * <code>end</code> is an exclusive right boundary of the range. Such a
     * half-opened interval is usually denoted as <em>[start,end)</em>.
     * The static method <code>Range.all()</code> returns a special variable that
     * means "the whole sequence" or "the whole range", just like " <code>:</code> "
     * in Matlab or " <code>...</code> " in Python. All the methods and functions in
     * OpenCV that take <code>Range</code> support this special <code>Range.all()</code>
     * value. But, of course, in case of your own custom processing, you will
     * probably have to check and handle it explicitly: <code></p>
     *
     * <p>// C++ code:</p>
     *
     * <p>void my_function(..., const Range& r,....)</p>
     *
     *
     * <p>if(r == Range.all()) {</p>
     *
     * <p>// process all the data</p>
     *
     *
     * <p>else {</p>
     *
     * <p>// process [r.start, r.end)</p>
     *
     *
     *
     * <p></code></p>
     *
     * @see <a href="http://docs.opencv.org/modules/core/doc/basic_structures.html#range">org.opencv.core.Range</a>
     */
    [System.Serializable]
    public class Range : IEquatable<Range>
    {

        public int start, end;

        public Range(int s, int e)
        {
            this.start = s;
            this.end = e;
        }

        public Range()
            : this(0, 0)
        {

        }

        public Range(double[] vals)
        {
            set(vals);
        }

        public void set(double[] vals)
        {
            if (vals != null)
            {
                start = vals.Length > 0 ? (int)vals[0] : 0;
                end = vals.Length > 1 ? (int)vals[1] : 0;
            }
            else
            {
                start = 0;
                end = 0;
            }

        }

        public int size()
        {
            return empty() ? 0 : end - start;
        }

        public bool empty()
        {
            return end <= start;
        }

        public static Range all()
        {
            return new Range(int.MinValue, int.MaxValue);


        }

        public Range intersection(Range r1)
        {
            Range r = new Range(Math.Max(r1.start, this.start), Math.Min(r1.end, this.end));
            r.end = Math.Max(r.end, r.start);
            return r;
        }

        public Range shift(int delta)
        {
            return new Range(start + delta, end + delta);
        }

        public Range clone()
        {
            return new Range(start, end);
        }

        //@Override
        public override int GetHashCode()
        {
            const int prime = 31;
            int result = 1;
            long temp;
            temp = BitConverter.DoubleToInt64Bits(start);
            result = prime * result + (int)(temp ^ (Utils.URShift(temp, 32)));
            temp = BitConverter.DoubleToInt64Bits(end);
            result = prime * result + (int)(temp ^ (Utils.URShift(temp, 32)));
            return result;
        }

        //@Override
        public override bool Equals(Object obj)
        {
            if (!(obj is Range))
                return false;
            if ((Range)obj == this)
                return true;

            Range it = (Range)obj;
            return start == it.start && end == it.end;
        }

        //@Override
        public override string ToString()
        {
            return "[" + start + ", " + end + ")";
        }

        //

        #region Operators

        // (here r stand for a range ( Range ), alpha for a real-valued scalar ( int ).)

        #region Unary

        // !r
        public static bool operator !(Range r)
        {
            return r.start == r.end;
        }

        #endregion

        #region Binary

        // r + alpha, alpha + r
        public static Range operator +(Range r1, int delta)
        {
            return new Range(r1.start + delta, r1.end + delta);
        }

        public static Range operator +(int delta, Range r1)
        {
            return new Range(r1.start + delta, r1.end + delta);
        }

        // r - alpha
        public static Range operator -(Range r1, int delta)
        {
            return r1 + (-delta);
        }

        // r & r
        public static Range operator &(Range r1, Range r2)
        {
            Range r = new Range(Math.Max(r1.start, r2.start), Math.Min(r1.end, r2.end));
            r.end = Math.Max(r.end, r.start);
            return r;
        }

        #endregion

        #region Comparison

        public bool Equals(Range a)
        {
            // If both are same instance, return true.
            if (System.Object.ReferenceEquals(this, a))
            {
                return true;
            }

            // If object is null, return false.
            if ((object)a == null)
            {
                return false;
            }

            // Return true if the fields match:
            return this.start == a.start && this.end == a.end;
        }

        // R == R
        public static bool operator ==(Range a, Range b)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            return a.start == b.start && a.end == b.end;
        }

        // R != R
        public static bool operator !=(Range a, Range b)
        {
            return !(a == b);
        }

        #endregion

        #endregion

        //
    }
}
