using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Styles;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Drawing;
using Syncfusion.WinForms.Core.Utils;
using System;

namespace GettingStarted
{   
    public partial class Form1 : Form
    {
        BusyIndicator buysIndicator = new BusyIndicator();

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, System.EventArgs e)
        {
            //To add built-in busy indicator
            //sfDataGrid.ShowBusyIndicator = true;
            
            //OR

            //To add busy indicator control for SfDataGrid based on requirement.
            buysIndicator.Show(sfDataGrid.TableControl);
            var data = new OrderInfoCollection();
            sfDataGrid.DataSource = data.OrdersListDetails;
            //To hide the busy indicator after the process is completed.
            buysIndicator.Hide();
        }
    }
}
