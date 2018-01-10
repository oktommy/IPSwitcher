using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblIPInfo.Text = string.Join("\r\n", GetIpAddressInfo());
            //notifyIcon1.Visible = true;
            cboGateway.SelectedItem = "10.169.1.1";
            //BindContextMenu();
        }

       // private void BindContextMenu()
       // {
       //     ToolStripMenuItem gatwaySubmenu, subItem;
       //     gatwaySubmenu = new ToolStripMenuItem("Network Gateway");
       //     gatwaySubmenu.DropDownItems.Add("10.169.1.1", null, (sender, args) =>
       //     {
       //         var selectedNic = (NetworkInterface)cboNic.SelectedItem;
       //         string targetIP =
       //selectedNic.GetIPProperties()
       //    .UnicastAddresses.FirstOrDefault(s => s.Address.AddressFamily == AddressFamily.InterNetwork)
       //    .Address.ToString();
       //         IPTool ipTool = new IPTool();
       //         ipTool.setGateway( , "10.169.1.1");
       //     });
       // }
       
        private List<KeyValuePair<string, string>> GetIpAddressInfo()
        {
            List<KeyValuePair<string,string>> result = new List<KeyValuePair<string, string>>();

            string hostName = Dns.GetHostName();
            var hostAddresses = Dns.GetHostAddresses(hostName);

            var hostAddress = hostAddresses.FirstOrDefault(s => s.AddressFamily == AddressFamily.InterNetwork);
            var allNics = NetworkInterface.GetAllNetworkInterfaces();
            cboNic.DataSource = allNics;
            cboNic.ValueMember = "Id";
            cboNic.DisplayMember = "Name";
            
            result.Add(new KeyValuePair<string, string>("HostName", hostName));
            //result.Add(new KeyValuePair<string, string>("NIC Name", nicCard.Name));
            result.Add(new KeyValuePair<string, string>("IP", hostAddress.ToString()));
            //result.Add(new KeyValuePair<string, string>("Subnet", ipInfo.UnicastAddresses.FirstOrDefault().IPv4Mask.ToString()));
            //result.Add(new KeyValuePair<string, string>("Gateway", ipInfo.GatewayAddresses.FirstOrDefault().Address.ToString()));

            return result;
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            var selectedNic = (NetworkInterface) cboNic.SelectedItem;
            
            string targetIP =
                selectedNic.GetIPProperties()
                    .UnicastAddresses.FirstOrDefault(s => s.Address.AddressFamily == AddressFamily.InterNetwork)
                    .Address.ToString();
            string gateway = cboGateway.SelectedItem.ToString();
            List<KeyValuePair<string, string>> result = new List<KeyValuePair<string, string>>();
            result.Add(new KeyValuePair<string, string>("NIC Description", selectedNic.Description));
            result.Add(new KeyValuePair<string, string>("IP", targetIP));
            //result.Add(new KeyValuePair<string, string>("Gateway", gateway));
            try
            {
                IPTool ipTool = new IPTool();
                ipTool.setGateway(targetIP, cboGateway.SelectedItem.ToString());

                result.Add(new KeyValuePair<string, string>("Gateway Changed to: ", gateway ));
            }
            catch (Exception ex)
            {
                result.Add(new KeyValuePair<string, string>("Set Gateway Error", ex.Message));
            }
            lblIPInfo.Text = string.Join("\r\n", result);
        }
    }
}
