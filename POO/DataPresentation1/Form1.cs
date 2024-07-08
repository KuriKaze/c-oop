using Sensor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPresentation1
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
             
            InitializeComponent();
            cbPatientCodeStart.DataSource = Enum.GetValues(typeof(PatientCodeEnum));
            

            PumpSensorValues sensorValuePump = new PumpSensorValues(3);
            sensorValuePump.StartPumping();
            sensorValuePump.newSensorValueEvent += new OnNewSensorValue(OnNewSensorValueHandler);
        }
        List<SensorValue> sensorValueList = new List<SensorValue>();
       void OnNewSensorValueHandler(SensorValue sensorBaseArg)
       {
            sensorValueList.Insert(0, sensorBaseArg);
            this.BeginInvoke(new Action(BindDataGridToListOfValues));
          //  MessageBox.Show("Type=" + sensorBaseArg.Type.ToString() + " Timestamp=" + sensorBaseArg.TimeStampString);
       }
        private void BindDataGridToListOfValues()
        {
            dgSensorValueList.DataSource = null;
            dgSensorValueList.DataSource = sensorValueList;
        }

        private void bStartPumping_Click(object sender, EventArgs e)
        {
            int timePeriodSeconds = 1;
            if (cbPatientCodeStart.SelectedItem != null && tbTimePeriod.Text != string.Empty)
            {
                try
                {
                    timePeriodSeconds = Convert.ToInt32(tbTimePeriod.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: the Time period text cannot be converted into integer -> " + ex.Message);
                }
                PatientCodeEnum currPatient = (PatientCodeEnum)cbPatientCodeStart.SelectedItem;
                startPumping(currPatient, timePeriodSeconds);
            }   
        }
        Dictionary<PatientCodeEnum, PumpSensorValues> dictPatientPump = new Dictionary<PatientCodeEnum, PumpSensorValues>();
        private void startPumping(PatientCodeEnum patCodeEnum, int periodSeconds)
        {
            if (dictPatientPump.ContainsKey(patCodeEnum))
            {
                MessageBox.Show("The selected patient has the pump already started");
                return;
            }
            PumpSensorValues sensorValuesPump = new PumpSensorValues(patCodeEnum.ToString(), periodSeconds);
            sensorValuesPump.StartPumping();
            sensorValuesPump.newSensorValueEvent += new OnNewSensorValue(OnNewSensorValueHandler);
            dictPatientPump.Add(patCodeEnum, sensorValuesPump);
        }

        private void bStopPumping_Click(object sender, EventArgs e)
        {
            PatientCodeEnum currPatientStop = (PatientCodeEnum) cbPatientCodeStart.SelectedItem;
            if (dictPatientPump.ContainsKey(currPatientStop))
            {
                PumpSensorValues pumpToBeStopped = dictPatientPump[currPatientStop];
                pumpToBeStopped.StopPumping();
                dictPatientPump.Remove(currPatientStop);
            }
            else
            {
                MessageBox.Show("The selected patient has no pump values started");
            }
        }

        private void tbTimePeriod_TextChanged(object sender, EventArgs e)
        {
            tbTimePeriod.Text = "";
            tbTimePeriod.Text += string.Format(tbTimePeriod.Text);
        }

     
    }
}
