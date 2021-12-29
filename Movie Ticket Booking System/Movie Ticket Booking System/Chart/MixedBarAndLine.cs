using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Ticket_Booking_System.Chart
{
    class MixedBarAndLine
    {
        public static List<double> revenue;
        public static List<int> quantity;
        public static void loadChart(Guna.Charts.WinForms.GunaChart chart, string type)
        {
            List<string> dayOfWeek = new List<string>();
            int index = 6;
            while (index >= 0)
                dayOfWeek.Add(DateTime.Today.AddDays(-index--).DayOfWeek.ToString());

            //Chart configuration 
            chart.YAxes.GridLines.Display = false;

            if(type == "line")
            {
                var lineDataset = new Guna.Charts.WinForms.GunaSplineAreaDataset();
                lineDataset.FillColor = Color.FromArgb(84, 193, 254);
                lineDataset.Label = "Số lượng vé";
                lineDataset.BorderColor = lineDataset.FillColor;
                lineDataset.PointBorderWidth = 1;
                lineDataset.PointRadius = 5;
                lineDataset.PointStyle = PointStyle.Circle;

                /* Real Data from Database*/
                for (int i = 0; i < dayOfWeek.Count; i++)
                    lineDataset.DataPoints.Add(dayOfWeek[i], quantity[i]);

                //Add a new dataset to a chart.Datasets
                chart.Datasets.Add(lineDataset);
            }
            else
            {
                var dataset = new Guna.Charts.WinForms.GunaBarDataset();
                dataset.Label = "Doanh thu";
                for (int i = 0; i < dayOfWeek.Count; i++)
                    dataset.DataPoints.Add(dayOfWeek[i], revenue[i]);
                chart.Datasets.Add(dataset);
            }

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
