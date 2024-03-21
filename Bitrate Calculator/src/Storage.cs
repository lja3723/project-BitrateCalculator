using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitrate_Calculator.src
{
    internal class Storage
    {
        //원본영상 파일정보
        private int hour;
        private int min;
        private int sec;
        private int width;
        private int height;
        private int fps;
        private int audioBitrate;
        private Codecs codec;

        //영상 비트레이트
        private PersecUnit maxBitrateUnit;
        private FilesizeUnit calcOutputVidSizeUnit;

        //출력 영상 크기 기준 영상 비트레이트 계산
        private FilesizeUnit expectedOutputVidSizeUnit;
        private int expectedOutputVidSize;
        private PersecUnit expectedOutputBitrateUnit;

        //해상도 변환
        private ConvertResolutionBase convertResolutionBase;
        private int convertResolutionSize;
        private FilesizeUnit convertedVideoSizeUnit;

        public Storage()
        {
            this.hour = 0;
            this.min = 0;
            this.sec = 0;
            this.width = 0;
            this.Height = 0;
            this.fps = 0;
            this.audioBitrate = 0;
            this.codec = CodecsHelper.Default;
                
            this.maxBitrateUnit = PersecUnitHelper.Default;
            this.calcOutputVidSizeUnit = FilesizeUnitHelper.Default;

            this.expectedOutputVidSizeUnit = FilesizeUnitHelper.Default;
            this.expectedOutputVidSize = 0;
            this.expectedOutputBitrateUnit = PersecUnitHelper.Default;

            this.convertResolutionBase = ConvertResolutionBaseHelper.Default;
            this.convertResolutionSize = 0;
            this.convertedVideoSizeUnit = FilesizeUnitHelper.Default;
        }

        //원본영상 파일정보
        public int Hour {
            get {
                return hour;
            }
            set {

            }
        }
        public int Min {
            get {
                return 0;
            }
            set {}
        }
        public int Sec {
            get {
                return 0;
            }
            set {}
        }
        public int Width {
            get {
                return 0;
            }
            set { }
        }
        public int Height
        {
            get
            {
                return 0;
            }
            set { }
        }
        public int Fps {
            get {
                return 0;
            }
            set {}
        }
        public int AudioBitrate {
            get {
                return 0;
            }
            set {}
        }
        public Codecs Codec {
            get {
                return 0;
            }
            set {}
        }


        //영상 비트레이트
        public PersecUnit MaxBitrateUnit {
            get {
                return 0;
            }
            set {}
        }
        public FilesizeUnit CalcOutputVidSizeUnit {
            get {
                return 0;
            }
            set {}
        }


        //출력 영상 크기 기준 영상 비트레이트 계산
        public FilesizeUnit ExpectedOutputVidSizeUnit {
            get {
                return 0;
            }
            set {}
        }
        public int ExpectedOutputVidSize {
            get {
                return 0;
            }
            set {}
        }
        public PersecUnit ExpectedOutputBitrateUnit { 
            get {
                return 0;
            }
            set { }
        }


        //해상도 변환
        public ConvertResolutionBase ConvertResolutionBase {
            get {
                return 0;
            }
            set {}
        }
        public int ConvertResolutionSize {
            get {
                return 0;
            }
            set {}
        }
        public FilesizeUnit ConvertedVideoSizeUnit {
            get {
                return 0;
            }
            set {}
        }
    }
}
