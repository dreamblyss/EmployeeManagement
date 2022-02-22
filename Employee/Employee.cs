using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Employee
{
    class Employee
    {
        //staff id - ro, fullname - ro, job title, employment date - ro, department

        private int _staffId;
        private string _fullName;
        private string _employDate;

        public Employee(int staffId, string fullName, string employDate)
        {
            _staffId = staffId;
            _fullName = fullName;
            _employDate = employDate;
        }

        public int StaffId { get { return _staffId; } }
        public string FullName { get { return _fullName; } }

        public string EmployDate { get { return _employDate; } }

        public string JobTitle { get; set; }

        public string Department { get; set; }

        //clockin(), clockout(), work()

        public DateTime ClockIn()
        {
            string clockIn = "";

            DateTime clockintime = default(DateTime);

            while (String.IsNullOrEmpty(clockIn))
            {
                Console.WriteLine("Enter \"Y\" to clockin: ");
                string click = Console.ReadLine().ToUpper();

                if (click == "Y")
                {
                    clockintime = DateTime.Now;
                    //clockIn = clockintime.ToString("t");
                }
                else
                {

                    Console.WriteLine("Enter \"Y\" to Clock In");
                }
            }


            return clockintime;
        }


        public DateTime ClockOut()
        {


            string clockOut = "";

            DateTime clockoutime = default(DateTime);

            while (String.IsNullOrEmpty(clockOut))
            {
                Console.WriteLine("Enter \"Y\" to clockout: ");
                string click = Console.ReadLine().ToUpper();

                if (click == "Y")
                {
                    clockoutime = DateTime.Now;
                    //clockIn = clockintime.ToString("t");
                }
                else
                {

                    Console.WriteLine("Enter \"Y\" to Clock Out");
                }
            }

            return clockoutime;

        }

        public void Work()
        {

            DateTime timeIn = ClockIn();
            DateTime timeOut = ClockOut();

            TimeSpan workDuration = TimeSpan.Zero;
            workDuration = timeOut.Subtract(timeIn.Date);
            string hours = workDuration.Hours.ToString();
            string minutes = workDuration.Minutes.ToString();

            Console.WriteLine($"You worked for {hours} hours and {minutes} minutes");

        }

        public override string ToString()
        {

            return this.StaffId + " " + this.FullName + " " + this.JobTitle + " " +
                this.Department + " " + this.JobTitle;


        }

    }


}