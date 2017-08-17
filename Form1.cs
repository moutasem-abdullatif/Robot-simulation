using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace gatali
{


    public partial class Form1 : Form
    {


        int counter_x = 0;
        int counter_y = 0;
        int counter_sum=0;
        int index_x = 0;
        int index_y = 0;

        int chart1_counter = 0;
        int chart2_counter = 0;
        int intersections_counter = 0;

        IList<int> route_x_list = new List<int>();
        IList<int> route_y_list = new List<int>();

        IList<int> chart1_x_points_list = new List<int>();
        IList<int> chart1_y_points_list = new List<int>();
        IList<int> chart2_x_points_list = new List<int>();
        IList<int> chart2_y_points_list = new List<int>();
        IList<int> intersect_x_points_list = new List<int>();
        IList<int> intersect_y_points_list = new List<int>();


        public Form1()
        {
            InitializeComponent();
        }

        
        private void btn_go_Click(object sender, EventArgs e)
        {
            route_x_list.Clear();
            route_y_list.Clear();

            chart1_x_points_list.Clear();
            chart1_y_points_list.Clear();

            counter_x = 0; index_x = 0;
            counter_y = 0; index_y = 0;

            chart1_counter = 0;

            int AGV1_x0 = Convert.ToInt32(AGV1_start_x.Text);
            int AGV1_y0 = Convert.ToInt32(AGV1_start_y.Text);
            int AGV1_x1 = Convert.ToInt32(AGV1_target_x.Text);
            int AGV1_y1 = Convert.ToInt32(AGV1_target_y.Text);

            
            AGV1_route_list.Items.Clear();

            if (AGV1_x0 < AGV1_x1)
            {
                x_increment(AGV1_x0, AGV1_x1, AGV1_y0, AGV1_y1);
            }

            if (AGV1_x0 > AGV1_x1)
            {
                x_decrement(AGV1_x0, AGV1_x1, AGV1_y0, AGV1_y1);
            }

            if (AGV1_y0 < AGV1_y1)
            {
                y_increment(AGV1_x0, AGV1_x1, AGV1_y0, AGV1_y1);
            }

            if (AGV1_y0 > AGV1_y1)
            {
                y_decrement(AGV1_x0, AGV1_x1, AGV1_y0, AGV1_y1);
            }

            counter_sum = counter_x + counter_y;
            chart1_counter = counter_sum;


            lbl_AGV1_totalX.Text = counter_x.ToString();
            lbl_AGV1_totalY.Text = counter_y.ToString();
            lbl_AGV1_totalRoute.Text = counter_sum.ToString();

            chart1_x_points_list = route_x_list.Select(x => x).ToList();
            chart1_y_points_list = route_y_list.Select(x => x).ToList();


            for (int i = 0; i < counter_sum; i++)
            {
                AGV1_route_list.Items.Add(route_x_list[i]+","+route_y_list[i]);
            }
            
        }

        private void AGV2_btn_go_Click(object sender, EventArgs e)
        {
            route_x_list.Clear();
            route_y_list.Clear();


            counter_x = 0; index_x = 0;
            counter_y = 0; index_y = 0;

            chart2_counter = 0;

            chart2_x_points_list.Clear();
            chart2_y_points_list.Clear();

            int AGV2_x0 = Convert.ToInt32(AGV2_start_x.Text);
            int AGV2_y0 = Convert.ToInt32(AGV2_start_y.Text);
            int AGV2_x1 = Convert.ToInt32(AGV2_target_x.Text);
            int AGV2_y1 = Convert.ToInt32(AGV2_target_y.Text);


            AGV2_route_list.Items.Clear();

            if (AGV2_x0 < AGV2_x1)
            {
                x_increment(AGV2_x0, AGV2_x1, AGV2_y0, AGV2_y1);
            }

            if (AGV2_x0 > AGV2_x1)
            {
                x_decrement(AGV2_x0, AGV2_x1, AGV2_y0, AGV2_y1);
            }

            if (AGV2_y0 < AGV2_y1)
            {
                y_increment(AGV2_x0, AGV2_x1, AGV2_y0, AGV2_y1);
            }

            if (AGV2_y0 > AGV2_y1)
            {
                y_decrement(AGV2_x0, AGV2_x1, AGV2_y0, AGV2_y1);
            }

            counter_sum = counter_x + counter_y;
            chart2_counter = counter_sum;


            lbl_AGV2_totalX.Text = counter_x.ToString();
            lbl_AGV2_totalY.Text = counter_y.ToString();
            lbl_AGV2_totalRoute.Text = counter_sum.ToString();

            chart2_x_points_list = route_x_list.Select(x => x).ToList();
            chart2_y_points_list = route_y_list.Select(x => x).ToList();

            for (int i = 0; i < counter_sum; i++)
            {
                AGV2_route_list.Items.Add(route_x_list[i] + "," + route_y_list[i]);
            }

        }

       public void x_increment(int x0, int x1, int y0, int y1)
        {
            for (int i = x0; i <= x1; i++)
            {
                route_x_list.Insert(index_x, i);
                index_x++;

                route_y_list.Insert(index_y, y0);
                index_y++;

                counter_x++;   
                
            }
        }

       public void x_decrement(int x0, int x1, int y0, int y1)
       {

          
          for (int i = x0; i >= x1; i--)
           {

               route_x_list.Insert(index_x, i);
               index_x++;

               route_y_list.Insert(index_y, y0);
               index_y++;
               
               counter_x++;
           }
       }

       public void y_increment(int x0, int x1, int y0, int y1)
       {
           for (int i = y0; i <= y1; i++)
           {

               route_y_list.Insert(index_y, i);
               index_y++;

               route_x_list.Insert(index_x, x1);
               index_x++;

               counter_y++;
                      
           }
       }

       public void y_decrement(int x0, int x1, int y0, int y1)
       {

           for (int i = y0; i >= y1; i--)
           {

               route_y_list.Insert(index_y, i);
               index_y++;

               route_x_list.Insert(index_x, x1);
               index_x++;
               
               counter_y++;
                
           }

       }

       private void button1_Click(object sender, EventArgs e)
       {
            //cakismalari bul ayri bir diziye ata ve ciz
            intersections_counter = 0;
            intersect_x_points_list.Clear();
            intersect_y_points_list.Clear();

            for (int i = 0; i < chart1_x_points_list.Count; i++)
            {
                for (int j = 0; j < chart2_x_points_list.Count; j++)
                {
                    if (chart1_x_points_list[i] == chart2_x_points_list[j] && chart1_y_points_list[i] == chart2_y_points_list[j])
                    {
                        intersect_x_points_list.Insert(intersections_counter, chart1_x_points_list[i]);
                        intersect_y_points_list.Insert(intersections_counter, chart1_y_points_list[i]);
                        intersections_counter++;
                    }
                }
            }

            //Basamaklarin araligi
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Interval = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;


            chart1.Series.Clear();
            chart1.Series.Add("Route_1");
            chart1.Series.Add("Route_2");
            chart1.Series.Add("Intersections");

            //Route_1 renki ve kalinligi
            chart1.Series["Route_1"].Color = Color.Green;
            chart1.Series["Route_1"].MarkerSize = 10;


            //Route_2 renki ve kalinligi
            chart1.Series["Route_2"].Color = Color.Red;
            chart1.Series["Route_2"].MarkerSize = 10;

            //Cakismalarin renki ve kalinligi
            chart1.Series["Intersections"].Color = Color.Orange;
            chart1.Series["Intersections"].MarkerSize = 12;

            //Route_1 Route_2 chart tipi
            chart1.Series["Route_1"].ChartType = SeriesChartType.Point;
            chart1.Series["Route_2"].ChartType = SeriesChartType.Point;
            chart1.Series["Intersections"].ChartType = SeriesChartType.Point;


            for (int i = 0; i < chart1_counter; i++)
            {
                chart1.Series["Route_1"].Points.AddXY(chart1_x_points_list[i], chart1_y_points_list[i]);
            }

            for (int i = 0; i < chart2_counter; i++)
            {
                chart1.Series["Route_2"].Points.AddXY(chart2_x_points_list[i], chart2_y_points_list[i]);
            }

            for (int i = 0; i < intersections_counter; i++)
            {
                chart1.Series["Intersections"].Points.AddXY(intersect_x_points_list[i],intersect_y_points_list[i]);
            }
        }



    }
}
