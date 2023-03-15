﻿namespace Models
{
    public class Patient_Basic_Record
    {
        public Patient_Basic_Record()
        {

        }
        public Guid Id { get; set; }
        public DateTime Date_Time { get; set; }
        public string Patient_Id { get; set; }
        public string Nurse_Id { get; set; }
        public string Bp { get; set; }
        public int Heart_Rate { get; set; }
        public string SpO2 { get; set; }

    }
}
