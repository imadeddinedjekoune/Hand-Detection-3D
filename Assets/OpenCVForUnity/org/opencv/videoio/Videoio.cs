
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoioModule
{
    // C++: class Videoio
    //javadoc: Videoio

    public class Videoio
    {

        // C++: enum VideoWriterProperties
        public const int VIDEOWRITER_PROP_QUALITY = 1;
        public const int VIDEOWRITER_PROP_FRAMEBYTES = 2;
        public const int VIDEOWRITER_PROP_NSTRIPES = 3;
        // C++: enum VideoCaptureProperties
        public const int CAP_PROP_POS_MSEC = 0;
        public const int CAP_PROP_POS_FRAMES = 1;
        public const int CAP_PROP_POS_AVI_RATIO = 2;
        public const int CAP_PROP_FRAME_WIDTH = 3;
        public const int CAP_PROP_FRAME_HEIGHT = 4;
        public const int CAP_PROP_FPS = 5;
        public const int CAP_PROP_FOURCC = 6;
        public const int CAP_PROP_FRAME_COUNT = 7;
        public const int CAP_PROP_FORMAT = 8;
        public const int CAP_PROP_MODE = 9;
        public const int CAP_PROP_BRIGHTNESS = 10;
        public const int CAP_PROP_CONTRAST = 11;
        public const int CAP_PROP_SATURATION = 12;
        public const int CAP_PROP_HUE = 13;
        public const int CAP_PROP_GAIN = 14;
        public const int CAP_PROP_EXPOSURE = 15;
        public const int CAP_PROP_CONVERT_RGB = 16;
        public const int CAP_PROP_WHITE_BALANCE_BLUE_U = 17;
        public const int CAP_PROP_RECTIFICATION = 18;
        public const int CAP_PROP_MONOCHROME = 19;
        public const int CAP_PROP_SHARPNESS = 20;
        public const int CAP_PROP_AUTO_EXPOSURE = 21;
        public const int CAP_PROP_GAMMA = 22;
        public const int CAP_PROP_TEMPERATURE = 23;
        public const int CAP_PROP_TRIGGER = 24;
        public const int CAP_PROP_TRIGGER_DELAY = 25;
        public const int CAP_PROP_WHITE_BALANCE_RED_V = 26;
        public const int CAP_PROP_ZOOM = 27;
        public const int CAP_PROP_FOCUS = 28;
        public const int CAP_PROP_GUID = 29;
        public const int CAP_PROP_ISO_SPEED = 30;
        public const int CAP_PROP_BACKLIGHT = 32;
        public const int CAP_PROP_PAN = 33;
        public const int CAP_PROP_TILT = 34;
        public const int CAP_PROP_ROLL = 35;
        public const int CAP_PROP_IRIS = 36;
        public const int CAP_PROP_SETTINGS = 37;
        public const int CAP_PROP_BUFFERSIZE = 38;
        public const int CAP_PROP_AUTOFOCUS = 39;
        public const int CAP_PROP_SAR_NUM = 40;
        public const int CAP_PROP_SAR_DEN = 41;
        public const int CAP_PROP_BACKEND = 42;
        public const int CAP_PROP_CHANNEL = 43;
        public const int CAP_PROP_AUTO_WB = 44;
        public const int CAP_PROP_WB_TEMPERATURE = 45;
        // C++: enum <unnamed>
        public const int CAP_PROP_DC1394_OFF = -4;
        public const int CAP_PROP_DC1394_MODE_MANUAL = -3;
        public const int CAP_PROP_DC1394_MODE_AUTO = -2;
        public const int CAP_PROP_DC1394_MODE_ONE_PUSH_AUTO = -1;
        public const int CAP_PROP_DC1394_MAX = 31;
        public const int CAP_OPENNI_DEPTH_GENERATOR = 1 << 31;
        public const int CAP_OPENNI_IMAGE_GENERATOR = 1 << 30;
        public const int CAP_OPENNI_IR_GENERATOR = 1 << 29;
        public const int CAP_OPENNI_GENERATORS_MASK = CAP_OPENNI_DEPTH_GENERATOR + CAP_OPENNI_IMAGE_GENERATOR + CAP_OPENNI_IR_GENERATOR;
        public const int CAP_PROP_OPENNI_OUTPUT_MODE = 100;
        public const int CAP_PROP_OPENNI_FRAME_MAX_DEPTH = 101;
        public const int CAP_PROP_OPENNI_BASELINE = 102;
        public const int CAP_PROP_OPENNI_FOCAL_LENGTH = 103;
        public const int CAP_PROP_OPENNI_REGISTRATION = 104;
        public const int CAP_PROP_OPENNI_REGISTRATION_ON = CAP_PROP_OPENNI_REGISTRATION;
        public const int CAP_PROP_OPENNI_APPROX_FRAME_SYNC = 105;
        public const int CAP_PROP_OPENNI_MAX_BUFFER_SIZE = 106;
        public const int CAP_PROP_OPENNI_CIRCLE_BUFFER = 107;
        public const int CAP_PROP_OPENNI_MAX_TIME_DURATION = 108;
        public const int CAP_PROP_OPENNI_GENERATOR_PRESENT = 109;
        public const int CAP_PROP_OPENNI2_SYNC = 110;
        public const int CAP_PROP_OPENNI2_MIRROR = 111;
        public const int CAP_OPENNI_IMAGE_GENERATOR_PRESENT = CAP_OPENNI_IMAGE_GENERATOR + CAP_PROP_OPENNI_GENERATOR_PRESENT;
        public const int CAP_OPENNI_IMAGE_GENERATOR_OUTPUT_MODE = CAP_OPENNI_IMAGE_GENERATOR + CAP_PROP_OPENNI_OUTPUT_MODE;
        public const int CAP_OPENNI_DEPTH_GENERATOR_PRESENT = CAP_OPENNI_DEPTH_GENERATOR + CAP_PROP_OPENNI_GENERATOR_PRESENT;
        public const int CAP_OPENNI_DEPTH_GENERATOR_BASELINE = CAP_OPENNI_DEPTH_GENERATOR + CAP_PROP_OPENNI_BASELINE;
        public const int CAP_OPENNI_DEPTH_GENERATOR_FOCAL_LENGTH = CAP_OPENNI_DEPTH_GENERATOR + CAP_PROP_OPENNI_FOCAL_LENGTH;
        public const int CAP_OPENNI_DEPTH_GENERATOR_REGISTRATION = CAP_OPENNI_DEPTH_GENERATOR + CAP_PROP_OPENNI_REGISTRATION;
        public const int CAP_OPENNI_DEPTH_GENERATOR_REGISTRATION_ON = CAP_OPENNI_DEPTH_GENERATOR_REGISTRATION;
        public const int CAP_OPENNI_IR_GENERATOR_PRESENT = CAP_OPENNI_IR_GENERATOR + CAP_PROP_OPENNI_GENERATOR_PRESENT;
        public const int CAP_OPENNI_DEPTH_MAP = 0;
        public const int CAP_OPENNI_POINT_CLOUD_MAP = 1;
        public const int CAP_OPENNI_DISPARITY_MAP = 2;
        public const int CAP_OPENNI_DISPARITY_MAP_32F = 3;
        public const int CAP_OPENNI_VALID_DEPTH_MASK = 4;
        public const int CAP_OPENNI_BGR_IMAGE = 5;
        public const int CAP_OPENNI_GRAY_IMAGE = 6;
        public const int CAP_OPENNI_IR_IMAGE = 7;
        public const int CAP_OPENNI_VGA_30HZ = 0;
        public const int CAP_OPENNI_SXGA_15HZ = 1;
        public const int CAP_OPENNI_SXGA_30HZ = 2;
        public const int CAP_OPENNI_QVGA_30HZ = 3;
        public const int CAP_OPENNI_QVGA_60HZ = 4;
        public const int CAP_PROP_GSTREAMER_QUEUE_LENGTH = 200;
        public const int CAP_PROP_PVAPI_MULTICASTIP = 300;
        public const int CAP_PROP_PVAPI_FRAMESTARTTRIGGERMODE = 301;
        public const int CAP_PROP_PVAPI_DECIMATIONHORIZONTAL = 302;
        public const int CAP_PROP_PVAPI_DECIMATIONVERTICAL = 303;
        public const int CAP_PROP_PVAPI_BINNINGX = 304;
        public const int CAP_PROP_PVAPI_BINNINGY = 305;
        public const int CAP_PROP_PVAPI_PIXELFORMAT = 306;
        public const int CAP_PVAPI_FSTRIGMODE_FREERUN = 0;
        public const int CAP_PVAPI_FSTRIGMODE_SYNCIN1 = 1;
        public const int CAP_PVAPI_FSTRIGMODE_SYNCIN2 = 2;
        public const int CAP_PVAPI_FSTRIGMODE_FIXEDRATE = 3;
        public const int CAP_PVAPI_FSTRIGMODE_SOFTWARE = 4;
        public const int CAP_PVAPI_DECIMATION_OFF = 1;
        public const int CAP_PVAPI_DECIMATION_2OUTOF4 = 2;
        public const int CAP_PVAPI_DECIMATION_2OUTOF8 = 4;
        public const int CAP_PVAPI_DECIMATION_2OUTOF16 = 8;
        public const int CAP_PVAPI_PIXELFORMAT_MONO8 = 1;
        public const int CAP_PVAPI_PIXELFORMAT_MONO16 = 2;
        public const int CAP_PVAPI_PIXELFORMAT_BAYER8 = 3;
        public const int CAP_PVAPI_PIXELFORMAT_BAYER16 = 4;
        public const int CAP_PVAPI_PIXELFORMAT_RGB24 = 5;
        public const int CAP_PVAPI_PIXELFORMAT_BGR24 = 6;
        public const int CAP_PVAPI_PIXELFORMAT_RGBA32 = 7;
        public const int CAP_PVAPI_PIXELFORMAT_BGRA32 = 8;
        public const int CAP_PROP_XI_DOWNSAMPLING = 400;
        public const int CAP_PROP_XI_DATA_FORMAT = 401;
        public const int CAP_PROP_XI_OFFSET_X = 402;
        public const int CAP_PROP_XI_OFFSET_Y = 403;
        public const int CAP_PROP_XI_TRG_SOURCE = 404;
        public const int CAP_PROP_XI_TRG_SOFTWARE = 405;
        public const int CAP_PROP_XI_GPI_SELECTOR = 406;
        public const int CAP_PROP_XI_GPI_MODE = 407;
        public const int CAP_PROP_XI_GPI_LEVEL = 408;
        public const int CAP_PROP_XI_GPO_SELECTOR = 409;
        public const int CAP_PROP_XI_GPO_MODE = 410;
        public const int CAP_PROP_XI_LED_SELECTOR = 411;
        public const int CAP_PROP_XI_LED_MODE = 412;
        public const int CAP_PROP_XI_MANUAL_WB = 413;
        public const int CAP_PROP_XI_AUTO_WB = 414;
        public const int CAP_PROP_XI_AEAG = 415;
        public const int CAP_PROP_XI_EXP_PRIORITY = 416;
        public const int CAP_PROP_XI_AE_MAX_LIMIT = 417;
        public const int CAP_PROP_XI_AG_MAX_LIMIT = 418;
        public const int CAP_PROP_XI_AEAG_LEVEL = 419;
        public const int CAP_PROP_XI_TIMEOUT = 420;
        public const int CAP_PROP_XI_EXPOSURE = 421;
        public const int CAP_PROP_XI_EXPOSURE_BURST_COUNT = 422;
        public const int CAP_PROP_XI_GAIN_SELECTOR = 423;
        public const int CAP_PROP_XI_GAIN = 424;
        public const int CAP_PROP_XI_DOWNSAMPLING_TYPE = 426;
        public const int CAP_PROP_XI_BINNING_SELECTOR = 427;
        public const int CAP_PROP_XI_BINNING_VERTICAL = 428;
        public const int CAP_PROP_XI_BINNING_HORIZONTAL = 429;
        public const int CAP_PROP_XI_BINNING_PATTERN = 430;
        public const int CAP_PROP_XI_DECIMATION_SELECTOR = 431;
        public const int CAP_PROP_XI_DECIMATION_VERTICAL = 432;
        public const int CAP_PROP_XI_DECIMATION_HORIZONTAL = 433;
        public const int CAP_PROP_XI_DECIMATION_PATTERN = 434;
        public const int CAP_PROP_XI_TEST_PATTERN_GENERATOR_SELECTOR = 587;
        public const int CAP_PROP_XI_TEST_PATTERN = 588;
        public const int CAP_PROP_XI_IMAGE_DATA_FORMAT = 435;
        public const int CAP_PROP_XI_SHUTTER_TYPE = 436;
        public const int CAP_PROP_XI_SENSOR_TAPS = 437;
        public const int CAP_PROP_XI_AEAG_ROI_OFFSET_X = 439;
        public const int CAP_PROP_XI_AEAG_ROI_OFFSET_Y = 440;
        public const int CAP_PROP_XI_AEAG_ROI_WIDTH = 441;
        public const int CAP_PROP_XI_AEAG_ROI_HEIGHT = 442;
        public const int CAP_PROP_XI_BPC = 445;
        public const int CAP_PROP_XI_WB_KR = 448;
        public const int CAP_PROP_XI_WB_KG = 449;
        public const int CAP_PROP_XI_WB_KB = 450;
        public const int CAP_PROP_XI_WIDTH = 451;
        public const int CAP_PROP_XI_HEIGHT = 452;
        public const int CAP_PROP_XI_REGION_SELECTOR = 589;
        public const int CAP_PROP_XI_REGION_MODE = 595;
        public const int CAP_PROP_XI_LIMIT_BANDWIDTH = 459;
        public const int CAP_PROP_XI_SENSOR_DATA_BIT_DEPTH = 460;
        public const int CAP_PROP_XI_OUTPUT_DATA_BIT_DEPTH = 461;
        public const int CAP_PROP_XI_IMAGE_DATA_BIT_DEPTH = 462;
        public const int CAP_PROP_XI_OUTPUT_DATA_PACKING = 463;
        public const int CAP_PROP_XI_OUTPUT_DATA_PACKING_TYPE = 464;
        public const int CAP_PROP_XI_IS_COOLED = 465;
        public const int CAP_PROP_XI_COOLING = 466;
        public const int CAP_PROP_XI_TARGET_TEMP = 467;
        public const int CAP_PROP_XI_CHIP_TEMP = 468;
        public const int CAP_PROP_XI_HOUS_TEMP = 469;
        public const int CAP_PROP_XI_HOUS_BACK_SIDE_TEMP = 590;
        public const int CAP_PROP_XI_SENSOR_BOARD_TEMP = 596;
        public const int CAP_PROP_XI_CMS = 470;
        public const int CAP_PROP_XI_APPLY_CMS = 471;
        public const int CAP_PROP_XI_IMAGE_IS_COLOR = 474;
        public const int CAP_PROP_XI_COLOR_FILTER_ARRAY = 475;
        public const int CAP_PROP_XI_GAMMAY = 476;
        public const int CAP_PROP_XI_GAMMAC = 477;
        public const int CAP_PROP_XI_SHARPNESS = 478;
        public const int CAP_PROP_XI_CC_MATRIX_00 = 479;
        public const int CAP_PROP_XI_CC_MATRIX_01 = 480;
        public const int CAP_PROP_XI_CC_MATRIX_02 = 481;
        public const int CAP_PROP_XI_CC_MATRIX_03 = 482;
        public const int CAP_PROP_XI_CC_MATRIX_10 = 483;
        public const int CAP_PROP_XI_CC_MATRIX_11 = 484;
        public const int CAP_PROP_XI_CC_MATRIX_12 = 485;
        public const int CAP_PROP_XI_CC_MATRIX_13 = 486;
        public const int CAP_PROP_XI_CC_MATRIX_20 = 487;
        public const int CAP_PROP_XI_CC_MATRIX_21 = 488;
        public const int CAP_PROP_XI_CC_MATRIX_22 = 489;
        public const int CAP_PROP_XI_CC_MATRIX_23 = 490;
        public const int CAP_PROP_XI_CC_MATRIX_30 = 491;
        public const int CAP_PROP_XI_CC_MATRIX_31 = 492;
        public const int CAP_PROP_XI_CC_MATRIX_32 = 493;
        public const int CAP_PROP_XI_CC_MATRIX_33 = 494;
        public const int CAP_PROP_XI_DEFAULT_CC_MATRIX = 495;
        public const int CAP_PROP_XI_TRG_SELECTOR = 498;
        public const int CAP_PROP_XI_ACQ_FRAME_BURST_COUNT = 499;
        public const int CAP_PROP_XI_DEBOUNCE_EN = 507;
        public const int CAP_PROP_XI_DEBOUNCE_T0 = 508;
        public const int CAP_PROP_XI_DEBOUNCE_T1 = 509;
        public const int CAP_PROP_XI_DEBOUNCE_POL = 510;
        public const int CAP_PROP_XI_LENS_MODE = 511;
        public const int CAP_PROP_XI_LENS_APERTURE_VALUE = 512;
        public const int CAP_PROP_XI_LENS_FOCUS_MOVEMENT_VALUE = 513;
        public const int CAP_PROP_XI_LENS_FOCUS_MOVE = 514;
        public const int CAP_PROP_XI_LENS_FOCUS_DISTANCE = 515;
        public const int CAP_PROP_XI_LENS_FOCAL_LENGTH = 516;
        public const int CAP_PROP_XI_LENS_FEATURE_SELECTOR = 517;
        public const int CAP_PROP_XI_LENS_FEATURE = 518;
        public const int CAP_PROP_XI_DEVICE_MODEL_ID = 521;
        public const int CAP_PROP_XI_DEVICE_SN = 522;
        public const int CAP_PROP_XI_IMAGE_DATA_FORMAT_RGB32_ALPHA = 529;
        public const int CAP_PROP_XI_IMAGE_PAYLOAD_SIZE = 530;
        public const int CAP_PROP_XI_TRANSPORT_PIXEL_FORMAT = 531;
        public const int CAP_PROP_XI_SENSOR_CLOCK_FREQ_HZ = 532;
        public const int CAP_PROP_XI_SENSOR_CLOCK_FREQ_INDEX = 533;
        public const int CAP_PROP_XI_SENSOR_OUTPUT_CHANNEL_COUNT = 534;
        public const int CAP_PROP_XI_FRAMERATE = 535;
        public const int CAP_PROP_XI_COUNTER_SELECTOR = 536;
        public const int CAP_PROP_XI_COUNTER_VALUE = 537;
        public const int CAP_PROP_XI_ACQ_TIMING_MODE = 538;
        public const int CAP_PROP_XI_AVAILABLE_BANDWIDTH = 539;
        public const int CAP_PROP_XI_BUFFER_POLICY = 540;
        public const int CAP_PROP_XI_LUT_EN = 541;
        public const int CAP_PROP_XI_LUT_INDEX = 542;
        public const int CAP_PROP_XI_LUT_VALUE = 543;
        public const int CAP_PROP_XI_TRG_DELAY = 544;
        public const int CAP_PROP_XI_TS_RST_MODE = 545;
        public const int CAP_PROP_XI_TS_RST_SOURCE = 546;
        public const int CAP_PROP_XI_IS_DEVICE_EXIST = 547;
        public const int CAP_PROP_XI_ACQ_BUFFER_SIZE = 548;
        public const int CAP_PROP_XI_ACQ_BUFFER_SIZE_UNIT = 549;
        public const int CAP_PROP_XI_ACQ_TRANSPORT_BUFFER_SIZE = 550;
        public const int CAP_PROP_XI_BUFFERS_QUEUE_SIZE = 551;
        public const int CAP_PROP_XI_ACQ_TRANSPORT_BUFFER_COMMIT = 552;
        public const int CAP_PROP_XI_RECENT_FRAME = 553;
        public const int CAP_PROP_XI_DEVICE_RESET = 554;
        public const int CAP_PROP_XI_COLUMN_FPN_CORRECTION = 555;
        public const int CAP_PROP_XI_ROW_FPN_CORRECTION = 591;
        public const int CAP_PROP_XI_SENSOR_MODE = 558;
        public const int CAP_PROP_XI_HDR = 559;
        public const int CAP_PROP_XI_HDR_KNEEPOINT_COUNT = 560;
        public const int CAP_PROP_XI_HDR_T1 = 561;
        public const int CAP_PROP_XI_HDR_T2 = 562;
        public const int CAP_PROP_XI_KNEEPOINT1 = 563;
        public const int CAP_PROP_XI_KNEEPOINT2 = 564;
        public const int CAP_PROP_XI_IMAGE_BLACK_LEVEL = 565;
        public const int CAP_PROP_XI_HW_REVISION = 571;
        public const int CAP_PROP_XI_DEBUG_LEVEL = 572;
        public const int CAP_PROP_XI_AUTO_BANDWIDTH_CALCULATION = 573;
        public const int CAP_PROP_XI_FFS_FILE_ID = 594;
        public const int CAP_PROP_XI_FFS_FILE_SIZE = 580;
        public const int CAP_PROP_XI_FREE_FFS_SIZE = 581;
        public const int CAP_PROP_XI_USED_FFS_SIZE = 582;
        public const int CAP_PROP_XI_FFS_ACCESS_KEY = 583;
        public const int CAP_PROP_XI_SENSOR_FEATURE_SELECTOR = 585;
        public const int CAP_PROP_XI_SENSOR_FEATURE_VALUE = 586;
        public const int CAP_PROP_IOS_DEVICE_FOCUS = 9001;
        public const int CAP_PROP_IOS_DEVICE_EXPOSURE = 9002;
        public const int CAP_PROP_IOS_DEVICE_FLASH = 9003;
        public const int CAP_PROP_IOS_DEVICE_WHITEBALANCE = 9004;
        public const int CAP_PROP_IOS_DEVICE_TORCH = 9005;
        public const int CAP_PROP_GIGA_FRAME_OFFSET_X = 10001;
        public const int CAP_PROP_GIGA_FRAME_OFFSET_Y = 10002;
        public const int CAP_PROP_GIGA_FRAME_WIDTH_MAX = 10003;
        public const int CAP_PROP_GIGA_FRAME_HEIGH_MAX = 10004;
        public const int CAP_PROP_GIGA_FRAME_SENS_WIDTH = 10005;
        public const int CAP_PROP_GIGA_FRAME_SENS_HEIGH = 10006;
        public const int CAP_PROP_INTELPERC_PROFILE_COUNT = 11001;
        public const int CAP_PROP_INTELPERC_PROFILE_IDX = 11002;
        public const int CAP_PROP_INTELPERC_DEPTH_LOW_CONFIDENCE_VALUE = 11003;
        public const int CAP_PROP_INTELPERC_DEPTH_SATURATION_VALUE = 11004;
        public const int CAP_PROP_INTELPERC_DEPTH_CONFIDENCE_THRESHOLD = 11005;
        public const int CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_HORZ = 11006;
        public const int CAP_PROP_INTELPERC_DEPTH_FOCAL_LENGTH_VERT = 11007;
        public const int CAP_INTELPERC_DEPTH_GENERATOR = 1 << 29;
        public const int CAP_INTELPERC_IMAGE_GENERATOR = 1 << 28;
        public const int CAP_INTELPERC_IR_GENERATOR = 1 << 27;
        public const int CAP_INTELPERC_GENERATORS_MASK = CAP_INTELPERC_DEPTH_GENERATOR + CAP_INTELPERC_IMAGE_GENERATOR + CAP_INTELPERC_IR_GENERATOR;
        public const int CAP_INTELPERC_DEPTH_MAP = 0;
        public const int CAP_INTELPERC_UVDEPTH_MAP = 1;
        public const int CAP_INTELPERC_IR_MAP = 2;
        public const int CAP_INTELPERC_IMAGE = 3;
        public const int CAP_PROP_GPHOTO2_PREVIEW = 17001;
        public const int CAP_PROP_GPHOTO2_WIDGET_ENUMERATE = 17002;
        public const int CAP_PROP_GPHOTO2_RELOAD_CONFIG = 17003;
        public const int CAP_PROP_GPHOTO2_RELOAD_ON_CHANGE = 17004;
        public const int CAP_PROP_GPHOTO2_COLLECT_MSGS = 17005;
        public const int CAP_PROP_GPHOTO2_FLUSH_MSGS = 17006;
        public const int CAP_PROP_SPEED = 17007;
        public const int CAP_PROP_APERTURE = 17008;
        public const int CAP_PROP_EXPOSUREPROGRAM = 17009;
        public const int CAP_PROP_VIEWFINDER = 17010;
        public const int CAP_PROP_IMAGES_BASE = 18000;
        public const int CAP_PROP_IMAGES_LAST = 19000;
        // C++: enum VideoCaptureAPIs
        public const int CAP_ANY = 0;
        public const int CAP_VFW = 200;
        public const int CAP_V4L = 200;
        public const int CAP_V4L2 = CAP_V4L;
        public const int CAP_FIREWIRE = 300;
        public const int CAP_FIREWARE = CAP_FIREWIRE;
        public const int CAP_IEEE1394 = CAP_FIREWIRE;
        public const int CAP_DC1394 = CAP_FIREWIRE;
        public const int CAP_CMU1394 = CAP_FIREWIRE;
        public const int CAP_QT = 500;
        public const int CAP_UNICAP = 600;
        public const int CAP_DSHOW = 700;
        public const int CAP_PVAPI = 800;
        public const int CAP_OPENNI = 900;
        public const int CAP_OPENNI_ASUS = 910;
        public const int CAP_ANDROID = 1000;
        public const int CAP_XIAPI = 1100;
        public const int CAP_AVFOUNDATION = 1200;
        public const int CAP_GIGANETIX = 1300;
        public const int CAP_MSMF = 1400;
        public const int CAP_WINRT = 1410;
        public const int CAP_INTELPERC = 1500;
        public const int CAP_REALSENSE = 1500;
        public const int CAP_OPENNI2 = 1600;
        public const int CAP_OPENNI2_ASUS = 1610;
        public const int CAP_GPHOTO2 = 1700;
        public const int CAP_GSTREAMER = 1800;
        public const int CAP_FFMPEG = 1900;
        public const int CAP_IMAGES = 2000;
        public const int CAP_ARAVIS = 2100;
        public const int CAP_OPENCV_MJPEG = 2200;
        public const int CAP_INTEL_MFX = 2300;
        public const int CAP_XINE = 2400;
        //
        // C++:  String cv::videoio_registry::getBackendName(VideoCaptureAPIs api)
        //

        //javadoc: getBackendName(api)
        public static string getBackendName(int api)
        {
#if UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (videoio_Videoio_getBackendName_10(api));
        
        return retVal;
#else
            return null;
#endif
        }


        //
        // C++:  vector_VideoCaptureAPIs cv::videoio_registry::getBackends()
        //

        // Return type 'vector_VideoCaptureAPIs' is not supported, skipping the function


        //
        // C++:  vector_VideoCaptureAPIs cv::videoio_registry::getCameraBackends()
        //

        // Return type 'vector_VideoCaptureAPIs' is not supported, skipping the function


        //
        // C++:  vector_VideoCaptureAPIs cv::videoio_registry::getStreamBackends()
        //

        // Return type 'vector_VideoCaptureAPIs' is not supported, skipping the function


        //
        // C++:  vector_VideoCaptureAPIs cv::videoio_registry::getWriterBackends()
        //

        // Return type 'vector_VideoCaptureAPIs' is not supported, skipping the function


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  String cv::videoio_registry::getBackendName(VideoCaptureAPIs api)
        [DllImport(LIBNAME)]
        private static extern IntPtr videoio_Videoio_getBackendName_10(int api);

    }
}
