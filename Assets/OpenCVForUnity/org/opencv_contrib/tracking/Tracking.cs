
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{
    // C++: class Tracking
    //javadoc: Tracking

    public class Tracking
    {

        // C++: enum FeatureType
        public const int CvFeatureParams_HAAR = 0;
        public const int CvFeatureParams_LBP = 1;
        public const int CvFeatureParams_HOG = 2;
        // C++: enum <unnamed>
        public const int TrackerSamplerCSC_MODE_INIT_POS = 1;
        public const int TrackerSamplerCSC_MODE_INIT_NEG = 2;
        public const int TrackerSamplerCSC_MODE_TRACK_POS = 3;
        public const int TrackerSamplerCSC_MODE_TRACK_NEG = 4;
        public const int TrackerSamplerCSC_MODE_DETECT = 5;
        public const int TrackerSamplerCS_MODE_POSITIVE = 1;
        public const int TrackerSamplerCS_MODE_NEGATIVE = 2;
        public const int TrackerSamplerCS_MODE_CLASSIFY = 3;


    }
}
