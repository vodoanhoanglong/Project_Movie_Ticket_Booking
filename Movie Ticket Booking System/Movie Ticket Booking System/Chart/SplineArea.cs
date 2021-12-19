using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Ticket_Booking_System.Chart
{
    class SplineArea
    {
        public static List<double> data;

        public static void loadChart(Guna.Charts.WinForms.GunaChart chart)
        {
            //Chart configuration 
            chart.YAxes.GridLines.Display = false;

            List<string> dayOfWeek = new List<string>();
            int index = 6;

            while (index >= 0)
                dayOfWeek.Add(DateTime.Today.AddDays(-index--).DayOfWeek.ToString());

            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaSplineAreaDataset();
            dataset.Label = "Doanh thu theo ngày trong tuần";
            dataset.PointRadius = 3;
            dataset.PointStyle = PointStyle.Circle;

            for (int i = 0; i < dayOfWeek.Count; i++)
                dataset.DataPoints.Add(dayOfWeek[i], data[i]);

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
