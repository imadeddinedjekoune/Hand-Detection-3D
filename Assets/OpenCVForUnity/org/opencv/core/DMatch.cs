using System;

namespace OpenCVForUnity.CoreModule
{

    //C++: class DMatch

    /**
     * Structure for matching: query descriptor index, train descriptor index, train
     * image index and distance between descriptors.
     */
    public class DMatch
    {

        /**
     * Query descriptor index.
     */
        public int queryIdx;
        /**
     * Train descriptor index.
     */
        public int trainIdx;
        /**
     * Train image index.
     */
        public int imgIdx;
        public float distance;

        public DMatch()
            : this(-1, -1, float.MaxValue)
        {

        }

        public DMatch(int _queryIdx, int _trainIdx, float _distance)
        {
            queryIdx = _queryIdx;
            trainIdx = _trainIdx;
            imgIdx = -1;
            distance = _distance;
        }

        public DMatch(int _queryIdx, int _trainIdx, int _imgIdx, float _distance)
        {
            queryIdx = _queryIdx;
            trainIdx = _trainIdx;
            imgIdx = _imgIdx;
            distance = _distance;
        }

        public bool lessThan(DMatch it)
        {
            return distance < it.distance;
        }

        //@Override
        public override string ToString()
        {
            return "DMatch [queryIdx=" + queryIdx + ", trainIdx=" + trainIdx
                + ", imgIdx=" + imgIdx + ", distance=" + distance + "]";
        }

        //
        #region Operators

        // (here D stand for a dmatch ( DMatch ).)

        #region Comparison
        // D < D
        public static bool operator <(DMatch d1, DMatch d2)
        {
            return d1.distance < d2.distance;
        }

        // D > D
        public static bool operator >(DMatch d1, DMatch d2)
        {
            return d1.distance > d2.distance;
        }
        #endregion

        #endregion
        //
    }
}

