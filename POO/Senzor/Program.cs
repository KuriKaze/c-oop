using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sensor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Instantierea clasei SensorValue\n\r");

            //instantiere const implicit
            SensorValue sensor1 = new SensorValue();
            sensor1.Type = SensorType.BloodGlucose;
            sensor1.TimeStamp = DateTime.Now;
            sensor1.Value = 100; //mg/dl
            DisplaySensorValues("Primul sensor initializat ", sensor1);

            //instantiere folosind const cu parametrii								dd-MMM-yy HH:mm:ss
            SensorValue sensor2 = new SensorValue(SensorType.SkinTemperature, 36.7, "23-Jan-10 14:56:00");
            DisplaySensorValues("Al 2lea sensor initializat", sensor2);
            PumpSensorValues sensorValuesPump = new PumpSensorValues(3);
            sensorValuesPump.StartPumping();

            Console.ReadLine();
            sensorValuesPump.StopPumping();
        }
        internal static void DisplaySensorValues(string headerText, SensorValue sensor)
        {
            Console.WriteLine("\t " + headerText);
            Console.WriteLine("\t\t Type= {0}", sensor.Type.ToString());
            Console.WriteLine("\t\t TimeStamp= {0}", sensor.TimeStampString);
            Console.WriteLine("\t\t Value= {0}", sensor.Value.ToString("0.00"));
        }
    }
}
