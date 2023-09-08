namespace interviewstatus
{
    using System;
    using System.Collections.Generic;
    using System.Web.UI.WebControls;
    using System.Drawing;
    using System.Web.Services;

    public partial class data : System.Web.UI.Page
    {
        List<Employee> employees = new List<Employee>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        [WebMethod]
        public static string GetDateandStatus()
        {
            List<Employee> employees_1 = new List<Employee>();
            Repo repo = Repo.GetInstance();
            employees_1 = repo.GetEmployees(1);
            string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(employees_1);
            return jsonData;
        }

        void GetData()
        {
            employees.Clear();
            Repo repo = Repo.GetInstance();
            employees = repo.GetEmployees(1);
        }
        private Dictionary<DateTime, string> GetEmployeeAttendanceData()
        {
            GetData();
            Dictionary<DateTime, string> attendanceData = new Dictionary<DateTime,string>();
            for (int i = 0; i < employees.Count; i++)
            {
                attendanceData[employees[i].JobDate] = employees[i].JobStatus;
            }
            return attendanceData;
        }

       

        //protected void myCalendar_DayRender(object sender, DayRenderEventArgs e)
        //{
        //    GetData();
        //    int year = 2023; // Specify the year
        //    int month = 8;   // Specify the month

        //    DateTime startDate = new DateTime(year, month, 1);
        //    DateTime endDate = startDate.AddMonths(1).AddDays(-1);

        //    for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
        //    {
        //        for (int i = 0; i < employees.Count; i++)
        //        {
        //            if (currentDate.Equals(employees[i].JobDate)) // Change this condition to your desired one
        //            {
        //                DateTime targetDate = employees[i].JobDate; // Change this to your desired date

        //                if (e.Day.Date == targetDate)
        //                {
        //                    if (employees[i].JobStatus== "present")
        //                    {
        //                        e.Cell.BackColor = Color.Green; // Change to your desired color
        //                        e.Cell.ToolTip = "Selected"; // Optional: Add a tooltip
        //                    }
        //                    else if (employees[i].JobStatus == "absent")
        //                    {
        //                        e.Cell.BackColor = Color.Blue; // Change to your desired color
        //                        e.Cell.ToolTip = "absent"; // Optional: Add a tooltip
        //                    }

        //                }
        //            }
        //        }

        //    }
        //}

        protected void myCalendar_DayRender(object sender, DayRenderEventArgs e)
        {
            
            Dictionary<DateTime, string> attendanceData = GetEmployeeAttendanceData();

            if (attendanceData.ContainsKey(e.Day.Date))
            {
                string status = attendanceData[e.Day.Date];
                switch (status)
                {
                    case "Present":
                        e.Cell.BackColor = Color.Green;
                        e.Cell.ForeColor = Color.White;
                        e.Cell.ToolTip = "Employee was present";
                        break;
                    case "absent":
                        e.Cell.BackColor = Color.Gray;
                        e.Cell.ForeColor = Color.White;
                        e.Cell.ToolTip = "Employee was absent";
                        break;
                    case "hold":
                        e.Cell.BackColor = Color.Orange;
                        e.Cell.ToolTip = "Employee is on hold";
                        break;
                }
            }

            // Check if the date matches your condition

        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {

        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public DateTime JobDate { get; set; }
        public string JobDescription { get; set; }
        public string JobStatus { get; set; }
        public string Name { get; set; }
    }
}