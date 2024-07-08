using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Sensor
{
    public enum PatientCodeEnum
    {
        Patient_01,
        Patient_02,
        Patient_03,
        Patient_04,
        Patient_05,
        Patient_06
    }


    public enum SensorType
    {
        None,
        SkinTemperature,
        HearhRate,
        BloodGlucose
    }
    public class SensorValue
    {
        private string patientCode;
        private SensorType type;
        private double value;
        private DateTime timeStamp;


        #region properties
        public string PatientCode
        {
            get { return patientCode; }
            set { patientCode = value; }
        }
        public SensorType Type
        {
            get { return type; }
            set { type = value; }
        }
        public double Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        public DateTime TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }
        public string TimeStampString
        {
            get { return timeStamp.ToString("dd-MMM-yy HH:mm:ss"); }
            set { timeStamp = DateTime.ParseExact(value, "dd-MMM-yy HH:mm:ss", CultureInfo.InvariantCulture); }
        }
        #endregion
        #region constructors
        public SensorValue()
        {
            type = SensorType.None;
        }
        public SensorValue(SensorType type, double value, DateTime timeStamp)
        {
            this.type = type;
            this.value = value;
            this.timeStamp = timeStamp;
        }
        public SensorValue(SensorType type, double value, string timeStamp)
        {
            this.type = type;
            this.value = value;
            this.TimeStampString = timeStamp;
        }
        public SensorValue(string patientCode, SensorType type, double value, DateTime timeStamp)
        {
            this.patientCode = patientCode;
            this.type = type;
            this.value = value;
            this.timeStamp = timeStamp;
        }

        #endregion
    }
}
