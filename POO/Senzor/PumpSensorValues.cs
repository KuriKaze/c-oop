﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Sensor
{
    
    public delegate void OnNewSensorValue(SensorValue sensorBaseArg);
    public class PumpSensorValues
    {
        public event OnNewSensorValue newSensorValueEvent;
        Timer timerBase;
        Random myRandom;

        private string patientCode;

        public PumpSensorValues(string patientCode, int periodSecoundsBetweenValues) : this(periodSecoundsBetweenValues)
        {
            this.patientCode = patientCode;
        }
        public PumpSensorValues(int periodSecoundsBetweenValues)
        {
            //start the random nr gen
            myRandom = new Random();
            //devine the timer for pumping sensor values
            timerBase = new Timer();
            timerBase.Interval = periodSecoundsBetweenValues * 1000; //interval between ticks
            timerBase.Elapsed += new ElapsedEventHandler(timerBase_Elapsed);
        }
        public void StartPumping()
        {
            timerBase.Start();
        }
        public void StopPumping()
        {
            timerBase.Stop();
        }
        private void timerBase_Elapsed(Object sender, ElapsedEventArgs e)
        {
            int minNumber, maxNumer;
            double valueRandom;
            //1.get a random sensor type
            //1.1 find the bounderies for this random type
            int maxSensorType = System.Enum.GetValues(typeof(SensorType)).GetUpperBound(0);
            //1.2 get a random number between 0 and maxSensorType
            int typeRandom = myRandom.Next(1, maxSensorType + 1);
            SensorType sensorTypeRandom = (SensorType)typeRandom;
            //2. get a rand value for the current sensorTypeRandom
            //2.1 find the bounderies for the current type
            switch (sensorTypeRandom)
            {
                case SensorType.SkinTemperature:
                    minNumber = 36;
                    maxNumer = 40;
                    valueRandom = myRandom.Next(minNumber * 10, (maxNumer + 1) * 10) / 10.0;
                    break;
                case SensorType.BloodGlucose:
                    minNumber = 80;
                    maxNumer = 300;
                    valueRandom = myRandom.Next(minNumber, maxNumer + 1);
                    break;
                case SensorType.HearhRate:
                    minNumber = 50;
                    maxNumer = 300;
                    valueRandom = myRandom.Next(minNumber, maxNumer + 1);
                    break;
                default:
                    valueRandom = 0;
                    break;
            }

            SensorValue sensorRandom = new SensorValue(patientCode , sensorTypeRandom, valueRandom, DateTime.Now);
            Program.DisplaySensorValues("New sensor value arrived : ", sensorRandom);
            if (newSensorValueEvent != null)
            {
                newSensorValueEvent(sensorRandom);
            }
        }

    }
}
